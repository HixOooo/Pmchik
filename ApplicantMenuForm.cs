using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Npgsql;
using System.Configuration;

namespace pm
{
    public partial class ApplicantMenuForm : Form
    {
        private int _userId;

        public ApplicantMenuForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadApplicantData();
        }

        private void LoadApplicantData()
        {
            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT а.фио 
                                  FROM абитуриент а
                                  JOIN пользователь п ON а.id_пользователя = п.id_пользователя
                                  WHERE а.id_пользователя = @userId";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", _userId);
                        var fullName = cmd.ExecuteScalar()?.ToString();
                        lblWelcome.Text = $"Добро пожаловать, {fullName ?? "Абитуриент"}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ApplicantDashboardForm(_userId).Show();
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ApplicationForm(_userId).Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ApplicantProfileForm(_userId).Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AuthForm().Show();
        }

        private void ApplicantMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}