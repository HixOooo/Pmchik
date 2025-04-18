namespace pm
{
    partial class Form1
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
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtConnectionStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(12, 12);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(200, 40);
            this.btnTestConnection.TabIndex = 0;
            this.btnTestConnection.Text = "Проверить подключение";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.Location = new System.Drawing.Point(12, 80);
            this.txtConnectionStatus.Multiline = true;
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.ReadOnly = true;
            this.txtConnectionStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConnectionStatus.Size = new System.Drawing.Size(400, 150);
            this.txtConnectionStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 60);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Статус подключения:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 242);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtConnectionStatus);
            this.Controls.Add(this.btnTestConnection);
            this.Name = "Form1";
            this.Text = "Проверка подключения к БД";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.TextBox txtConnectionStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}