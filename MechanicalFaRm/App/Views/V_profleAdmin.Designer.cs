
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
            panel6 = new Panel();
            lblEmail = new Label();
            lblNoTelp = new Label();
            lblUsername = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnEditProfileA = new Button();
            btnDeskripsiAlat = new Button();
            btnKelolaCust = new Button();
            btnLogout = new Button();
            btnRiwayatPenyewaan = new Button();
            btnKelolaAlat = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnEditProfileA);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 1051);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(lblEmail);
            panel6.Controls.Add(lblNoTelp);
            panel6.Controls.Add(lblUsername);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(936, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(988, 1051);
            panel6.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.FlatStyle = FlatStyle.Flat;
            lblEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ActiveCaptionText;
            lblEmail.Location = new Point(37, 420);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(471, 36);
            lblEmail.TabIndex = 29;
            lblEmail.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNoTelp
            // 
            lblNoTelp.FlatStyle = FlatStyle.Flat;
            lblNoTelp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoTelp.ForeColor = SystemColors.ActiveCaptionText;
            lblNoTelp.Location = new Point(49, 554);
            lblNoTelp.Name = "lblNoTelp";
            lblNoTelp.Size = new Size(471, 38);
            lblNoTelp.TabIndex = 30;
            lblNoTelp.TextAlign = ContentAlignment.TopCenter;
            lblNoTelp.Click += lblNoTelp_Click;
            // 
            // lblUsername
            // 
            lblUsername.FlatStyle = FlatStyle.Flat;
            lblUsername.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ActiveCaptionText;
            lblUsername.Location = new Point(49, 297);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(471, 36);
            lblUsername.TabIndex = 28;
            lblUsername.TextAlign = ContentAlignment.TopCenter;
            lblUsername.Click += lblUsername_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnDeskripsiAlat);
            panel2.Controls.Add(btnKelolaCust);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnRiwayatPenyewaan);
            panel2.Controls.Add(btnKelolaAlat);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 1051);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(463, 315);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 332);
            panel3.TabIndex = 23;
            // 
            // btnEditProfileA
            // 
            btnEditProfileA.BackColor = Color.Transparent;
            btnEditProfileA.BackgroundImage = (Image)resources.GetObject("btnEditProfileA.BackgroundImage");
            btnEditProfileA.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditProfileA.FlatAppearance.BorderSize = 0;
            btnEditProfileA.FlatStyle = FlatStyle.Flat;
            btnEditProfileA.Location = new Point(502, 676);
            btnEditProfileA.Name = "btnEditProfileA";
            btnEditProfileA.Size = new Size(271, 59);
            btnEditProfileA.TabIndex = 24;
            btnEditProfileA.UseVisualStyleBackColor = false;
            btnEditProfileA.Click += btnEditProfileA_Click;
            // 
            // btnDeskripsiAlat
            // 
            btnDeskripsiAlat.BackColor = Color.Transparent;
            btnDeskripsiAlat.FlatAppearance.BorderSize = 0;
            btnDeskripsiAlat.FlatStyle = FlatStyle.Flat;
            btnDeskripsiAlat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeskripsiAlat.ForeColor = SystemColors.ActiveCaptionText;
            btnDeskripsiAlat.Location = new Point(47, 636);
            btnDeskripsiAlat.Name = "btnDeskripsiAlat";
            btnDeskripsiAlat.Size = new Size(291, 67);
            btnDeskripsiAlat.TabIndex = 21;
            btnDeskripsiAlat.UseVisualStyleBackColor = false;
            btnDeskripsiAlat.Click += btnDeskripsiAlat_Click;
            // 
            // btnKelolaCust
            // 
            btnKelolaCust.BackColor = Color.Transparent;
            btnKelolaCust.FlatAppearance.BorderSize = 0;
            btnKelolaCust.FlatStyle = FlatStyle.Flat;
            btnKelolaCust.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKelolaCust.ForeColor = SystemColors.ActiveCaptionText;
            btnKelolaCust.Location = new Point(47, 429);
            btnKelolaCust.Name = "btnKelolaCust";
            btnKelolaCust.Size = new Size(291, 67);
            btnKelolaCust.TabIndex = 20;
            btnKelolaCust.UseVisualStyleBackColor = false;
            btnKelolaCust.Click += btnKelolaCust_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(56, 963);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(282, 67);
            btnLogout.TabIndex = 19;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnRiwayatPenyewaan
            // 
            btnRiwayatPenyewaan.BackColor = Color.Transparent;
            btnRiwayatPenyewaan.FlatAppearance.BorderSize = 0;
            btnRiwayatPenyewaan.FlatStyle = FlatStyle.Flat;
            btnRiwayatPenyewaan.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRiwayatPenyewaan.ForeColor = SystemColors.ActiveCaptionText;
            btnRiwayatPenyewaan.Location = new Point(47, 531);
            btnRiwayatPenyewaan.Name = "btnRiwayatPenyewaan";
            btnRiwayatPenyewaan.Size = new Size(291, 67);
            btnRiwayatPenyewaan.TabIndex = 18;
            btnRiwayatPenyewaan.UseVisualStyleBackColor = false;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.BackColor = Color.Transparent;
            btnKelolaAlat.FlatAppearance.BorderSize = 0;
            btnKelolaAlat.FlatStyle = FlatStyle.Flat;
            btnKelolaAlat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKelolaAlat.ForeColor = SystemColors.ActiveCaptionText;
            btnKelolaAlat.Location = new Point(36, 328);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(302, 72);
            btnKelolaAlat.TabIndex = 17;
            btnKelolaAlat.UseVisualStyleBackColor = false;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
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
            ClientSize = new Size(1924, 1051);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveBorder;
            Name = "V_profleAdmin";
            Text = "V_editeprofle";
            Load += V_profle_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel8;
        private Button btnEditProfileA;
        private Panel panel9;
        private Button btnKelolaAlat;
        private Button button4;
        private Button btnLogout;
        private Button btnRiwayatPenyewaan;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblUsername;
        private Label label1;
        private Label lblNoTelp;
        private Label lblEmail;
        private Button btnKelolaCust;
        private Button btnDeskripsiAlat;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}