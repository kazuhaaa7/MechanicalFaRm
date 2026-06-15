namespace MechanicalFaRm.App.Views
{
    partial class V_kelolaAkunAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_kelolaAkunAdmin));
            dgvKelolaAkun = new DataGridView();
            panel2 = new Panel();
            btnProfil = new Button();
            btnDeskripsiAlat = new Button();
            btnLogout = new Button();
            btnRiwayatPenyewaan = new Button();
            btnKelolaAlat = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKelolaAkun).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKelolaAkun
            // 
            dgvKelolaAkun.BackgroundColor = SystemColors.Control;
            dgvKelolaAkun.BorderStyle = BorderStyle.Fixed3D;
            dgvKelolaAkun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKelolaAkun.Location = new Point(432, 205);
            dgvKelolaAkun.Name = "dgvKelolaAkun";
            dgvKelolaAkun.RowHeadersWidth = 51;
            dgvKelolaAkun.Size = new Size(1430, 817);
            dgvKelolaAkun.TabIndex = 2;
            dgvKelolaAkun.CellContentClick += dgvKelolaAkun_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(btnDeskripsiAlat);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnRiwayatPenyewaan);
            panel2.Controls.Add(btnKelolaAlat);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 1082);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Transparent;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = SystemColors.ActiveCaptionText;
            btnProfil.Location = new Point(39, 759);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(286, 67);
            btnProfil.TabIndex = 11;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnDeskripsiAlat
            // 
            btnDeskripsiAlat.BackColor = Color.Transparent;
            btnDeskripsiAlat.FlatAppearance.BorderSize = 0;
            btnDeskripsiAlat.FlatStyle = FlatStyle.Flat;
            btnDeskripsiAlat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeskripsiAlat.ForeColor = SystemColors.ActiveCaptionText;
            btnDeskripsiAlat.Location = new Point(39, 654);
            btnDeskripsiAlat.Name = "btnDeskripsiAlat";
            btnDeskripsiAlat.Size = new Size(286, 67);
            btnDeskripsiAlat.TabIndex = 10;
            btnDeskripsiAlat.UseVisualStyleBackColor = false;
            btnDeskripsiAlat.Click += btnDeskripsiAlat_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(39, 988);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(286, 67);
            btnLogout.TabIndex = 8;
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
            btnRiwayatPenyewaan.Location = new Point(39, 548);
            btnRiwayatPenyewaan.Name = "btnRiwayatPenyewaan";
            btnRiwayatPenyewaan.Size = new Size(286, 67);
            btnRiwayatPenyewaan.TabIndex = 7;
            btnRiwayatPenyewaan.UseVisualStyleBackColor = false;
            btnRiwayatPenyewaan.Click += btnRiwayatPenyewaan_Click;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.BackColor = Color.Transparent;
            btnKelolaAlat.FlatAppearance.BorderSize = 0;
            btnKelolaAlat.FlatStyle = FlatStyle.Flat;
            btnKelolaAlat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKelolaAlat.ForeColor = SystemColors.ActiveCaptionText;
            btnKelolaAlat.Location = new Point(39, 333);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(286, 67);
            btnKelolaAlat.TabIndex = 6;
            btnKelolaAlat.UseVisualStyleBackColor = false;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvKelolaAkun);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 1082);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_2;
            // 
            // V_kelolaAkunAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1082);
            Controls.Add(panel1);
            Name = "V_kelolaAkunAdmin";
            Text = "V_kelolaAkun";
            Load += V_kelolaAkunAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKelolaAkun).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKelolaAkun;
        private Panel panel2;
        private Button btnProfil;
        private Button btnDeskripsiAlat;
        private Button btnLogout;
        private Button btnRiwayatPenyewaan;
        private Button btnKelolaAlat;
        private Panel panel1;
    }
}