using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using Guna.UI2.WinForms;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace pm
{
    public partial class AdminForm : Form
    {
        private static readonly string[] Statuses = { "Все", "ПОДАНО", "ГОТОВО", "В ДОРАБОТКУ", "ОТКЛОНЕНО" };
        private int _userId;

        public AdminForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadApplications();
            LoadEducationLevels();
            InitializeStatusComboBoxes();
        }

        private void InitializeStatusComboBoxes()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(Statuses);
            cmbStatus.SelectedIndex = 0;

            cmbNewStatus.Items.Clear();
            cmbNewStatus.Items.AddRange(Statuses.Skip(1).ToArray()); // Пропускаем "Все"
        }

        private void LoadApplications(string filter = "")
        {
            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();

                    string baseQuery = @"
                SELECT 
                    з.id_заявления,
                    а.фио,
                    у.название_уровня,
                    з.дата_подачи,
                    з.статус,
                    з.путь_к_документу,  -- Добавляем путь к документу в запрос
                    STRING_AGG(н.код_направления || ' ' || н.название_направления, ', ' ORDER BY зн.приоритет) AS направления
                FROM заявление з
                JOIN абитуриент а ON з.id_абитуриента = а.id_абитуриента
                JOIN уровень_образования у ON з.id_уровня = у.id_уровня
                JOIN заявление_направление зн ON з.id_заявления = зн.id_заявления
                JOIN направление_подготовки н ON зн.id_направления = н.id_направления
                WHERE 1=1 " + filter + @"
                GROUP BY з.id_заявления, а.фио, у.название_уровня, з.дата_подачи, з.статус, з.путь_к_документу
                ORDER BY з.дата_подачи DESC";

                    using (var cmd = new NpgsqlCommand(baseQuery, connection))
                    {
                        var adapter = new NpgsqlDataAdapter(cmd);
                        var table = new DataTable();
                        adapter.Fill(table);

                        dgvApplications.DataSource = table;
                        ConfigureDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заявлений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            // Настраиваем колонки
            dgvApplications.Columns["id_заявления"].Visible = false;
            dgvApplications.Columns["фио"].HeaderText = "ФИО абитуриента";
            dgvApplications.Columns["название_уровня"].HeaderText = "Уровень";
            dgvApplications.Columns["дата_подачи"].HeaderText = "Дата подачи";
            dgvApplications.Columns["статус"].HeaderText = "Статус";
            dgvApplications.Columns["направления"].HeaderText = "Направления";

            // Добавляем скрытый столбец с путём к документу (если его нет)
            if (!dgvApplications.Columns.Contains("путь_к_документу"))
            {
                dgvApplications.Columns["путь_к_документу"].Visible = false;  // Скрываем, но оставляем для доступа
            }
        }

        private void LoadEducationLevels()
        {
            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT id_уровня, название_уровня FROM уровень_образования";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        var adapter = new NpgsqlDataAdapter(cmd);
                        var table = new DataTable();
                        adapter.Fill(table);

                        cmbEducationLevel.DataSource = table;
                        cmbEducationLevel.DisplayMember = "название_уровня";
                        cmbEducationLevel.ValueMember = "id_уровня";
                        cmbEducationLevel.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки уровней образования: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filter = "";

            if (cmbEducationLevel.SelectedValue != null)
                filter += $" AND з.id_уровня = {cmbEducationLevel.SelectedValue}";

            if (cmbStatus.SelectedIndex > 0)
                filter += $" AND з.статус = '{cmbStatus.SelectedItem}'";

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                filter += $" AND а.фио ILIKE '%{txtSearch.Text}%'";

            LoadApplications(filter);
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (dgvApplications.CurrentRow == null)
            {
                MessageBox.Show("Выберите заявление", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int applicationId = Convert.ToInt32(dgvApplications.CurrentRow.Cells["id_заявления"].Value);
            string newStatus = cmbNewStatus.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Выберите новый статус", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();

                    // Обновляем статус заявления
                    string query = "UPDATE заявление SET статус = @status WHERE id_заявления = @id";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", applicationId);
                        cmd.ExecuteNonQuery();
                    }

                    // Добавляем запись в историю
                    string historyQuery = @"INSERT INTO история_заявления 
                                         (id_заявления, id_пользователя, новое_значение) 
                                         VALUES (@appId, @userId, @newStatus)";
                    using (var cmd = new NpgsqlCommand(historyQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@appId", applicationId);
                        cmd.Parameters.AddWithValue("@userId", _userId);
                        cmd.Parameters.AddWithValue("@newStatus", newStatus);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Статус успешно изменен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadApplications();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка изменения статуса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteApplication_Click(object sender, EventArgs e)
        {
            if (dgvApplications.CurrentRow == null)
            {
                MessageBox.Show("Выберите заявление для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить это заявление? Все связанные данные будут также удалены.",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int applicationId = Convert.ToInt32(dgvApplications.CurrentRow.Cells["id_заявления"].Value);

                try
                {
                    using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                    {
                        connection.Open();

                        using (var transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                // Удаляем связанные записи из заявление_направление
                                string deleteDirectionsQuery = "DELETE FROM заявление_направление WHERE id_заявления = @id";
                                using (var cmd = new NpgsqlCommand(deleteDirectionsQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@id", applicationId);
                                    cmd.ExecuteNonQuery();
                                }

                                // Удаляем связанные записи из результат_егэ
                                string deleteResultsQuery = "DELETE FROM результат_егэ WHERE id_заявления = @id";
                                using (var cmd = new NpgsqlCommand(deleteResultsQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@id", applicationId);
                                    cmd.ExecuteNonQuery();
                                }

                                // Удаляем записи из история_заявления
                                string deleteHistoryQuery = "DELETE FROM история_заявления WHERE id_заявления = @id";
                                using (var cmd = new NpgsqlCommand(deleteHistoryQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@id", applicationId);
                                    cmd.ExecuteNonQuery();
                                }

                                // Удаляем само заявление
                                string deleteApplicationQuery = "DELETE FROM заявление WHERE id_заявления = @id";
                                using (var cmd = new NpgsqlCommand(deleteApplicationQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@id", applicationId);
                                    cmd.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                MessageBox.Show("Заявление успешно удалено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadApplications();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"Ошибка при удалении заявления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnViewDocument_Click(object sender, EventArgs e)
        {
            if (dgvApplications.CurrentRow == null)
            {
                MessageBox.Show("Выберите заявление", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем наличие столбца "путь_к_документу" в DataTable (а не в DGV)
            var dataTable = (DataTable)dgvApplications.DataSource;
            if (!dataTable.Columns.Contains("путь_к_документу"))
            {
                MessageBox.Show("Информация о документах недоступна", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получаем путь к файлу
            string filePath = dgvApplications.CurrentRow.Cells["путь_к_документу"].Value?.ToString();

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Документ не прикреплён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Проверяем существование файла
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"Документ не найден:\n{filePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Открываем файл через стандартное приложение
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManageDirections_Click(object sender, EventArgs e)
        {
            this.Hide();
            var manageDirectionsForm = new ManageDirectionsForm(_userId);
            manageDirectionsForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadApplications();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AuthForm().Show();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AuthForm().Show();
        }
    }
}