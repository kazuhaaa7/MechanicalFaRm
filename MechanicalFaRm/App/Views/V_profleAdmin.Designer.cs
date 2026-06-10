
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
            lblNoTelp = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            label1 = new Label();
            panel9 = new Panel();
            btnLogout = new Button();
            btnRiwayat = new Button();
            btnDashboard = new Button();
            panel8 = new Panel();
            btnEditProfileA = new Button();
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
            panel1.Size = new Size(1945, 1051);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblNoTelp);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(21, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1387, 970);
            panel2.TabIndex = 0;
            // 
            // lblNoTelp
            // 
            lblNoTelp.FlatStyle = FlatStyle.Flat;
            lblNoTelp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoTelp.ForeColor = SystemColors.ActiveCaptionText;
            lblNoTelp.Location = new Point(847, 615);
            lblNoTelp.Name = "lblNoTelp";
            lblNoTelp.Size = new Size(471, 50);
            lblNoTelp.TabIndex = 10;
            lblNoTelp.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            lblEmail.FlatStyle = FlatStyle.Flat;
            lblEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ActiveCaptionText;
            lblEmail.Location = new Point(847, 502);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(471, 50);
            lblEmail.TabIndex = 9;
            lblEmail.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            lblUsername.FlatStyle = FlatStyle.Flat;
            lblUsername.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ActiveCaptionText;
            lblUsername.Location = new Point(856, 392);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(471, 50);
            lblUsername.TabIndex = 8;
            lblUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(901, 404);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnLogout);
            panel9.Controls.Add(btnRiwayat);
            panel9.Controls.Add(btnDashboard);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(361, 970);
            panel9.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkGray;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(39, 718);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(302, 67);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.DarkGray;
            btnRiwayat.FlatAppearance.BorderSize = 0;
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRiwayat.ForeColor = SystemColors.ActiveCaptionText;
            btnRiwayat.Location = new Point(39, 362);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(302, 67);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "Riwayat Penyewaan";
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DarkGray;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.Location = new Point(39, 289);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(302, 67);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnEditProfileA);
            panel8.Location = new Point(445, 654);
            panel8.Name = "panel8";
            panel8.Size = new Size(363, 112);
            panel8.TabIndex = 5;
            // 
            // btnEditProfileA
            // 
            btnEditProfileA.BackColor = Color.Transparent;
            btnEditProfileA.BackgroundImage = (Image)resources.GetObject("btnEditProfileA.BackgroundImage");
            btnEditProfileA.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditProfileA.FlatAppearance.BorderSize = 0;
            btnEditProfileA.FlatStyle = FlatStyle.Flat;
            btnEditProfileA.Location = new Point(50, 13);
            btnEditProfileA.Name = "btnEditProfileA";
            btnEditProfileA.Size = new Size(258, 59);
            btnEditProfileA.TabIndex = 0;
            btnEditProfileA.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(445, 306);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 326);
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
            ClientSize = new Size(1924, 1046);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveBorder;
            Name = "V_profleAdmin";
            Text = "V_editeprofle";
            Load += V_profle_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel8;
        private Button btnEditProfileA;
        private Panel panel9;
        private Button btnDashboard;
        private Button button4;
        private Button btnLogout;
        private Button btnRiwayat;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblUsername;
        private Label label1;
        private Label lblNoTelp;
        private Label lblEmail;
    }
}