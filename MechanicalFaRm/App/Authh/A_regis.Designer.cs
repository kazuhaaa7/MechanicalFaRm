namespace MechanicalFaRm.App.Authh
{
    partial class A_regis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_regis));
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            btnRegist = new Button();
            panel3 = new Panel();
            btnLogin = new Button();
            tbEmail = new TextBox();
            tbNoTelp = new TextBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(9, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(2002, 1107);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnRegist);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(tbEmail);
            panel2.Controls.Add(tbNoTelp);
            panel2.Controls.Add(tbPassword);
            panel2.Controls.Add(tbUsername);
            panel2.Location = new Point(199, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 654);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Moccasin;
            panel5.Location = new Point(23, 454);
            panel5.Name = "panel5";
            panel5.Size = new Size(383, 59);
            panel5.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Moccasin;
            panel6.Location = new Point(23, 128);
            panel6.Name = "panel6";
            panel6.Size = new Size(383, 59);
            panel6.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Moccasin;
            panel4.Location = new Point(23, 339);
            panel4.Name = "panel4";
            panel4.Size = new Size(383, 59);
            panel4.TabIndex = 9;
            // 
            // btnRegist
            // 
            btnRegist.BackgroundImage = (Image)resources.GetObject("btnRegist.BackgroundImage");
            btnRegist.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegist.Location = new Point(232, 594);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(174, 57);
            btnRegist.TabIndex = 6;
            btnRegist.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Moccasin;
            panel3.Location = new Point(23, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 59);
            panel3.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Location = new Point(23, 594);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(174, 57);
            btnLogin.TabIndex = 5;
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(39, 471);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(336, 27);
            tbEmail.TabIndex = 4;
            // 
            // tbNoTelp
            // 
            tbNoTelp.Location = new Point(39, 353);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(336, 27);
            tbNoTelp.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(39, 249);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(336, 27);
            tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(39, 142);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(336, 27);
            tbUsername.TabIndex = 1;
            // 
            // A_regis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1924, 1071);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "A_regis";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnRegist;
        private Button btnLogin;
        private TextBox tbEmail;
        private TextBox tbNoTelp;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Panel panel3;
    }
}