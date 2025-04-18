namespace pm
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEducationLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNewStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnChangeStatus = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageDirections = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteApplication = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewDocument = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Location = new System.Drawing.Point(20, 85);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(960, 305);
            this.dgvApplications.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Управление заявлениями";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(16, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Уровень образования";
            // 
            // cmbEducationLevel
            // 
            this.cmbEducationLevel.BackColor = System.Drawing.Color.Transparent;
            this.cmbEducationLevel.BorderRadius = 8;
            this.cmbEducationLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEducationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationLevel.FocusedColor = System.Drawing.Color.Gray;
            this.cmbEducationLevel.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.cmbEducationLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEducationLevel.ForeColor = System.Drawing.Color.Black;
            this.cmbEducationLevel.ItemHeight = 30;
            this.cmbEducationLevel.Location = new System.Drawing.Point(16, 415);
            this.cmbEducationLevel.Name = "cmbEducationLevel";
            this.cmbEducationLevel.Size = new System.Drawing.Size(200, 36);
            this.cmbEducationLevel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(236, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Статус";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderRadius = 8;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.Gray;
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "ПОДАНО",
            "ГОТОВО",
            "В ДОРАБОТКУ",
            "ОТКЛОНЕНО"});
            this.cmbStatus.Location = new System.Drawing.Point(236, 413);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 36);
            this.cmbStatus.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.Animated = true;
            this.btnFilter.BorderRadius = 8;
            this.btnFilter.FillColor = System.Drawing.Color.Gray;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(580, 415);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(124, 36);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Фильтровать";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(396, 413);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Поиск по ФИО";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(180, 36);
            this.txtSearch.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(16, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Новый статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(20, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выберите заявление из списка";
            // 
            // cmbNewStatus
            // 
            this.cmbNewStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbNewStatus.BorderRadius = 8;
            this.cmbNewStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewStatus.FocusedColor = System.Drawing.Color.Gray;
            this.cmbNewStatus.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.cmbNewStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNewStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbNewStatus.ItemHeight = 30;
            this.cmbNewStatus.Items.AddRange(new object[] {
            "ПОДАНО",
            "ГОТОВО",
            "В ДОРАБОТКУ",
            "ОТКЛОНЕНО"});
            this.cmbNewStatus.Location = new System.Drawing.Point(20, 475);
            this.cmbNewStatus.Name = "cmbNewStatus";
            this.cmbNewStatus.Size = new System.Drawing.Size(150, 36);
            this.cmbNewStatus.TabIndex = 10;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Animated = true;
            this.btnChangeStatus.BorderRadius = 8;
            this.btnChangeStatus.FillColor = System.Drawing.Color.Gray;
            this.btnChangeStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangeStatus.ForeColor = System.Drawing.Color.White;
            this.btnChangeStatus.Location = new System.Drawing.Point(20, 517);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(150, 36);
            this.btnChangeStatus.TabIndex = 11;
            this.btnChangeStatus.Text = "Изменить статус";
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.FillColor = System.Drawing.Color.Gray;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(185, 475);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(243, 36);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Обновить данные";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnManageDirections
            // 
            this.btnManageDirections.Animated = true;
            this.btnManageDirections.BorderRadius = 8;
            this.btnManageDirections.FillColor = System.Drawing.Color.Gray;
            this.btnManageDirections.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageDirections.ForeColor = System.Drawing.Color.White;
            this.btnManageDirections.Location = new System.Drawing.Point(444, 475);
            this.btnManageDirections.Name = "btnManageDirections";
            this.btnManageDirections.Size = new System.Drawing.Size(220, 36);
            this.btnManageDirections.TabIndex = 14;
            this.btnManageDirections.Text = "Управление направлениями";
            this.btnManageDirections.Click += new System.EventHandler(this.btnManageDirections_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.FillColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(800, 438);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 36);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Выйти из системы";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.BorderRadius = 10;
            this.btnBack.FillColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(20, 624);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 36);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteApplication
            // 
            this.btnDeleteApplication.Animated = true;
            this.btnDeleteApplication.BorderRadius = 8;
            this.btnDeleteApplication.FillColor = System.Drawing.Color.Black;
            this.btnDeleteApplication.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteApplication.ForeColor = System.Drawing.Color.White;
            this.btnDeleteApplication.Location = new System.Drawing.Point(800, 396);
            this.btnDeleteApplication.Name = "btnDeleteApplication";
            this.btnDeleteApplication.Size = new System.Drawing.Size(180, 36);
            this.btnDeleteApplication.TabIndex = 17;
            this.btnDeleteApplication.Text = "Удалить заявление";
            this.btnDeleteApplication.Click += new System.EventHandler(this.btnDeleteApplication_Click);
            // 
            // btnViewDocument
            // 
            this.btnViewDocument.Animated = true;
            this.btnViewDocument.BorderRadius = 8;
            this.btnViewDocument.FillColor = System.Drawing.Color.Gray;
            this.btnViewDocument.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewDocument.ForeColor = System.Drawing.Color.White;
            this.btnViewDocument.Location = new System.Drawing.Point(670, 475);
            this.btnViewDocument.Name = "btnViewDocument";
            this.btnViewDocument.Size = new System.Drawing.Size(207, 36);
            this.btnViewDocument.TabIndex = 18;
            this.btnViewDocument.Text = "Просмотреть скан";
            this.btnViewDocument.Click += new System.EventHandler(this.btnViewDocument_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 690);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageDirections);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.cmbNewStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEducationLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteApplication);
            this.Controls.Add(this.btnViewDocument);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEducationLevel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNewStatus;
        private Guna.UI2.WinForms.Guna2Button btnChangeStatus;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnManageDirections;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnDeleteApplication;
        private Guna.UI2.WinForms.Guna2Button btnViewDocument;
    }
}
