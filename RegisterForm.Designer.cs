namespace pm
{
    partial class RegisterForm
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
            this.txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassport = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSnils = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtParentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSchool = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();

            // txtLogin
            this.txtLogin.BorderRadius = 10;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.DefaultText = "";
            this.txtLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtLogin.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLogin.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtLogin.Location = new System.Drawing.Point(30, 40);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.PlaceholderText = "";
            this.txtLogin.SelectedText = "";
            this.txtLogin.Size = new System.Drawing.Size(300, 36);
            this.txtLogin.TabIndex = 0;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";

            // txtPassword
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(30, 110);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(300, 36);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Подтверждение";

            // txtConfirmPassword
            this.txtConfirmPassword.BorderRadius = 10;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 180);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 36);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.UseSystemPasswordChar = true;

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(30, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "ФИО";

            // txtFullName
            this.txtFullName.BorderRadius = 10;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtFullName.Location = new System.Drawing.Point(30, 250);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(300, 36);
            this.txtFullName.TabIndex = 6;

            // label5
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(30, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Паспортные данные";

            // txtPassport
            this.txtPassport.BorderRadius = 10;
            this.txtPassport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassport.DefaultText = "";
            this.txtPassport.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtPassport.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtPassport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPassport.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPassport.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtPassport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassport.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtPassport.Location = new System.Drawing.Point(30, 320);
            this.txtPassport.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.PasswordChar = '\0';
            this.txtPassport.PlaceholderText = "";
            this.txtPassport.SelectedText = "";
            this.txtPassport.Size = new System.Drawing.Size(300, 36);
            this.txtPassport.TabIndex = 8;

            // label6
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(30, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "СНИЛС";

            // txtSnils
            this.txtSnils.BorderRadius = 10;
            this.txtSnils.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSnils.DefaultText = "";
            this.txtSnils.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtSnils.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtSnils.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtSnils.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtSnils.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtSnils.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSnils.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtSnils.Location = new System.Drawing.Point(30, 390);
            this.txtSnils.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnils.Name = "txtSnils";
            this.txtSnils.PasswordChar = '\0';
            this.txtSnils.PlaceholderText = "XXX-XXX-XXX XX";
            this.txtSnils.SelectedText = "";
            this.txtSnils.Size = new System.Drawing.Size(300, 36);
            this.txtSnils.TabIndex = 10;

            // label7
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(360, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";

            // txtEmail
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(360, 40);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "example@mail.com";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(300, 36);
            this.txtEmail.TabIndex = 12;

            // label8
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(360, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Телефон";

            // txtPhone
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtPhone.Location = new System.Drawing.Point(360, 110);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "+7 (XXX) XXX-XX-XX";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(300, 36);
            this.txtPhone.TabIndex = 14;

            // label9
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(360, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "ФИО родителя/представителя";

            // txtParentName
            this.txtParentName.BorderRadius = 10;
            this.txtParentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParentName.DefaultText = "";
            this.txtParentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtParentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtParentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtParentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtParentName.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtParentName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtParentName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtParentName.Location = new System.Drawing.Point(360, 180);
            this.txtParentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.PasswordChar = '\0';
            this.txtParentName.PlaceholderText = "";
            this.txtParentName.SelectedText = "";
            this.txtParentName.Size = new System.Drawing.Size(300, 36);
            this.txtParentName.TabIndex = 16;

            // label10
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(360, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Учебное заведение (окончил)";

            // txtSchool
            this.txtSchool.BorderRadius = 10;
            this.txtSchool.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSchool.DefaultText = "";
            this.txtSchool.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            this.txtSchool.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.txtSchool.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtSchool.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.txtSchool.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.txtSchool.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSchool.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtSchool.Location = new System.Drawing.Point(360, 250);
            this.txtSchool.Margin = new System.Windows.Forms.Padding(4);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.PasswordChar = '\0';
            this.txtSchool.PlaceholderText = "";
            this.txtSchool.SelectedText = "";
            this.txtSchool.Size = new System.Drawing.Size(300, 36);
            this.txtSchool.TabIndex = 18;

            // btnRegister
            this.btnRegister.Animated = true;
            this.btnRegister.BorderRadius = 10;
            this.btnRegister.FillColor = System.Drawing.Color.Black;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(360, 320);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(300, 45);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // btnBack
            this.btnBack.Animated = true;
            this.btnBack.BorderRadius = 10;
            this.btnBack.FillColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(360, 380);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(300, 45);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // RegisterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSnils);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация абитуриента";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPassport;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtSnils;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtParentName;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtSchool;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}
