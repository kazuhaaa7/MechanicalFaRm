namespace MechanicalFaRm.App.Views
{
    partial class UC_Pembayaran
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIdPesanan = new Label();
            lblTanggal = new Label();
            lblNamaPenyewa = new Label();
            lblTotalHarga = new Label();
            cbMetodeBayar = new ComboBox();
            btnBayar = new Button();
            flpBarangSewa = new FlowLayoutPanel();
            lbl = new Label();
            tbNamaJalan = new TextBox();
            SuspendLayout();
            // 
            // lblIdPesanan
            // 
            lblIdPesanan.AutoSize = true;
            lblIdPesanan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdPesanan.Location = new Point(23, 13);
            lblIdPesanan.Name = "lblIdPesanan";
            lblIdPesanan.Size = new Size(79, 31);
            lblIdPesanan.TabIndex = 0;
            lblIdPesanan.Text = "label1";
            lblIdPesanan.Click += label1_Click;
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggal.Location = new Point(707, 13);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(77, 31);
            lblTanggal.TabIndex = 1;
            lblTanggal.Text = "label2";
            // 
            // lblNamaPenyewa
            // 
            lblNamaPenyewa.AutoSize = true;
            lblNamaPenyewa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaPenyewa.Location = new Point(23, 62);
            lblNamaPenyewa.Name = "lblNamaPenyewa";
            lblNamaPenyewa.Size = new Size(79, 31);
            lblNamaPenyewa.TabIndex = 2;
            lblNamaPenyewa.Text = "label3";
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.Location = new Point(29, 504);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(104, 41);
            lblTotalHarga.TabIndex = 3;
            lblTotalHarga.Text = "label4";
            lblTotalHarga.Click += lblTotalHarga_Click;
            // 
            // cbMetodeBayar
            // 
            cbMetodeBayar.FormattingEnabled = true;
            cbMetodeBayar.Location = new Point(448, 514);
            cbMetodeBayar.Name = "cbMetodeBayar";
            cbMetodeBayar.Size = new Size(207, 28);
            cbMetodeBayar.TabIndex = 4;
            cbMetodeBayar.Click += cbMetodeBayar_Click;
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(684, 508);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(127, 38);
            btnBayar.TabIndex = 5;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // flpBarangSewa
            // 
            flpBarangSewa.BackColor = Color.Transparent;
            flpBarangSewa.FlowDirection = FlowDirection.TopDown;
            flpBarangSewa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpBarangSewa.ForeColor = Color.Black;
            flpBarangSewa.Location = new Point(29, 125);
            flpBarangSewa.Name = "flpBarangSewa";
            flpBarangSewa.Size = new Size(948, 270);
            flpBarangSewa.TabIndex = 6;
            flpBarangSewa.Paint += flpBarangSewa_Paint;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(33, 423);
            lbl.Name = "lbl";
            lbl.Size = new Size(69, 31);
            lbl.TabIndex = 7;
            lbl.Text = "Jalan";
            // 
            // tbNamaJalan
            // 
            tbNamaJalan.BorderStyle = BorderStyle.FixedSingle;
            tbNamaJalan.Location = new Point(120, 423);
            tbNamaJalan.Multiline = true;
            tbNamaJalan.Name = "tbNamaJalan";
            tbNamaJalan.Size = new Size(502, 46);
            tbNamaJalan.TabIndex = 8;
            // 
            // UC_Pembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tbNamaJalan);
            Controls.Add(lbl);
            Controls.Add(lblTotalHarga);
            Controls.Add(lblTanggal);
            Controls.Add(lblNamaPenyewa);
            Controls.Add(lblIdPesanan);
            Controls.Add(flpBarangSewa);
            Controls.Add(btnBayar);
            Controls.Add(cbMetodeBayar);
            Name = "UC_Pembayaran";
            Size = new Size(1013, 869);
            Load += UC_Pembayaran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdPesanan;
        private Label lblTanggal;
        private Label lblNamaPenyewa;
        private Label lblTotalHarga;
        private Button button1;
        private ComboBox cbMetodeBayar;
        private FlowLayoutPanel flpBarangSewa;
        private Button btnBayar;
        private Label lbl;
        private TextBox tbNamaJalan;
    }
}
