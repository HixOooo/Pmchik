using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using System.Data;
using Guna.UI2.WinForms;
using System.IO;

namespace pm
{
    public partial class ApplicationForm : Form
    {
        private int _userId;
        private List<int> _selectedSpecializations = new List<int>();

        public ApplicationForm(int userId)
        {
            InitializeComponent();
            _userId = userId;

            if (!CheckApplicantProfileExists(userId))
            {
                MessageBox.Show("Пожалуйста, сначала заполните профиль абитуриента", "Требуется заполнение",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            LoadEducationLevels();
            LoadApplicantData();
        }

        private bool CheckApplicantProfileExists(int userId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT 1 FROM абитуриент WHERE id_пользователя = @userId";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        return cmd.ExecuteScalar() != null;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void LoadApplicantData()
        {
            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT фио, паспортные_данные, снилс, электронная_почта, телефон, 
                                  фио_родителя, учебное_заведение, средний_балл_аттестата 
                                  FROM абитуриент WHERE id_пользователя = @userId";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", _userId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader["фио"].ToString();
                                txtPassport.Text = reader["паспортные_данные"].ToString();
                                txtSnils.Text = reader["снилс"].ToString();
                                txtEmail.Text = reader["электронная_почта"].ToString();
                                txtPhone.Text = reader["телефон"].ToString();
                                txtParentName.Text = reader["фио_родителя"].ToString();
                                txtSchool.Text = reader["учебное_заведение"].ToString();
                                txtAvgScore.Text = reader["средний_балл_аттестата"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных абитуриента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки уровней образования: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEducationLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEducationLevel.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cmbEducationLevel.SelectedItem;
                int educationLevelId = Convert.ToInt32(selectedRow["id_уровня"]);
                LoadSpecializations(educationLevelId);
            }
        }

        private void LoadSpecializations(int educationLevelId)
        {
            try
            {
                cmbSpecializations.DataSource = null;
                _selectedSpecializations.Clear();
                lstSpecializations.Items.Clear();

                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT id_направления, код_направления || ' ' || название_направления 
                                    FROM направление_подготовки 
                                    WHERE id_уровня = @educationLevelId";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@educationLevelId", educationLevelId);
                        var adapter = new NpgsqlDataAdapter(cmd);
                        var table = new DataTable();
                        adapter.Fill(table);

                        cmbSpecializations.DataSource = table;
                        cmbSpecializations.DisplayMember = "?column?";
                        cmbSpecializations.ValueMember = "id_направления";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки направлений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSpecialization_Click(object sender, EventArgs e)
        {
            if (cmbSpecializations.SelectedValue == null)
            {
                MessageBox.Show("Выберите направление подготовки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstSpecializations.Items.Count >= 5)
            {
                MessageBox.Show("Можно выбрать не более 5 направлений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int specId = Convert.ToInt32(cmbSpecializations.SelectedValue);
            string specName = cmbSpecializations.Text;

            if (!_selectedSpecializations.Contains(specId))
            {
                _selectedSpecializations.Add(specId);
                lstSpecializations.Items.Add(specName);
            }
            else
            {
                MessageBox.Show("Это направление уже добавлено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            if (string.IsNullOrEmpty(uploadedFilePath))
            {
                MessageBox.Show("Загрузите скан документа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();

                    // 1. Получаем id абитуриента
                    int applicantId;
                    string getApplicantQuery = "SELECT id_абитуриента FROM абитуриент WHERE id_пользователя = @userId";
                    using (var cmd = new NpgsqlCommand(getApplicantQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", _userId);
                        applicantId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Копируем файл в папку приложения (например, "Scans")
                    string scansFolder = Path.Combine(Application.StartupPath, "Scans");
                    if (!Directory.Exists(scansFolder))
                        Directory.CreateDirectory(scansFolder);

                    string uniqueFileName = Guid.NewGuid().ToString() + ".pdf";
                    string savePath = Path.Combine(scansFolder, uniqueFileName);
                    File.Copy(uploadedFilePath, savePath, true);

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // 3. Создаем заявление (с путем к файлу)
                            string applicationQuery = @"
                        INSERT INTO заявление 
                        (id_абитуриента, id_уровня, статус, путь_к_документу) 
                        VALUES (@applicantId, @educationLevelId, 'ПОДАНО', @filePath) 
                        RETURNING id_заявления";

                            int applicationId;
                            using (var cmd = new NpgsqlCommand(applicationQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@applicantId", applicantId);
                                cmd.Parameters.AddWithValue("@educationLevelId", Convert.ToInt32(cmbEducationLevel.SelectedValue));
                                cmd.Parameters.AddWithValue("@filePath", savePath);
                                applicationId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            // 4. Добавляем направления (остаётся без изменений)
                            for (int i = 0; i < _selectedSpecializations.Count; i++)
                            {
                                string specQuery = @"
                            INSERT INTO заявление_направление 
                            (id_заявления, id_направления, приоритет) 
                            VALUES (@applicationId, @specId, @priority)";

                                using (var cmd = new NpgsqlCommand(specQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@applicationId", applicationId);
                                    cmd.Parameters.AddWithValue("@specId", _selectedSpecializations[i]);
                                    cmd.Parameters.AddWithValue("@priority", i + 1);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Заявление успешно подано!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (lstSpecializations.Items.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одно направление подготовки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPassport.Text) ||
                string.IsNullOrWhiteSpace(txtSnils.Text))
            {
                MessageBox.Show("Заполните все обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ApplicantMenuForm(_userId).Show();
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedFilePath = openFileDialog.FileName;
                MessageBox.Show("Файл успешно выбран: " + Path.GetFileName(uploadedFilePath), "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}