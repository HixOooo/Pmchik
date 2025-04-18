using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Npgsql;
using System.Configuration;

namespace pm
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT id_пользователя, id_роли FROM пользователь WHERE логин = @login AND пароль = @password";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", GetMD5Hash(password));

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32(0);
                                int roleId = reader.GetInt32(1);

                                this.Hide();

                                if (roleId == 1) // Абитуриент
                                {
                                    new ApplicantMenuForm(userId).Show();
                                }
                                else if (roleId == 2) // Администратор
                                {
                                    new AdminForm(userId).Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private bool mouseDown;
        private Point lastLocation;

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new RegisterForm();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Show();
            }
        }
    }
}