namespace pm
{
    partial class ApplicantDashboardForm
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
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.SuspendLayout();
            //
            // dgvApplications
            //
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Location = new System.Drawing.Point(20, 60);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(523, 300);
            this.dgvApplications.TabIndex = 0;
            //
            // btnRefresh
            //
            this.btnRefresh.Animated = true;
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.FillColor = System.Drawing.Color.Gray;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(407, 446);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 42);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить данные";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(152, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Мои заявления в ВГТУ";
            //
            // btnBack
            //
            this.btnBack.Animated = true;
            this.btnBack.BorderRadius = 10;
            this.btnBack.FillColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(12, 443);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 45);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //
            // btnPrint
            //
            this.btnPrint.Animated = true;
            this.btnPrint.BorderRadius = 10;
            this.btnPrint.FillColor = System.Drawing.Color.Black;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(187, 443);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 45);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Печать заявления";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            //
            // ApplicantDashboardForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 500);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvApplications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ApplicantDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои заявления";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApplicantDashboardForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvApplications;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
    }
}
