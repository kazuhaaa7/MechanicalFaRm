
namespace MechanicalFaRm.App.Views
{
    partial class V_profleAdmin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_profleAdmin));
            panel1 = new Panel();
            panel2 = new Panel();
            panel9 = new Panel();
            btnLogout = new Button();
            btnRiwayat = new Button();
            btnDashboard = new Button();
            panel8 = new Panel();
            btnEditProfileA = new Button();
            txtPassword = new Panel();
            txtNoTelp = new Panel();
            txtEmail = new Panel();
            txtName = new Panel();
            panel3 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-18, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1597, 940);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtNoTelp);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(21, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1387, 769);
            panel2.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnLogout);
            panel9.Controls.Add(btnRiwayat);
            panel9.Controls.Add(btnDashboard);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(300, 769);
            panel9.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(9, 391);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(271, 57);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.Transparent;
            btnRiwayat.BackgroundImage = (Image)resources.GetObject("btnRiwayat.BackgroundImage");
            btnRiwayat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRiwayat.ForeColor = SystemColors.ActiveCaptionText;
            btnRiwayat.Location = new Point(9, 328);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(271, 57);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "Riwayat Penyewaan";
            btnRiwayat.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.Location = new Point(9, 265);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(271, 57);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnEditProfileA);
            panel8.Location = new Point(362, 573);
            panel8.Name = "panel8";
            panel8.Size = new Size(285, 93);
            panel8.TabIndex = 5;
            // 
            // btnEditProfileA
            // 
            btnEditProfileA.BackgroundImage = (Image)resources.GetObject("btnEditProfileA.BackgroundImage");
            btnEditProfileA.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditProfileA.Location = new Point(17, 15);
            btnEditProfileA.Name = "btnEditProfileA";
            btnEditProfileA.Size = new Size(241, 53);
            btnEditProfileA.TabIndex = 0;
            btnEditProfileA.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.BackgroundImage = (Image)resources.GetObject("txtPassword.BackgroundImage");
            txtPassword.Location = new Point(687, 588);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(495, 53);
            txtPassword.TabIndex = 4;
            // 
            // txtNoTelp
            // 
            txtNoTelp.BackgroundImage = (Image)resources.GetObject("txtNoTelp.BackgroundImage");
            txtNoTelp.Location = new Point(687, 499);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(495, 53);
            txtNoTelp.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BackgroundImage = (Image)resources.GetObject("txtEmail.BackgroundImage");
            txtEmail.Location = new Point(687, 408);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(495, 53);
            txtEmail.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.BackgroundImage = (Image)resources.GetObject("txtName.BackgroundImage");
            txtName.Location = new Point(687, 315);
            txtName.Name = "txtName";
            txtName.Size = new Size(495, 53);
            txtName.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(362, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(284, 291);
            panel3.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // V_profleAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1554, 901);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveBorder;
            Name = "V_profleAdmin";
            Text = "V_editeprofle";
            Load += V_profle_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel8;
        private Panel txtPassword;
        private Panel txtNoTelp;
        private Panel txtEmail;
        private Panel txtName;
        private Button btnEditProfileA;
        private Panel panel9;
        private Button btnDashboard;
        private Button button4;
        private Button btnLogout;
        private Button btnRiwayat;
        private ContextMenuStrip contextMenuStrip1;
    }
}