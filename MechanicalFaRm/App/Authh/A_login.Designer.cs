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
            btnCancel = new Button();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1527, 978);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(tbPassword);
            panel2.Controls.Add(tbUsername);
            panel2.Controls.Add(btnLogin);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 978);
            panel2.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(215, 575);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 34);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(176, 821);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(230, 27);
            tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(176, 660);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(230, 27);
            tbUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(176, 925);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(230, 50);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
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
            panel2.PerformLayout();
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
    }
}