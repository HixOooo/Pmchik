using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using Guna.UI2.WinForms;

namespace pm
{
    public partial class ManageDirectionsForm : Form
    {
        private int _userId;

        public ManageDirectionsForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadEducationLevels();
            LoadDirections();
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки уровней образования: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDirections()
        {
            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT 
                                    н.id_направления,
                                    н.код_направления,
                                    н.название_направления,
                                    у.название_уровня
                                FROM направление_подготовки н
                                JOIN уровень_образования у ON н.id_уровня = у.id_уровня
                                ORDER BY у.название_уровня, н.код_направления";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        var adapter = new NpgsqlDataAdapter(cmd);
                        var table = new DataTable();
                        adapter.Fill(table);

                        dgvDirections.DataSource = table;
                        dgvDirections.Columns["id_направления"].Visible = false;
                        dgvDirections.Columns["код_направления"].HeaderText = "Код";
                        dgvDirections.Columns["название_направления"].HeaderText = "Название";
                        dgvDirections.Columns["название_уровня"].HeaderText = "Уровень";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки направлений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbEducationLevel.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO направление_подготовки (код_направления, название_направления, id_уровня) VALUES (@code, @name, @levelId)";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@code", txtCode.Text);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@levelId", Convert.ToInt32(cmbEducationLevel.SelectedValue));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Направление успешно добавлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDirections();
                txtCode.Text = "";
                txtName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления направления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDirections.CurrentRow == null)
            {
                MessageBox.Show("Выберите направление для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Удалить выбранное направление?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int directionId = Convert.ToInt32(dgvDirections.CurrentRow.Cells["id_направления"].Value);

                    using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM направление_подготовки WHERE id_направления = @id";

                        using (var cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", directionId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Направление успешно удалено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDirections();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления направления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Скрываем текущую форму
            var adminForm = new AdminForm(_userId); // Создаем новую форму AdminForm
            adminForm.Show(); // Показываем форму администратора
        }
    }
}