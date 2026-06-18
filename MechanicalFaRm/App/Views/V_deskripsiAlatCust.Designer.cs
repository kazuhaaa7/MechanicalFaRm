namespace MechanicalFaRm.App.Views
{
    partial class V_deskripsiAlatCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_deskripsiAlatCust));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rtbDeskripsi = new RichTextBox();
            tbStok = new TextBox();
            tbHarga = new TextBox();
            tbNamaBarang = new TextBox();
            btnPicture = new PictureBox();
            panel2 = new Panel();
            btnDasboard = new Button();
            btnKeranjang = new Button();
            btnLogout = new Button();
            btnProfile = new Button();
            btnRiwayatPenyewaan = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnPicture).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rtbDeskripsi);
            panel1.Controls.Add(tbStok);
            panel1.Controls.Add(tbHarga);
            panel1.Controls.Add(tbNamaBarang);
            panel1.Controls.Add(btnPicture);
            panel1.Controls.Add(panel2);
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
            label4.Location = new Point(752, 408);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 15;
            label4.Text = "*satuan juta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(718, 377);
            label3.Name = "label3";
            label3.Size = new Size(129, 31);
            label3.TabIndex = 14;
            label3.Text = "Harga Alat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(706, 301);
            label2.Name = "label2";
            label2.Size = new Size(155, 31);
            label2.TabIndex = 13;
            label2.Text = "Stok Tersedia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(706, 223);
            label1.Name = "label1";
            label1.Size = new Size(159, 31);
            label1.TabIndex = 12;
            label1.Text = "Nama Barang";
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(483, 640);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(1355, 345);
            rtbDeskripsi.TabIndex = 11;
            rtbDeskripsi.Text = "";
            // 
            // tbStok
            // 
            tbStok.Location = new Point(986, 301);
            tbStok.Multiline = true;
            tbStok.Name = "tbStok";
            tbStok.PlaceholderText = "Stok";
            tbStok.Size = new Size(438, 44);
            tbStok.TabIndex = 10;
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(986, 389);
            tbHarga.Multiline = true;
            tbHarga.Name = "tbHarga";
            tbHarga.PlaceholderText = "Harga";
            tbHarga.Size = new Size(438, 44);
            tbHarga.TabIndex = 9;
            // 
            // tbNamaBarang
            // 
            tbNamaBarang.Location = new Point(986, 223);
            tbNamaBarang.Multiline = true;
            tbNamaBarang.Name = "tbNamaBarang";
            tbNamaBarang.PlaceholderText = "Nama Barang";
            tbNamaBarang.Size = new Size(438, 44);
            tbNamaBarang.TabIndex = 8;
            // 
            // btnPicture
            // 
            btnPicture.Location = new Point(1483, 207);
            btnPicture.Name = "btnPicture";
            btnPicture.Size = new Size(330, 245);
            btnPicture.TabIndex = 7;
            btnPicture.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnDasboard);
            panel2.Controls.Add(btnKeranjang);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnProfile);
            panel2.Controls.Add(btnRiwayatPenyewaan);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 1082);
            panel2.TabIndex = 0;
            // 
            // btnDasboard
            // 
            btnDasboard.BackColor = Color.Transparent;
            btnDasboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDasboard.FlatAppearance.BorderSize = 0;
            btnDasboard.FlatStyle = FlatStyle.Flat;
            btnDasboard.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDasboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDasboard.Location = new Point(50, 341);
            btnDasboard.Name = "btnDasboard";
            btnDasboard.Size = new Size(283, 67);
            btnDasboard.TabIndex = 10;
            btnDasboard.UseVisualStyleBackColor = false;
            btnDasboard.Click += btnDasboard_Click;
            // 
            // btnKeranjang
            // 
            btnKeranjang.BackColor = Color.Transparent;
            btnKeranjang.BackgroundImageLayout = ImageLayout.Stretch;
            btnKeranjang.FlatAppearance.BorderSize = 0;
            btnKeranjang.FlatStyle = FlatStyle.Flat;
            btnKeranjang.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKeranjang.ForeColor = SystemColors.ActiveCaptionText;
            btnKeranjang.Location = new Point(50, 550);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(283, 67);
            btnKeranjang.TabIndex = 9;
            btnKeranjang.UseVisualStyleBackColor = false;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(50, 989);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(283, 67);
            btnLogout.TabIndex = 8;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = SystemColors.ActiveCaptionText;
            btnProfile.Location = new Point(50, 760);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(283, 67);
            btnProfile.TabIndex = 7;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnRiwayatPenyewaan
            // 
            btnRiwayatPenyewaan.BackColor = Color.Transparent;
            btnRiwayatPenyewaan.BackgroundImageLayout = ImageLayout.Stretch;
            btnRiwayatPenyewaan.FlatAppearance.BorderSize = 0;
            btnRiwayatPenyewaan.FlatStyle = FlatStyle.Flat;
            btnRiwayatPenyewaan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRiwayatPenyewaan.ForeColor = SystemColors.ActiveCaptionText;
            btnRiwayatPenyewaan.Location = new Point(50, 442);
            btnRiwayatPenyewaan.Name = "btnRiwayatPenyewaan";
            btnRiwayatPenyewaan.Size = new Size(283, 67);
            btnRiwayatPenyewaan.TabIndex = 6;
            btnRiwayatPenyewaan.UseVisualStyleBackColor = false;
            btnRiwayatPenyewaan.Click += btnRiwayatPenyewaan_Click;
            // 
            // V_deskripsiAlatCust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1082);
            Controls.Add(panel1);
            Name = "V_deskripsiAlatCust";
            Text = "V_deskripsiAlatCust";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnPicture).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDasboard;
        private Button btnKeranjang;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnRiwayatPenyewaan;
        private RichTextBox rtbDeskripsi;
        private TextBox tbStok;
        private TextBox tbHarga;
        private TextBox tbNamaBarang;
        private PictureBox btnPicture;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}