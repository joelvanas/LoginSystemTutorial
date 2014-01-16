namespace LoginSystemPC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Logintab = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginUserName = new System.Windows.Forms.TextBox();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.TabPage();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.RegisterEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Label();
            this.RegisterUsername = new System.Windows.Forms.TextBox();
            this.RegisterPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.TabPage();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.SmtpPortNumericUD = new System.Windows.Forms.NumericUpDown();
            this.SmtpUsernameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SmtpAddressTextbox = new System.Windows.Forms.TextBox();
            this.SmtpPasswordTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Logintab.SuspendLayout();
            this.Login.SuspendLayout();
            this.Register.SuspendLayout();
            this.Configuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmtpPortNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Logintab
            // 
            this.Logintab.Controls.Add(this.Login);
            this.Logintab.Controls.Add(this.Register);
            this.Logintab.Controls.Add(this.Database);
            this.Logintab.Controls.Add(this.Configuration);
            this.Logintab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logintab.Location = new System.Drawing.Point(0, 0);
            this.Logintab.Name = "Logintab";
            this.Logintab.SelectedIndex = 0;
            this.Logintab.Size = new System.Drawing.Size(284, 262);
            this.Logintab.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.LoginButton);
            this.Login.Controls.Add(this.LoginUserName);
            this.Login.Controls.Add(this.LoginPassword);
            this.Login.Controls.Add(this.label2);
            this.Login.Controls.Add(this.label1);
            this.Login.Location = new System.Drawing.Point(4, 22);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(276, 236);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(101, 144);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // LoginUserName
            // 
            this.LoginUserName.Location = new System.Drawing.Point(115, 67);
            this.LoginUserName.Name = "LoginUserName";
            this.LoginUserName.Size = new System.Drawing.Size(100, 20);
            this.LoginUserName.TabIndex = 3;
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(115, 93);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '*';
            this.LoginPassword.Size = new System.Drawing.Size(100, 20);
            this.LoginPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Register
            // 
            this.Register.Controls.Add(this.RegisterButton);
            this.Register.Controls.Add(this.RegisterConfirmPassword);
            this.Register.Controls.Add(this.RegisterEmail);
            this.Register.Controls.Add(this.label5);
            this.Register.Controls.Add(this.Confirm);
            this.Register.Controls.Add(this.RegisterUsername);
            this.Register.Controls.Add(this.RegisterPassword);
            this.Register.Controls.Add(this.label3);
            this.Register.Controls.Add(this.Username);
            this.Register.Location = new System.Drawing.Point(4, 22);
            this.Register.Name = "Register";
            this.Register.Padding = new System.Windows.Forms.Padding(3);
            this.Register.Size = new System.Drawing.Size(276, 236);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(101, 160);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // RegisterConfirmPassword
            // 
            this.RegisterConfirmPassword.Location = new System.Drawing.Point(115, 90);
            this.RegisterConfirmPassword.Name = "RegisterConfirmPassword";
            this.RegisterConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.RegisterConfirmPassword.TabIndex = 11;
            // 
            // RegisterEmail
            // 
            this.RegisterEmail.Location = new System.Drawing.Point(115, 116);
            this.RegisterEmail.Name = "RegisterEmail";
            this.RegisterEmail.PasswordChar = '*';
            this.RegisterEmail.Size = new System.Drawing.Size(100, 20);
            this.RegisterEmail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // Confirm
            // 
            this.Confirm.AutoSize = true;
            this.Confirm.Location = new System.Drawing.Point(50, 93);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(42, 13);
            this.Confirm.TabIndex = 8;
            this.Confirm.Text = "Confirm";
            // 
            // RegisterUsername
            // 
            this.RegisterUsername.Location = new System.Drawing.Point(115, 38);
            this.RegisterUsername.Name = "RegisterUsername";
            this.RegisterUsername.Size = new System.Drawing.Size(100, 20);
            this.RegisterUsername.TabIndex = 7;
            // 
            // RegisterPassword
            // 
            this.RegisterPassword.Location = new System.Drawing.Point(115, 64);
            this.RegisterPassword.Name = "RegisterPassword";
            this.RegisterPassword.PasswordChar = '*';
            this.RegisterPassword.Size = new System.Drawing.Size(100, 20);
            this.RegisterPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(50, 41);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username";
            // 
            // Database
            // 
            this.Database.Location = new System.Drawing.Point(4, 22);
            this.Database.Name = "Database";
            this.Database.Padding = new System.Windows.Forms.Padding(3);
            this.Database.Size = new System.Drawing.Size(276, 236);
            this.Database.TabIndex = 2;
            this.Database.Text = "tabPage1";
            this.Database.UseVisualStyleBackColor = true;
            // 
            // Configuration
            // 
            this.Configuration.Controls.Add(this.SmtpPortNumericUD);
            this.Configuration.Controls.Add(this.SmtpUsernameTextbox);
            this.Configuration.Controls.Add(this.label4);
            this.Configuration.Controls.Add(this.label6);
            this.Configuration.Controls.Add(this.SmtpAddressTextbox);
            this.Configuration.Controls.Add(this.SmtpPasswordTextbox);
            this.Configuration.Controls.Add(this.label7);
            this.Configuration.Controls.Add(this.label8);
            this.Configuration.Location = new System.Drawing.Point(4, 22);
            this.Configuration.Name = "Configuration";
            this.Configuration.Padding = new System.Windows.Forms.Padding(3);
            this.Configuration.Size = new System.Drawing.Size(276, 236);
            this.Configuration.TabIndex = 3;
            this.Configuration.Text = "Configuration";
            this.Configuration.UseVisualStyleBackColor = true;
            // 
            // SmtpPortNumericUD
            // 
            this.SmtpPortNumericUD.Location = new System.Drawing.Point(125, 84);
            this.SmtpPortNumericUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SmtpPortNumericUD.Name = "SmtpPortNumericUD";
            this.SmtpPortNumericUD.Size = new System.Drawing.Size(120, 20);
            this.SmtpPortNumericUD.TabIndex = 20;
            this.SmtpPortNumericUD.ValueChanged += new System.EventHandler(this.SmtpPortNumericUD_ValueChanged);
            // 
            // SmtpUsernameTextbox
            // 
            this.SmtpUsernameTextbox.Location = new System.Drawing.Point(125, 109);
            this.SmtpUsernameTextbox.Name = "SmtpUsernameTextbox";
            this.SmtpUsernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.SmtpUsernameTextbox.TabIndex = 19;
            this.SmtpUsernameTextbox.TextChanged += new System.EventHandler(this.SmtpUsernameTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email Username";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SmtpAddressTextbox
            // 
            this.SmtpAddressTextbox.Location = new System.Drawing.Point(125, 57);
            this.SmtpAddressTextbox.Name = "SmtpAddressTextbox";
            this.SmtpAddressTextbox.Size = new System.Drawing.Size(100, 20);
            this.SmtpAddressTextbox.TabIndex = 15;
            this.SmtpAddressTextbox.TextChanged += new System.EventHandler(this.SmtpAddressTextbox_TextChanged);
            // 
            // SmtpPasswordTextbox
            // 
            this.SmtpPasswordTextbox.Location = new System.Drawing.Point(125, 135);
            this.SmtpPasswordTextbox.Name = "SmtpPasswordTextbox";
            this.SmtpPasswordTextbox.PasswordChar = '*';
            this.SmtpPasswordTextbox.Size = new System.Drawing.Size(100, 20);
            this.SmtpPasswordTextbox.TabIndex = 14;
            this.SmtpPasswordTextbox.TextChanged += new System.EventHandler(this.SmtpPasswordTextbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Port:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "SMTP Address:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Logintab);
            this.Name = "Form1";
            this.Text = "s";
            this.Logintab.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            this.Configuration.ResumeLayout(false);
            this.Configuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmtpPortNumericUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Logintab;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage Register;
        private System.Windows.Forms.TabPage Database;
        private System.Windows.Forms.TabPage Configuration;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox LoginUserName;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox RegisterConfirmPassword;
        private System.Windows.Forms.TextBox RegisterEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Confirm;
        private System.Windows.Forms.TextBox RegisterUsername;
        private System.Windows.Forms.TextBox RegisterPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.NumericUpDown SmtpPortNumericUD;
        private System.Windows.Forms.TextBox SmtpUsernameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SmtpAddressTextbox;
        private System.Windows.Forms.TextBox SmtpPasswordTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

