namespace MechanicalFaRm.App.Authh
{
    partial class V_login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            btnBatalLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 36);
            label1.Name = "label1";
            label1.Size = new Size(207, 50);
            label1.TabIndex = 0;
            label1.Text = "Page login";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 158);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 244);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 2;
            label3.Text = "Passsword";
            label3.Click += label3_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(267, 157);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "masukkan username";
            tbUsername.Size = new Size(303, 27);
            tbUsername.TabIndex = 3;
            tbUsername.TextChanged += textBox1_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(267, 245);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "masukkan passpwrd";
            tbPassword.Size = new Size(303, 27);
            tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 255);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(429, 374);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(103, 43);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBatalLogin
            // 
            btnBatalLogin.BackColor = Color.FromArgb(128, 255, 255);
            btnBatalLogin.FlatStyle = FlatStyle.Popup;
            btnBatalLogin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatalLogin.Location = new Point(600, 374);
            btnBatalLogin.Name = "btnBatalLogin";
            btnBatalLogin.Size = new Size(103, 43);
            btnBatalLogin.TabIndex = 6;
            btnBatalLogin.Text = "No";
            btnBatalLogin.UseVisualStyleBackColor = false;
            // 
            // V_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBatalLogin);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "V_login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button btnBatalLogin;
    }
}