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
            panel1 = new Panel();
            btnBatal = new Button();
            btnSimpan = new Button();
            rtbDeskripsi = new RichTextBox();
            tbStok = new TextBox();
            tbHarga = new TextBox();
            tbNamaBarang = new TextBox();
            btnPicture = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
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
            // btnBatal
            // 
            btnBatal.Location = new Point(1311, 576);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(139, 42);
            btnBatal.TabIndex = 6;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(1123, 576);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(124, 42);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(481, 660);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(1355, 345);
            rtbDeskripsi.TabIndex = 4;
            rtbDeskripsi.Text = "";
            // 
            // tbStok
            // 
            tbStok.Location = new Point(984, 321);
            tbStok.Multiline = true;
            tbStok.Name = "tbStok";
            tbStok.PlaceholderText = "Stok";
            tbStok.Size = new Size(438, 44);
            tbStok.TabIndex = 3;
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(984, 409);
            tbHarga.Multiline = true;
            tbHarga.Name = "tbHarga";
            tbHarga.PlaceholderText = "Harga";
            tbHarga.Size = new Size(438, 44);
            tbHarga.TabIndex = 2;
            // 
            // tbNamaBarang
            // 
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
    }
}