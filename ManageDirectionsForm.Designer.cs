namespace pm
{
    partial class ManageDirectionsForm
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
            this.dgvDirections = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEducationLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).BeginInit();
            this.SuspendLayout();
            //
            // dgvDirections
            //
            this.dgvDirections.AllowUserToAddRows = false;
            this.dgvDirections.AllowUserToDeleteRows = false;
            this.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirections.Location = new System.Drawing.Point(20, 180);
            this.dgvDirections.Name = "dgvDirections";
            this.dgvDirections.ReadOnly = true;
            this.dgvDirections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirections.Size = new System.Drawing.Size(740, 300);
            this.dgvDirections.TabIndex = 0;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Управление направлениями";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(20, 70);
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
            this.cmbEducationLevel.Location = new System.Drawing.Point(20, 90);
            this.cmbEducationLevel.Name = "cmbEducationLevel";
            this.cmbEducationLevel.Size = new System.Drawing.Size(250, 36);
            this.cmbEducationLevel.TabIndex = 3;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(290, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Код";
            //
            // txtCode
            //
            this.txtCode.BorderRadius = 8;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtCode.Location = new System.Drawing.Point(290, 90);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.PlaceholderText = "Например: 09.02.01";
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(150, 36);
            this.txtCode.TabIndex = 5;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(460, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Название";
            //
            // txtName
            //
            this.txtName.BorderRadius = 8;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(460, 90);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Например: Компьютерные системы";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(300, 36);
            this.txtName.TabIndex = 7;
            //
            // btnAdd
            //
            this.btnAdd.Animated = true;
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.FillColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(360, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить направление";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDelete
            //
            this.btnDelete.Animated = true;
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.FillColor = System.Drawing.Color.Black;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(400, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(360, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить выбранное";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnBack
            //
            this.btnBack.Animated = true;
            this.btnBack.BorderRadius = 8;
            this.btnBack.FillColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(20, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 36);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //
            // ManageDirectionsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 539);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEducationLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDirections);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageDirectionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление направлениями подготовки";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvDirections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEducationLevel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}
