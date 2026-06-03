namespace MechanicalFaRm.App.Authh
{
    partial class A_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_login));
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            btnRegist = new Button();
            btnLogin = new Button();
            panel4 = new Panel();
            tbPassword = new TextBox();
            panel3 = new Panel();
            tbUsername = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-52, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2052, 1087);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 1087);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRegist);
            panel5.Controls.Add(btnLogin);
            panel5.Location = new Point(252, 847);
            panel5.Name = "panel5";
            panel5.Size = new Size(411, 73);
            panel5.TabIndex = 2;
            // 
            // btnRegist
            // 
            btnRegist.BackColor = Color.Moccasin;
            btnRegist.BackgroundImage = (Image)resources.GetObject("btnRegist.BackgroundImage");
            btnRegist.BackgroundImageLayout = ImageLayout.Center;
            btnRegist.Location = new Point(221, 3);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(170, 67);
            btnRegist.TabIndex = 1;
            btnRegist.UseVisualStyleBackColor = false;
            btnRegist.Click += btnRegist_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Moccasin;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.Location = new Point(3, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(174, 67);
            btnLogin.TabIndex = 0;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Moccasin;
            panel4.Controls.Add(tbPassword);
            panel4.Location = new Point(262, 704);
            panel4.Name = "panel4";
            panel4.Size = new Size(391, 57);
            panel4.TabIndex = 10;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.Moccasin;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.ForeColor = Color.WhiteSmoke;
            tbPassword.Location = new Point(3, 18);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(385, 36);
            tbPassword.TabIndex = 1;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Moccasin;
            panel3.Controls.Add(tbUsername);
            panel3.Location = new Point(262, 580);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 57);
            panel3.TabIndex = 10;
            panel3.Paint += panel3_Paint;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.Moccasin;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Location = new Point(13, 21);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(346, 33);
            tbUsername.TabIndex = 0;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // A_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1855, 1083);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "A_login";
            Text = "Form Login";
            Load += A_login_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Button btnRegist;
        private Button btnLogin;
        private Panel panel4;
        private Panel panel3;
        private TextBox tbUsername;
        private TextBox tbPassword;
    }
}