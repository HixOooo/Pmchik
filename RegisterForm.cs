using System;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using Guna.UI2.WinForms;

namespace pm
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPassport.Text) ||
                string.IsNullOrWhiteSpace(txtSnils.Text))
            {
                MessageBox.Show("Заполните все обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Пароль должен содержать минимум 6 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private string GetMD5Hash(string input)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                var sb = new System.Text.StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // 1. Создаем пользователя
                            string userQuery = @"INSERT INTO пользователь (логин, пароль, id_роли) 
                                              VALUES (@login, @password, 1) RETURNING id_пользователя";

                            int userId;
                            using (var cmd = new NpgsqlCommand(userQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                                cmd.Parameters.AddWithValue("@password", GetMD5Hash(txtPassword.Text));
                                userId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            // 2. Создаем абитуриента
                            string applicantQuery = @"INSERT INTO абитуриент 
                                                  (id_пользователя, фио, паспортные_данные, снилс, 
                                                   электронная_почта, телефон, фио_родителя, учебное_заведение)
                                                  VALUES 
                                                  (@userId, @fullName, @passport, @snils, 
                                                   @email, @phone, @parentName, @school)";

                            using (var cmd = new NpgsqlCommand(applicantQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@userId", userId);
                                cmd.Parameters.AddWithValue("@fullName", txtFullName.Text);
                                cmd.Parameters.AddWithValue("@passport", txtPassport.Text);
                                cmd.Parameters.AddWithValue("@snils", txtSnils.Text);
                                cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text);
                                cmd.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text);
                                cmd.Parameters.AddWithValue("@parentName", string.IsNullOrEmpty(txtParentName.Text) ? (object)DBNull.Value : txtParentName.Text);
                                cmd.Parameters.AddWithValue("@school", string.IsNullOrEmpty(txtSchool.Text) ? (object)DBNull.Value : txtSchool.Text);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Npgsql.PostgresException ex) when (ex.SqlState == "23505")
                        {
                            transaction.Rollback();
                            MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}