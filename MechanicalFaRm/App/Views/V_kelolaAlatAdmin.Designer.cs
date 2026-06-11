namespace MechanicalFaRm.App.Views
{
    partial class V_kelolaAlatAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_kelolaAlatAdmin));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            btnProfil = new Button();
            btnDeskripsiAlat = new Button();
            btnKelolaCust = new Button();
            btnLogout = new Button();
            btnRiwayatPenyewaan = new Button();
            btnKelolaAlat = new Button();
            panel3 = new Panel();
            btnHapus = new Button();
            btnEdit = new Button();
            btnSImpan = new Button();
            dgvKelolaAlat = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKelolaAlat).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 1096);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvKelolaAlat);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 1093);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnProfil);
            panel4.Controls.Add(btnDeskripsiAlat);
            panel4.Controls.Add(btnKelolaCust);
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(btnRiwayatPenyewaan);
            panel4.Controls.Add(btnKelolaAlat);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(383, 1093);
            panel4.TabIndex = 2;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.DarkGray;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = SystemColors.ActiveCaptionText;
            btnProfil.Location = new Point(40, 622);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(302, 67);
            btnProfil.TabIndex = 11;
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
            btnDeskripsiAlat.Location = new Point(40, 549);
            btnDeskripsiAlat.Name = "btnDeskripsiAlat";
            btnDeskripsiAlat.Size = new Size(302, 67);
            btnDeskripsiAlat.TabIndex = 10;
            btnDeskripsiAlat.Text = "Deskripsi Alat";
            btnDeskripsiAlat.UseVisualStyleBackColor = false;
            btnDeskripsiAlat.Click += btnDeskripsiAlat_Click;
            // 
            // btnKelolaCust
            // 
            btnKelolaCust.BackColor = Color.DarkGray;
            btnKelolaCust.FlatAppearance.BorderSize = 0;
            btnKelolaCust.FlatStyle = FlatStyle.Flat;
            btnKelolaCust.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKelolaCust.ForeColor = SystemColors.ActiveCaptionText;
            btnKelolaCust.Location = new Point(40, 403);
            btnKelolaCust.Name = "btnKelolaCust";
            btnKelolaCust.Size = new Size(302, 67);
            btnKelolaCust.TabIndex = 9;
            btnKelolaCust.Text = "Kelola Customer";
            btnKelolaCust.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkGray;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(40, 695);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(302, 67);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnRiwayatPenyewaan
            // 
            btnRiwayatPenyewaan.BackColor = Color.DarkGray;
            btnRiwayatPenyewaan.FlatAppearance.BorderSize = 0;
            btnRiwayatPenyewaan.FlatStyle = FlatStyle.Flat;
            btnRiwayatPenyewaan.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRiwayatPenyewaan.ForeColor = SystemColors.ActiveCaptionText;
            btnRiwayatPenyewaan.Location = new Point(40, 476);
            btnRiwayatPenyewaan.Name = "btnRiwayatPenyewaan";
            btnRiwayatPenyewaan.Size = new Size(302, 67);
            btnRiwayatPenyewaan.TabIndex = 7;
            btnRiwayatPenyewaan.Text = "Riwayat Penyewaan";
            btnRiwayatPenyewaan.UseVisualStyleBackColor = false;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.BackColor = Color.DarkGray;
            btnKelolaAlat.FlatAppearance.BorderSize = 0;
            btnKelolaAlat.FlatStyle = FlatStyle.Flat;
            btnKelolaAlat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKelolaAlat.ForeColor = SystemColors.ActiveCaptionText;
            btnKelolaAlat.Location = new Point(40, 330);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(302, 67);
            btnKelolaAlat.TabIndex = 6;
            btnKelolaAlat.Text = "Kelola Alat";
            btnKelolaAlat.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnHapus);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnSImpan);
            panel3.Location = new Point(437, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(1245, 88);
            panel3.TabIndex = 1;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.IndianRed;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = SystemColors.ButtonHighlight;
            btnHapus.Location = new Point(211, 12);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(180, 56);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.RoyalBlue;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ButtonFace;
            btnEdit.Location = new Point(412, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 56);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSImpan
            // 
            btnSImpan.BackColor = Color.ForestGreen;
            btnSImpan.FlatAppearance.BorderSize = 0;
            btnSImpan.FlatStyle = FlatStyle.Flat;
            btnSImpan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSImpan.ForeColor = SystemColors.ButtonHighlight;
            btnSImpan.Location = new Point(12, 12);
            btnSImpan.Name = "btnSImpan";
            btnSImpan.Size = new Size(180, 56);
            btnSImpan.TabIndex = 0;
            btnSImpan.Text = "Simpan";
            btnSImpan.UseVisualStyleBackColor = false;
            // 
            // dgvKelolaAlat
            // 
            dgvKelolaAlat.BackgroundColor = SystemColors.Control;
            dgvKelolaAlat.BorderStyle = BorderStyle.Fixed3D;
            dgvKelolaAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKelolaAlat.Location = new Point(417, 312);
            dgvKelolaAlat.Name = "dgvKelolaAlat";
            dgvKelolaAlat.RowHeadersWidth = 51;
            dgvKelolaAlat.Size = new Size(1412, 708);
            dgvKelolaAlat.TabIndex = 0;
            dgvKelolaAlat.CellContentClick += dgvKelolaAlat_CellContentClick;
            // 
            // V_kelolaAlatAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1048);
            Controls.Add(panel1);
            Name = "V_kelolaAlatAdmin";
            Text = "V_kelolaAlatAdmin";
            Load += V_kelolaAlatAdmin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKelolaAlat).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnSImpan;
        private DataGridView dgvKelolaAlat;
        private Panel panel4;
        private Button btnProfil;
        private Button btnDeskripsiAlat;
        private Button btnKelolaCust;
        private Button btnLogout;
        private Button btnRiwayatPenyewaan;
        private Button btnKelolaAlat;
    }
}