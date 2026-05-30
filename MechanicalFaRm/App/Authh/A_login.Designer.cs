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
            btnRegist = new Button();
            panel3 = new Panel();
            tbUsername = new TextBox();
            panel4 = new Panel();
            tbPassword = new TextBox();
            btnCancel = new Button();
            btnLogin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1527, 981);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRegist);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnLogin);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 981);
            panel2.TabIndex = 0;
            // 
            // btnRegist
            // 
            btnRegist.BackColor = Color.Silver;
            btnRegist.BackgroundImage = (Image)resources.GetObject("btnRegist.BackgroundImage");
            btnRegist.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegist.CausesValidation = false;
            btnRegist.Location = new Point(440, 855);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(180, 71);
            btnRegist.TabIndex = 8;
            btnRegist.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Moccasin;
            panel3.Controls.Add(tbUsername);
            panel3.Location = new Point(237, 582);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 59);
            panel3.TabIndex = 7;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.Moccasin;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Location = new Point(18, 19);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(350, 20);
            tbUsername.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Moccasin;
            panel4.Controls.Add(tbPassword);
            panel4.Location = new Point(237, 704);
            panel4.Name = "panel4";
            panel4.Size = new Size(383, 59);
            panel4.TabIndex = 6;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.Moccasin;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.ForeColor = SystemColors.ActiveBorder;
            tbPassword.Location = new Point(18, 23);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(350, 20);
            tbPassword.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(237, 787);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 34);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Silver;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.CausesValidation = false;
            btnLogin.Location = new Point(228, 855);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 71);
            btnLogin.TabIndex = 0;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // A_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1519, 973);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "A_login";
            Text = "Form Login";
            Load += A_login_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Button btnLogin;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Button btnCancel;
        private Panel panel3;
        private Panel panel4;
        private Button btnRegist;
    }
}