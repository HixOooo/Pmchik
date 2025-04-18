using System;
using System.Configuration;
using System.Windows.Forms;
using Npgsql;

namespace pm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            txtConnectionStatus.Clear();
            txtConnectionStatus.AppendText("Пытаюсь подключиться к базе данных...\r\n");

            string connectionString = ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString;

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    txtConnectionStatus.AppendText("Подключение успешно установлено!\r\n\r\n");

                    // Получаем информацию о сервере
                    txtConnectionStatus.AppendText("Информация о сервере:\r\n");

                    // Версия PostgreSQL
                    using (var cmd = new NpgsqlCommand("SELECT version();", connection))
                    {
                        txtConnectionStatus.AppendText($"Версия PostgreSQL: {cmd.ExecuteScalar()}\r\n");
                    }

                    // Имя базы данных
                    using (var cmd = new NpgsqlCommand("SELECT current_database();", connection))
                    {
                        txtConnectionStatus.AppendText($"База данных: {cmd.ExecuteScalar()}\r\n");
                    }

                    // Имя пользователя
                    using (var cmd = new NpgsqlCommand("SELECT current_user;", connection))
                    {
                        txtConnectionStatus.AppendText($"Пользователь: {cmd.ExecuteScalar()}\r\n");
                    }

                    // Проверяем наличие таблиц
                    txtConnectionStatus.AppendText("\r\nПроверка таблиц:\r\n");
                    using (var cmd = new NpgsqlCommand(
                        "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public';",
                        connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txtConnectionStatus.AppendText($"- {reader.GetString(0)}\r\n");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtConnectionStatus.AppendText($"\r\nОШИБКА ПОДКЛЮЧЕНИЯ:\r\n{ex.Message}\r\n");

                if (ex.InnerException != null)
                {
                    txtConnectionStatus.AppendText($"\r\nВнутренняя ошибка:\r\n{ex.InnerException.Message}\r\n");
                }
            }
        }
    }
}