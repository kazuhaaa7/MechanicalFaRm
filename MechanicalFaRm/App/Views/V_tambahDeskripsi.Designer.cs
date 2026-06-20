namespace MechanicalFaRm.App.Views
{
    partial class V_tambahDeskripsi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_tambahDeskripsi));
            Button btnKelolaCust;
            Button btnRiwayatPenyewaan;
            Button btnProfil;
            Button btnLogout;
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBatal = new Button();
            btnSimpan = new Button();
            rtbDeskripsi = new RichTextBox();
            tbStok = new TextBox();
            tbHarga = new TextBox();
            tbNamaBarang = new TextBox();
            btnPicture = new PictureBox();
            btnKelolaCust = new Button();
            btnRiwayatPenyewaan = new Button();
            btnProfil = new Button();
            btnLogout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnProfil);
            panel1.Controls.Add(btnRiwayatPenyewaan);
            panel1.Controls.Add(btnKelolaCust);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBatal);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(rtbDeskripsi);
            panel1.Controls.Add(tbStok);
            panel1.Controls.Add(tbHarga);
            panel1.Controls.Add(tbNamaBarang);
            panel1.Controls.Add(btnPicture);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 1082);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(800, 436);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 19;
            label4.Text = "*satuan juta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(760, 403);
            label3.Name = "label3";
            label3.Size = new Size(129, 31);
            label3.TabIndex = 18;
            label3.Text = "Harga Alat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(760, 321);
            label2.Name = "label2";
            label2.Size = new Size(155, 31);
            label2.TabIndex = 17;
            label2.Text = "Stok Tersedia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(760, 243);
            label1.Name = "label1";
            label1.Size = new Size(159, 31);
            label1.TabIndex = 16;
            label1.Text = "Nama Barang";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(667, 552);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(155, 54);
            btnBatal.TabIndex = 6;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(481, 552);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(155, 54);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.BorderStyle = BorderStyle.FixedSingle;
            rtbDeskripsi.Location = new Point(481, 660);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(1355, 345);
            rtbDeskripsi.TabIndex = 4;
            rtbDeskripsi.Text = "";
            // 
            // tbStok
            // 
            tbStok.BorderStyle = BorderStyle.None;
            tbStok.Location = new Point(984, 321);
            tbStok.Multiline = true;
            tbStok.Name = "tbStok";
            tbStok.PlaceholderText = "Stok";
            tbStok.Size = new Size(438, 44);
            tbStok.TabIndex = 3;
            // 
            // tbHarga
            // 
            tbHarga.BorderStyle = BorderStyle.FixedSingle;
            tbHarga.Location = new Point(984, 409);
            tbHarga.Multiline = true;
            tbHarga.Name = "tbHarga";
            tbHarga.PlaceholderText = "Harga";
            tbHarga.Size = new Size(438, 44);
            tbHarga.TabIndex = 2;
            // 
            // tbNamaBarang
            // 
            tbNamaBarang.BorderStyle = BorderStyle.FixedSingle;
            tbNamaBarang.Location = new Point(984, 243);
            tbNamaBarang.Multiline = true;
            tbNamaBarang.Name = "tbNamaBarang";
            tbNamaBarang.PlaceholderText = "Nama Barang";
            tbNamaBarang.Size = new Size(438, 44);
            tbNamaBarang.TabIndex = 1;
            // 
            // btnPicture
            // 
            btnPicture.Location = new Point(1481, 227);
            btnPicture.Name = "btnPicture";
            btnPicture.Size = new Size(330, 245);
            btnPicture.TabIndex = 0;
            btnPicture.TabStop = false;
            btnPicture.Click += btnPicture_Click;
            // 
            // btnKelolaCust
            // 
            btnKelolaCust.BackColor = Color.Transparent;
            btnKelolaCust.BackgroundImage = (Image)resources.GetObject("btnKelolaCust.BackgroundImage");
            btnKelolaCust.BackgroundImageLayout = ImageLayout.Stretch;
            btnKelolaCust.FlatAppearance.BorderSize = 0;
            btnKelolaCust.FlatStyle = FlatStyle.Flat;
            btnKelolaCust.Location = new Point(35, 335);
            btnKelolaCust.Name = "btnKelolaCust";
            btnKelolaCust.Size = new Size(306, 76);
            btnKelolaCust.TabIndex = 20;
            btnKelolaCust.UseVisualStyleBackColor = false;
            // 
            // btnRiwayatPenyewaan
            // 
            btnRiwayatPenyewaan.BackColor = Color.Transparent;
            btnRiwayatPenyewaan.BackgroundImage = (Image)resources.GetObject("btnRiwayatPenyewaan.BackgroundImage");
            btnRiwayatPenyewaan.BackgroundImageLayout = ImageLayout.Stretch;
            btnRiwayatPenyewaan.FlatAppearance.BorderSize = 0;
            btnRiwayatPenyewaan.FlatStyle = FlatStyle.Flat;
            btnRiwayatPenyewaan.Location = new Point(35, 448);
            btnRiwayatPenyewaan.Name = "btnRiwayatPenyewaan";
            btnRiwayatPenyewaan.Size = new Size(306, 76);
            btnRiwayatPenyewaan.TabIndex = 21;
            btnRiwayatPenyewaan.UseVisualStyleBackColor = false;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Transparent;
            btnProfil.BackgroundImage = (Image)resources.GetObject("btnProfil.BackgroundImage");
            btnProfil.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Location = new Point(35, 669);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(306, 76);
            btnProfil.TabIndex = 22;
            btnProfil.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(35, 983);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(306, 76);
            btnLogout.TabIndex = 23;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // V_tambahDeskripsi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1082);
            Controls.Add(panel1);
            Name = "V_tambahDeskripsi";
            Text = "V_tambahKatalog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbStok;
        private TextBox tbHarga;
        private TextBox tbNamaBarang;
        private PictureBox btnPicture;
        private Button btnBatal;
        private Button btnSimpan;
        private RichTextBox rtbDeskripsi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnKelolaCust;
    }
}