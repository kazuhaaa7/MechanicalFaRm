namespace MechanicalFaRm.App.Views
{
    partial class V_keranjangCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_keranjangCust));
            panel1 = new Panel();
            panel2 = new Panel();
            btnKeranjang = new Button();
            btnDshbrd = new Button();
            btnProfil = new Button();
            btnDeskripsiAlat = new Button();
            btnLogout = new Button();
            btnRiwayatPenyewaan = new Button();
            dgvKeranjang = new DataGridView();
            btnSubmit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvKeranjang);
            panel1.Controls.Add(btnSubmit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1919, 1047);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnKeranjang);
            panel2.Controls.Add(btnDshbrd);
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(btnDeskripsiAlat);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnRiwayatPenyewaan);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 1047);
            panel2.TabIndex = 4;
            // 
            // btnKeranjang
            // 
            btnKeranjang.BackColor = Color.DarkGray;
            btnKeranjang.FlatAppearance.BorderSize = 0;
            btnKeranjang.FlatStyle = FlatStyle.Flat;
            btnKeranjang.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKeranjang.ForeColor = SystemColors.ActiveCaptionText;
            btnKeranjang.Location = new Point(45, 453);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(302, 67);
            btnKeranjang.TabIndex = 19;
            btnKeranjang.Text = "Keranjang";
            btnKeranjang.UseVisualStyleBackColor = false;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // btnDshbrd
            // 
            btnDshbrd.BackColor = Color.DarkGray;
            btnDshbrd.FlatAppearance.BorderSize = 0;
            btnDshbrd.FlatStyle = FlatStyle.Flat;
            btnDshbrd.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDshbrd.ForeColor = SystemColors.ActiveCaptionText;
            btnDshbrd.Location = new Point(45, 307);
            btnDshbrd.Name = "btnDshbrd";
            btnDshbrd.Size = new Size(302, 67);
            btnDshbrd.TabIndex = 18;
            btnDshbrd.Text = "Dashboard";
            btnDshbrd.UseVisualStyleBackColor = false;
            btnDshbrd.Click += btnDshbrd_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.DarkGray;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = SystemColors.ActiveCaptionText;
            btnProfil.Location = new Point(45, 597);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(302, 67);
            btnProfil.TabIndex = 17;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnDeskripsiAlat
            // 
            btnDeskripsiAlat.BackColor = Color.DarkGray;
            btnDeskripsiAlat.FlatAppearance.BorderSize = 0;
            btnDeskripsiAlat.FlatStyle = FlatStyle.Flat;
            btnDeskripsiAlat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeskripsiAlat.ForeColor = SystemColors.ActiveCaptionText;
            btnDeskripsiAlat.Location = new Point(45, 524);
            btnDeskripsiAlat.Name = "btnDeskripsiAlat";
            btnDeskripsiAlat.Size = new Size(302, 67);
            btnDeskripsiAlat.TabIndex = 16;
            btnDeskripsiAlat.Text = "Deskripsi Alat";
            btnDeskripsiAlat.UseVisualStyleBackColor = false;
            btnDeskripsiAlat.Click += btnDeskripsiAlat_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkGray;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(45, 670);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(302, 67);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRiwayatPenyewaan
            // 
            btnRiwayatPenyewaan.BackColor = Color.DarkGray;
            btnRiwayatPenyewaan.FlatAppearance.BorderSize = 0;
            btnRiwayatPenyewaan.FlatStyle = FlatStyle.Flat;
            btnRiwayatPenyewaan.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRiwayatPenyewaan.ForeColor = SystemColors.ActiveCaptionText;
            btnRiwayatPenyewaan.Location = new Point(45, 380);
            btnRiwayatPenyewaan.Name = "btnRiwayatPenyewaan";
            btnRiwayatPenyewaan.Size = new Size(302, 67);
            btnRiwayatPenyewaan.TabIndex = 13;
            btnRiwayatPenyewaan.Text = "Riwayat Penyewaan";
            btnRiwayatPenyewaan.UseVisualStyleBackColor = false;
            btnRiwayatPenyewaan.Click += btnRiwayatPenyewaan_Click;
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.BackgroundColor = SystemColors.Control;
            dgvKeranjang.BorderStyle = BorderStyle.Fixed3D;
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeranjang.Location = new Point(435, 172);
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.RowHeadersWidth = 51;
            dgvKeranjang.Size = new Size(1416, 808);
            dgvKeranjang.TabIndex = 3;
            dgvKeranjang.CellContentClick += dgvKeranjang_CellContentClick;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Silver;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Location = new Point(1680, 986);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(171, 49);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // V_keranjangCust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1919, 1047);
            Controls.Add(panel1);
            Name = "V_keranjangCust";
            Text = "V_keranjangCust";
            Load += V_keranjangCust_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSubmit;
        private DataGridView dgvKeranjang;
        private Panel panel2;
        private Button btnProfil;
        private Button btnDeskripsiAlat;
        private Button btnLogout;
        private Button btnRiwayatPenyewaan;
        private Button btnKeranjang;
        private Button btnDshbrd;
    }
}