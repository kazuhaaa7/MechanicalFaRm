namespace MechanicalFaRm.App.Views
{
    partial class V_riwayatPenyewaanCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_riwayatPenyewaanCust));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            btnDshbrd = new Button();
            btnProfil = new Button();
            btnDeskripsiAlat = new Button();
            btnKeranjang = new Button();
            btnLogout = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1919, 1095);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 1095);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(btnDshbrd);
            panel3.Controls.Add(btnProfil);
            panel3.Controls.Add(btnDeskripsiAlat);
            panel3.Controls.Add(btnKeranjang);
            panel3.Controls.Add(btnLogout);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(376, 1095);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(38, 415);
            panel5.Name = "panel5";
            panel5.Size = new Size(301, 84);
            panel5.TabIndex = 34;
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
            btnDshbrd.Location = new Point(38, 325);
            btnDshbrd.Name = "btnDshbrd";
            btnDshbrd.Size = new Size(301, 84);
            btnDshbrd.TabIndex = 33;
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
            btnProfil.Location = new Point(38, 685);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(301, 84);
            btnProfil.TabIndex = 32;
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
            btnDeskripsiAlat.Location = new Point(38, 595);
            btnDeskripsiAlat.Name = "btnDeskripsiAlat";
            btnDeskripsiAlat.Size = new Size(301, 84);
            btnDeskripsiAlat.TabIndex = 31;
            btnDeskripsiAlat.UseVisualStyleBackColor = false;
            btnDeskripsiAlat.Click += btnDeskripsiAlat_Click;
            // 
            // btnKeranjang
            // 
            btnKeranjang.BackColor = Color.Transparent;
            btnKeranjang.BackgroundImage = (Image)resources.GetObject("btnKeranjang.BackgroundImage");
            btnKeranjang.BackgroundImageLayout = ImageLayout.Stretch;
            btnKeranjang.FlatAppearance.BorderSize = 0;
            btnKeranjang.FlatStyle = FlatStyle.Flat;
            btnKeranjang.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKeranjang.ForeColor = SystemColors.ActiveCaptionText;
            btnKeranjang.Location = new Point(38, 505);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(301, 84);
            btnKeranjang.TabIndex = 30;
            btnKeranjang.UseVisualStyleBackColor = false;
            btnKeranjang.Click += btnKeranjang_Click;
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
            btnLogout.TabIndex = 26;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(447, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1400, 806);
            dataGridView1.TabIndex = 1;
            // 
            // V_riwayatPenyewaanCust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1919, 1095);
            Controls.Add(panel1);
            Name = "V_riwayatPenyewaanCust";
            Text = "V_riwayatPembelian";
            Load += V_riwayatPembelian_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private Button btnKeranjang;
        private Button btnDshbrd;
        private Button btnLogout;
        private Panel panel5;
        private Button btnProfil;
        private Button btnDeskripsiAlat;
    }
}