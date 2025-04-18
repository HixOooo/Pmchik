namespace pm
{
    partial class ApplicantMenuForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnApplications = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewApplication = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Gray;
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(513, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(3, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(148, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Абитуриент: ...";
            // 
            // btnApplications
            // 
            this.btnApplications.Animated = true;
            this.btnApplications.BorderRadius = 10;
            this.btnApplications.FillColor = System.Drawing.Color.Gray;
            this.btnApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnApplications.ForeColor = System.Drawing.Color.Black;
            this.btnApplications.Location = new System.Drawing.Point(147, 142);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(241, 50);
            this.btnApplications.TabIndex = 1;
            this.btnApplications.Text = "Мои заявления";
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // btnNewApplication
            // 
            this.btnNewApplication.Animated = true;
            this.btnNewApplication.BorderRadius = 10;
            this.btnNewApplication.FillColor = System.Drawing.Color.Gray;
            this.btnNewApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewApplication.ForeColor = System.Drawing.Color.Black;
            this.btnNewApplication.Location = new System.Drawing.Point(260, 86);
            this.btnNewApplication.Name = "btnNewApplication";
            this.btnNewApplication.Size = new System.Drawing.Size(241, 50);
            this.btnNewApplication.TabIndex = 2;
            this.btnNewApplication.Text = "Подать новое заявление";
            this.btnNewApplication.Click += new System.EventHandler(this.btnNewApplication_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Animated = true;
            this.btnProfile.BorderRadius = 10;
            this.btnProfile.FillColor = System.Drawing.Color.Gray;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.Location = new System.Drawing.Point(0, 198);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(241, 50);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Мой профиль";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.FillColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(395, 198);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Выйти из системы";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ApplicantMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 274);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnNewApplication);
            this.Controls.Add(this.btnApplications);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ApplicantMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApplicantMenuForm_FormClosed);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2Button btnApplications;
        private Guna.UI2.WinForms.Guna2Button btnNewApplication;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}
