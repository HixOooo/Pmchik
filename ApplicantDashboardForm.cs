using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace pm
{
    public partial class ApplicantDashboardForm : Form
    {
        private int _userId;

        public ApplicantDashboardForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadApplications();
        }

        private void LoadApplications()
        {
            try
            {
                using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString))
                {
                    connection.Open();

                    int applicantId;
                    string getApplicantQuery = "SELECT id_абитуриента FROM абитуриент WHERE id_пользователя = @userId";

                    using (var cmd = new NpgsqlCommand(getApplicantQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", _userId);
                        applicantId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Обновленный запрос с ФИО
                    string query = @"
                SELECT 
                    з.id_заявления,
                    а.фио,                       -- Добавляем ФИО
                    у.название_уровня,
                    з.дата_подачи,
                    з.статус,
                    STRING_AGG(н.код_направления || ' ' || н.название_направления, ', ' ORDER BY зн.приоритет) AS направления
                FROM заявление з
                JOIN абитуриент а ON з.id_абитуриента = а.id_абитуриента
                JOIN уровень_образования у ON з.id_уровня = у.id_уровня
                JOIN заявление_направление зн ON з.id_заявления = зн.id_заявления
                JOIN направление_подготовки н ON зн.id_направления = н.id_направления
                WHERE з.id_абитуриента = @applicantId
                GROUP BY з.id_заявления, а.фио, у.название_уровня, з.дата_подачи, з.статус
                ORDER BY з.дата_подачи DESC";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@applicantId", applicantId);
                        var adapter = new NpgsqlDataAdapter(cmd);
                        var table = new DataTable();
                        adapter.Fill(table);

                        dgvApplications.DataSource = table;

                        // Настраиваем колонки
                        dgvApplications.Columns["id_заявления"].Visible = false;
                        dgvApplications.Columns["фио"].HeaderText = "ФИО абитуриента";  // Добавляем колонку
                        dgvApplications.Columns["название_уровня"].HeaderText = "Уровень";
                        dgvApplications.Columns["дата_подачи"].HeaderText = "Дата подачи";
                        dgvApplications.Columns["статус"].HeaderText = "Статус";
                        dgvApplications.Columns["направления"].HeaderText = "Направления";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заявлений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvApplications.CurrentRow == null)
            {
                MessageBox.Show("Выберите заявление для печати", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Получаем данные из таблицы (включая ФИО)
                string fullName = dgvApplications.CurrentRow.Cells["фио"].Value?.ToString() ?? "Не указано";
                string directions = dgvApplications.CurrentRow.Cells["направления"].Value?.ToString() ?? "Не указано";
                string date = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveDialog.FileName = $"Заявление_{DateTime.Now:yyyyMMddHHmmss}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        Document document = new Document();
                        PdfWriter.GetInstance(document, new FileStream(saveDialog.FileName, FileMode.Create));
                        document.Open();

                        // Шрифт с поддержкой кириллицы
                        BaseFont baseFont = BaseFont.CreateFont(
                            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf"),
                            BaseFont.IDENTITY_H,
                            BaseFont.NOT_EMBEDDED
                        );

                        Font titleFont = new Font(baseFont, 16, iTextSharp.text.Font.BOLD);
                        Font regularFont = new Font(baseFont, 12, iTextSharp.text.Font.NORMAL);

                        // Заголовок
                        Paragraph title = new Paragraph("ЗАЯВЛЕНИЕ", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        title.SpacingAfter = 20f;
                        document.Add(title);

                        // Основной текст с ФИО
                        document.Add(new Paragraph($"Я, {fullName}, подал(а) документы в ВГТУ", regularFont));
                        document.Add(new Paragraph("На направления подготовки:", regularFont));

                        // Список направлений
                        string[] dirs = directions.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            document.Add(new Paragraph($"{i + 1}. {dirs[i]}", regularFont));
                        }

                        // Дата
                        document.Add(new Paragraph($"\nДата формирования: {date}", regularFont));

                        document.Close();
                        MessageBox.Show("PDF успешно сохранен!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            var applicationForm = new ApplicationForm(_userId);
            if (applicationForm.ShowDialog() == DialogResult.OK)
            {
                LoadApplications();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadApplications();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ApplicantMenuForm(_userId).Show();
        }

        private void ApplicantDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}