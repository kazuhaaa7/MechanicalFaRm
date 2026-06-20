namespace MechanicalFaRm.App.Views
{
    partial class V_popupBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_popupBarang));
            panel1 = new Panel();
            dtpKembali = new DateTimePicker();
            dtpSewa = new DateTimePicker();
            tbNamaPenyewa = new TextBox();
            panel2 = new Panel();
            btnLanjut = new Button();
            btnKeranjang = new Button();
            label8 = new Label();
            lblHargaAlat = new Label();
            lblStokAlat = new Label();
            lblNamaAlat = new Label();
            label7 = new Label();
            tbQty = new TextBox();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(dtpKembali);
            panel1.Controls.Add(dtpSewa);
            panel1.Controls.Add(tbNamaPenyewa);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblHargaAlat);
            panel1.Controls.Add(lblStokAlat);
            panel1.Controls.Add(lblNamaAlat);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbQty);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dtpKembali
            // 
            dtpKembali.Location = new Point(313, 257);
            dtpKembali.Name = "dtpKembali";
            dtpKembali.Size = new Size(250, 27);
            dtpKembali.TabIndex = 24;
            // 
            // dtpSewa
            // 
            dtpSewa.Location = new Point(313, 212);
            dtpSewa.Name = "dtpSewa";
            dtpSewa.Size = new Size(250, 27);
            dtpSewa.TabIndex = 23;
            dtpSewa.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tbNamaPenyewa
            // 
            tbNamaPenyewa.BackColor = Color.Moccasin;
            tbNamaPenyewa.BorderStyle = BorderStyle.None;
            tbNamaPenyewa.Location = new Point(323, 301);
            tbNamaPenyewa.Multiline = true;
            tbNamaPenyewa.Name = "tbNamaPenyewa";
            tbNamaPenyewa.Size = new Size(215, 32);
            tbNamaPenyewa.TabIndex = 22;
            tbNamaPenyewa.TextChanged += tbNamaPenyewa_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnLanjut);
            panel2.Controls.Add(btnKeranjang);
            panel2.Location = new Point(260, 371);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 76);
            panel2.TabIndex = 21;
            // 
            // btnLanjut
            // 
            btnLanjut.BackColor = Color.Transparent;
            btnLanjut.BackgroundImage = (Image)resources.GetObject("btnLanjut.BackgroundImage");
            btnLanjut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLanjut.FlatAppearance.BorderSize = 0;
            btnLanjut.FlatStyle = FlatStyle.Flat;
            btnLanjut.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLanjut.ForeColor = SystemColors.ButtonHighlight;
            btnLanjut.Location = new Point(216, 12);
            btnLanjut.Name = "btnLanjut";
            btnLanjut.Size = new Size(173, 55);
            btnLanjut.TabIndex = 10;
            btnLanjut.Text = "Lanjut";
            btnLanjut.UseVisualStyleBackColor = false;
            btnLanjut.Click += btnLanjut_Click;
            // 
            // btnKeranjang
            // 
            btnKeranjang.BackgroundImage = (Image)resources.GetObject("btnKeranjang.BackgroundImage");
            btnKeranjang.FlatAppearance.BorderSize = 0;
            btnKeranjang.FlatStyle = FlatStyle.Flat;
            btnKeranjang.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeranjang.ForeColor = SystemColors.ButtonHighlight;
            btnKeranjang.Location = new Point(3, 12);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(181, 55);
            btnKeranjang.TabIndex = 11;
            btnKeranjang.Text = "Keranjang";
            btnKeranjang.UseVisualStyleBackColor = true;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(155, 110);
            label8.Name = "label8";
            label8.Size = new Size(76, 17);
            label8.TabIndex = 19;
            label8.Text = "*satuan juta";
            // 
            // lblHargaAlat
            // 
            lblHargaAlat.BackColor = Color.Transparent;
            lblHargaAlat.FlatStyle = FlatStyle.Flat;
            lblHargaAlat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHargaAlat.ForeColor = SystemColors.ActiveCaptionText;
            lblHargaAlat.Location = new Point(320, 80);
            lblHargaAlat.Name = "lblHargaAlat";
            lblHargaAlat.Size = new Size(217, 33);
            lblHargaAlat.TabIndex = 18;
            lblHargaAlat.Text = "juta";
            lblHargaAlat.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblStokAlat
            // 
            lblStokAlat.BackColor = Color.Transparent;
            lblStokAlat.FlatStyle = FlatStyle.Flat;
            lblStokAlat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokAlat.ForeColor = SystemColors.ActiveCaptionText;
            lblStokAlat.Location = new Point(320, 167);
            lblStokAlat.Name = "lblStokAlat";
            lblStokAlat.Size = new Size(208, 33);
            lblStokAlat.TabIndex = 17;
            lblStokAlat.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNamaAlat
            // 
            lblNamaAlat.BackColor = Color.Transparent;
            lblNamaAlat.FlatStyle = FlatStyle.Flat;
            lblNamaAlat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaAlat.ForeColor = SystemColors.ActiveCaptionText;
            lblNamaAlat.Location = new Point(320, 42);
            lblNamaAlat.Name = "lblNamaAlat";
            lblNamaAlat.Size = new Size(217, 27);
            lblNamaAlat.TabIndex = 16;
            lblNamaAlat.TextAlign = ContentAlignment.TopCenter;
            lblNamaAlat.Click += lblNamaAlat_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(145, 231);
            label7.Name = "label7";
            label7.Size = new Size(164, 17);
            label7.TabIndex = 15;
            label7.Text = "*minimal penyewaan 3 hari";
            label7.Click += label7_Click;
            // 
            // tbQty
            // 
            tbQty.BackColor = Color.Moccasin;
            tbQty.BorderStyle = BorderStyle.None;
            tbQty.Location = new Point(320, 127);
            tbQty.Multiline = true;
            tbQty.Name = "tbQty";
            tbQty.Size = new Size(217, 34);
            tbQty.TabIndex = 7;
            tbQty.TextChanged += textBox3_TextChanged;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // V_popupBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "V_popupBarang";
            Text = "V_popupBarang_cs";
            Load += V_popupBarang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbStoktersedia;
        private TextBox tbQty;
        private TextBox textBox2;
        private Button btnLanjut;
        private Button btnKeranjang;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Label label7;
        private Label lblNamaAlat;
        private Label lblHargaAlat;
        private Label lblStokAlat;
        private Label label8;
        private Panel panel2;
        private TextBox tbNamaPenyewa;
        private DateTimePicker dtpSewa;
        private DateTimePicker dtpKembali;
    }
}