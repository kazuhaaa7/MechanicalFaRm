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
            tbEmailR = new TextBox();
            tbNoTelpR = new TextBox();
            tbPasswordR = new TextBox();
            tbUsernameR = new TextBox();
            panel7 = new Panel();
            btnLogin = new Button();
            btnRegist = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-24, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 1092);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(tbEmailR);
            panel2.Controls.Add(tbNoTelpR);
            panel2.Controls.Add(tbPasswordR);
            panel2.Controls.Add(tbUsernameR);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1264, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 1092);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // tbEmailR
            // 
            tbEmailR.BackColor = Color.White;
            tbEmailR.BorderStyle = BorderStyle.None;
            tbEmailR.Location = new Point(62, 563);
            tbEmailR.Multiline = true;
            tbEmailR.Name = "tbEmailR";
            tbEmailR.Size = new Size(332, 39);
            tbEmailR.TabIndex = 2;
            // 
            // tbNoTelpR
            // 
            tbNoTelpR.BackColor = Color.White;
            tbNoTelpR.BorderStyle = BorderStyle.None;
            tbNoTelpR.Location = new Point(50, 667);
            tbNoTelpR.Multiline = true;
            tbNoTelpR.Name = "tbNoTelpR";
            tbNoTelpR.Size = new Size(332, 47);
            tbNoTelpR.TabIndex = 1;
            tbNoTelpR.TextChanged += tbNoTelpR_TextChanged;
            // 
            // tbPasswordR
            // 
            tbPasswordR.BackColor = Color.White;
            tbPasswordR.BorderStyle = BorderStyle.None;
            tbPasswordR.Location = new Point(50, 440);
            tbPasswordR.Multiline = true;
            tbPasswordR.Name = "tbPasswordR";
            tbPasswordR.Size = new Size(332, 45);
            tbPasswordR.TabIndex = 1;
            // 
            // tbUsernameR
            // 
            tbUsernameR.BackColor = Color.White;
            tbUsernameR.BorderStyle = BorderStyle.None;
            tbUsernameR.Location = new Point(50, 344);
            tbUsernameR.Multiline = true;
            tbUsernameR.Name = "tbUsernameR";
            tbUsernameR.Size = new Size(332, 36);
            tbUsernameR.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(btnLogin);
            panel7.Controls.Add(btnRegist);
            panel7.Location = new Point(22, 778);
            panel7.Name = "panel7";
            panel7.Size = new Size(435, 69);
            panel7.TabIndex = 11;
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Location = new Point(13, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(186, 66);
            btnLogin.TabIndex = 5;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegist
            // 
            btnRegist.BackgroundImage = (Image)resources.GetObject("btnRegist.BackgroundImage");
            btnRegist.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegist.Location = new Point(237, 0);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(182, 69);
            btnRegist.TabIndex = 6;
            btnRegist.UseVisualStyleBackColor = true;
            btnRegist.Click += btnRegist_Click;
            // 
            // A_regis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1898, 1084);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "A_regis";
            Text = "Form1";
            Load += A_regis_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnRegist;
        private Button btnLogin;
        private TextBox tbUsernameR;
        private TextBox tbPasswordR;
        private TextBox tbEmailR;
        private TextBox tbNoTelpR;
        private Panel panel7;
    }
}