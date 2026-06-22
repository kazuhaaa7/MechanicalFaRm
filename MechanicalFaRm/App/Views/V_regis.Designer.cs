namespace MechanicalFaRm.App.Authh
{
    partial class V_regis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_regis));
            btnRegist = new Button();
            btnLogin = new Button();
            tbUsernameR = new TextBox();
            tbNoTelpR = new TextBox();
            tbEmailR = new TextBox();
            tbPasswordR = new TextBox();
            panel3 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegist
            // 
            btnRegist.BackColor = Color.Transparent;
            btnRegist.BackgroundImage = (Image)resources.GetObject("btnRegist.BackgroundImage");
            btnRegist.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegist.FlatAppearance.BorderSize = 0;
            btnRegist.FlatStyle = FlatStyle.Flat;
            btnRegist.Location = new Point(1471, 771);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(218, 66);
            btnRegist.TabIndex = 6;
            btnRegist.UseVisualStyleBackColor = false;
            btnRegist.Click += btnRegist_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(1247, 773);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(208, 64);
            btnLogin.TabIndex = 5;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbUsernameR
            // 
            tbUsernameR.BackColor = Color.White;
            tbUsernameR.BorderStyle = BorderStyle.None;
            tbUsernameR.Location = new Point(1319, 342);
            tbUsernameR.Multiline = true;
            tbUsernameR.Name = "tbUsernameR";
            tbUsernameR.Size = new Size(332, 36);
            tbUsernameR.TabIndex = 17;
            tbUsernameR.TextChanged += tbUsernameR_TextChanged;
            // 
            // tbNoTelpR
            // 
            tbNoTelpR.BackColor = Color.White;
            tbNoTelpR.BorderStyle = BorderStyle.None;
            tbNoTelpR.Location = new Point(1319, 658);
            tbNoTelpR.Multiline = true;
            tbNoTelpR.Name = "tbNoTelpR";
            tbNoTelpR.Size = new Size(332, 47);
            tbNoTelpR.TabIndex = 18;
            tbNoTelpR.TextChanged += tbNoTelpR_TextChanged;
            // 
            // tbEmailR
            // 
            tbEmailR.BackColor = Color.White;
            tbEmailR.BorderStyle = BorderStyle.None;
            tbEmailR.Location = new Point(1306, 559);
            tbEmailR.Multiline = true;
            tbEmailR.Name = "tbEmailR";
            tbEmailR.Size = new Size(332, 39);
            tbEmailR.TabIndex = 20;
            tbEmailR.TextChanged += tbEmailR_TextChanged;
            // 
            // tbPasswordR
            // 
            tbPasswordR.BackColor = Color.White;
            tbPasswordR.BorderStyle = BorderStyle.None;
            tbPasswordR.Location = new Point(1319, 441);
            tbPasswordR.Multiline = true;
            tbPasswordR.Name = "tbPasswordR";
            tbPasswordR.PasswordChar = '*';
            tbPasswordR.Size = new Size(332, 45);
            tbPasswordR.TabIndex = 19;
            tbPasswordR.TextChanged += tbPasswordR_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(tbUsernameR);
            panel3.Controls.Add(btnRegist);
            panel3.Controls.Add(tbPasswordR);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(tbNoTelpR);
            panel3.Controls.Add(tbEmailR);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1919, 1095);
            panel3.TabIndex = 21;
            // 
            // V_regis
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1919, 1095);
            Controls.Add(panel3);
            DoubleBuffered = true;
            Name = "V_regis";
            Text = "V_regis";
            Load += A_regis_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbEmailR;
        private TextBox tbNoTelpR;
        private TextBox tbPasswordR;
        private TextBox tbUsernameR;
        private Panel panel7;
        private Button btnLogin;
        private Button btnRegist;
        private Panel panel2;
        private Panel panel3;
    }
}