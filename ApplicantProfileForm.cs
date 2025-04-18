using System;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using Guna.UI2.WinForms;

namespace pm
{
    public partial class ApplicantProfileForm : Form
    {
        private int _userId;

        public ApplicantProfileForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT 
                                    фио, паспортные_данные, снилс, электронная_почта, 
                                    телефон, фио_родителя, учебное_заведение, 
                                    средний_балл_аттестата, средний_балл_диплома
                                  FROM абитуриент 
                                  WHERE id_пользователя = @userId";

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
                                txtDiplomaScore.Text = reader["средний_балл_диплома"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных профиля: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE абитуриент SET
                                    фио = @fullName,
                                    паспортные_данные = @passport,
                                    снилс = @snils,
                                    электронная_почта = @email,
                                    телефон = @phone,
                                    фио_родителя = @parentName,
                                    учебное_заведение = @school,
                                    средний_балл_аттестата = @avgScore,
                                    средний_балл_диплома = @diplomaScore
                                    WHERE id_пользователя = @userId";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@fullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@passport", txtPassport.Text);
                        cmd.Parameters.AddWithValue("@snils", txtSnils.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@parentName", txtParentName.Text);
                        cmd.Parameters.AddWithValue("@school", txtSchool.Text);
                        cmd.Parameters.AddWithValue("@avgScore", string.IsNullOrEmpty(txtAvgScore.Text) ? (object)DBNull.Value : decimal.Parse(txtAvgScore.Text));
                        cmd.Parameters.AddWithValue("@diplomaScore", string.IsNullOrEmpty(txtDiplomaScore.Text) ? (object)DBNull.Value : decimal.Parse(txtDiplomaScore.Text));
                        cmd.Parameters.AddWithValue("@userId", _userId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные успешно сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
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
    }
}