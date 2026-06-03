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
            panel7 = new Panel();
            btnLogin = new Button();
            btnRegist = new Button();
            panel5 = new Panel();
            tbEmailR = new TextBox();
            panel6 = new Panel();
            tbUsernameR = new TextBox();
            panel3 = new Panel();
            tbPasswordR = new TextBox();
            panel4 = new Panel();
            tbNoTelpR = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-24, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1935, 1092);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 1092);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnLogin);
            panel7.Controls.Add(btnRegist);
            panel7.Location = new Point(210, 977);
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
            // panel5
            // 
            panel5.BackColor = Color.Moccasin;
            panel5.Controls.Add(tbEmailR);
            panel5.Location = new Point(229, 857);
            panel5.Name = "panel5";
            panel5.Size = new Size(383, 59);
            panel5.TabIndex = 10;
            // 
            // tbEmailR
            // 
            tbEmailR.BackColor = Color.Moccasin;
            tbEmailR.BorderStyle = BorderStyle.None;
            tbEmailR.Location = new Point(22, 22);
            tbEmailR.Name = "tbEmailR";
            tbEmailR.Size = new Size(332, 20);
            tbEmailR.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Moccasin;
            panel6.Controls.Add(tbUsernameR);
            panel6.Location = new Point(229, 528);
            panel6.Name = "panel6";
            panel6.Size = new Size(383, 59);
            panel6.TabIndex = 10;
            // 
            // tbUsernameR
            // 
            tbUsernameR.BackColor = Color.Moccasin;
            tbUsernameR.BorderStyle = BorderStyle.None;
            tbUsernameR.Location = new Point(22, 17);
            tbUsernameR.Name = "tbUsernameR";
            tbUsernameR.Size = new Size(332, 20);
            tbUsernameR.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Moccasin;
            panel3.Controls.Add(tbPasswordR);
            panel3.Location = new Point(229, 641);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 59);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // tbPasswordR
            // 
            tbPasswordR.BackColor = Color.Moccasin;
            tbPasswordR.BorderStyle = BorderStyle.None;
            tbPasswordR.Location = new Point(22, 19);
            tbPasswordR.Name = "tbPasswordR";
            tbPasswordR.Size = new Size(332, 20);
            tbPasswordR.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Moccasin;
            panel4.Controls.Add(tbNoTelpR);
            panel4.Location = new Point(229, 752);
            panel4.Name = "panel4";
            panel4.Size = new Size(389, 59);
            panel4.TabIndex = 9;
            // 
            // tbNoTelpR
            // 
            tbNoTelpR.BackColor = Color.Moccasin;
            tbNoTelpR.BorderStyle = BorderStyle.None;
            tbNoTelpR.Location = new Point(22, 17);
            tbNoTelpR.Name = "tbNoTelpR";
            tbNoTelpR.Size = new Size(332, 20);
            tbNoTelpR.TabIndex = 1;
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
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnRegist;
        private Button btnLogin;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Panel panel3;
        private TextBox tbUsernameR;
        private TextBox tbPasswordR;
        private TextBox tbEmailR;
        private TextBox tbNoTelpR;
        private Panel panel7;
    }
}