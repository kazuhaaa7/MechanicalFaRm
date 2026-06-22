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
            lblTotalTagihan = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
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
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblTotalTagihan);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvKeranjang);
            panel1.Controls.Add(btnSubmit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1919, 1095);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblTotalTagihan
            // 
            lblTotalTagihan.AutoSize = true;
            lblTotalTagihan.BackColor = Color.Transparent;
            lblTotalTagihan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTagihan.Location = new Point(441, 172);
            lblTotalTagihan.Name = "lblTotalTagihan";
            lblTotalTagihan.Size = new Size(84, 38);
            lblTotalTagihan.TabIndex = 6;
            lblTotalTagihan.Text = "Rp. 0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btnDshbrd);
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(btnDeskripsiAlat);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnRiwayatPenyewaan);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 1095);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(36, 529);
            panel5.Name = "panel5";
            panel5.Size = new Size(301, 84);
            panel5.TabIndex = 29;
            panel5.Paint += panel5_Paint;
            // 
            // btnDshbrd
            // 
            btnDshbrd.BackColor = Color.Transparent;
            btnDshbrd.BackgroundImage = (Image)resources.GetObject("btnDshbrd.BackgroundImage");
            btnDshbrd.BackgroundImageLayout = ImageLayout.Stretch;
            btnDshbrd.FlatAppearance.BorderSize = 0;
            btnDshbrd.FlatStyle = FlatStyle.Flat;
            btnDshbrd.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDshbrd.ForeColor = SystemColors.ActiveCaptionText;
            btnDshbrd.Location = new Point(36, 349);
            btnDshbrd.Name = "btnDshbrd";
            btnDshbrd.Size = new Size(301, 84);
            btnDshbrd.TabIndex = 18;
            btnDshbrd.UseVisualStyleBackColor = false;
            btnDshbrd.Click += btnDshbrd_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Transparent;
            btnProfil.BackgroundImage = (Image)resources.GetObject("btnProfil.BackgroundImage");
            btnProfil.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = SystemColors.ActiveCaptionText;
            btnProfil.Location = new Point(36, 709);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(301, 84);
            btnProfil.TabIndex = 17;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnDeskripsiAlat
            // 
            btnDeskripsiAlat.BackColor = Color.Transparent;
            btnDeskripsiAlat.BackgroundImage = (Image)resources.GetObject("btnDeskripsiAlat.BackgroundImage");
            btnDeskripsiAlat.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeskripsiAlat.FlatAppearance.BorderSize = 0;
            btnDeskripsiAlat.FlatStyle = FlatStyle.Flat;
            btnDeskripsiAlat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeskripsiAlat.ForeColor = SystemColors.ActiveCaptionText;
            btnDeskripsiAlat.Location = new Point(36, 619);
            btnDeskripsiAlat.Name = "btnDeskripsiAlat";
            btnDeskripsiAlat.Size = new Size(301, 84);
            btnDeskripsiAlat.TabIndex = 16;
            btnDeskripsiAlat.UseVisualStyleBackColor = false;
            btnDeskripsiAlat.Click += btnDeskripsiAlat_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(37, 934);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(301, 84);
            btnLogout.TabIndex = 14;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRiwayatPenyewaan
            // 
            btnRiwayatPenyewaan.BackColor = Color.Transparent;
            btnRiwayatPenyewaan.BackgroundImage = (Image)resources.GetObject("btnRiwayatPenyewaan.BackgroundImage");
            btnRiwayatPenyewaan.BackgroundImageLayout = ImageLayout.Stretch;
            btnRiwayatPenyewaan.FlatAppearance.BorderSize = 0;
            btnRiwayatPenyewaan.FlatStyle = FlatStyle.Flat;
            btnRiwayatPenyewaan.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRiwayatPenyewaan.ForeColor = SystemColors.ActiveCaptionText;
            btnRiwayatPenyewaan.Location = new Point(36, 439);
            btnRiwayatPenyewaan.Name = "btnRiwayatPenyewaan";
            btnRiwayatPenyewaan.Size = new Size(301, 84);
            btnRiwayatPenyewaan.TabIndex = 13;
            btnRiwayatPenyewaan.UseVisualStyleBackColor = false;
            btnRiwayatPenyewaan.Click += btnRiwayatPenyewaan_Click;
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.BackgroundColor = SystemColors.Control;
            dgvKeranjang.BorderStyle = BorderStyle.None;
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeranjang.Location = new Point(441, 216);
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.RowHeadersWidth = 51;
            dgvKeranjang.Size = new Size(1377, 802);
            dgvKeranjang.TabIndex = 3;
            dgvKeranjang.CellContentClick += dgvKeranjang_CellContentClick;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Silver;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Location = new Point(1615, 161);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(171, 49);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // V_keranjangCust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1919, 1095);
            Controls.Add(panel1);
            Name = "V_keranjangCust";
            Text = "V_keranjangCust";
            Load += V_keranjangCust_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSubmit;
        private DataGridView dgvKeranjang;
        private Panel panel2;
        private Button btnDshbrd;
        private Button btnProfil;
        private Button btnDeskripsiAlat;
        private Button btnLogout;
        private Button btnRiwayatPenyewaan;
        private Label lblTotalTagihan;
        private Label label1;
        private Panel panel5;
    }
}