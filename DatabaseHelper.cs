using System;
using System.Configuration;
using System.Windows.Forms;
using Npgsql;

namespace pm
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString;

        public static void TestConnection()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Подключение к базе данных успешно установлено!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Проверка версии PostgreSQL
                    using (var cmd = new NpgsqlCommand("SELECT version();", connection))
                    {
                        var version = cmd.ExecuteScalar().ToString();
                        MessageBox.Show($"Версия PostgreSQL: {version}", "Информация о сервере",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static NpgsqlConnection GetConnection()
        {
            var connection = new NpgsqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch
            {
                connection.Dispose();
                throw;
            }
        }
    }
}