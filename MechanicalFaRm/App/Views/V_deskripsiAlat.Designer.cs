namespace MechanicalFaRm.App.Views
{
    partial class V_deskripsiAlat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_deskripsiAlat));
            panel1 = new Panel();
            panel4 = new Panel();
            btnTambahAlat = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            btnKelolaCust = new Button();
            btnRiwayatPenyewaan = new Button();
            btnProfil = new Button();
            btnLogout = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1870, 1022);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTambahAlat);
            panel4.Location = new Point(453, 173);
            panel4.Name = "panel4";
            panel4.Size = new Size(771, 57);
            panel4.TabIndex = 2;
            // 
            // btnTambahAlat
            // 
            btnTambahAlat.Location = new Point(15, 3);
            btnTambahAlat.Name = "btnTambahAlat";
            btnTambahAlat.Size = new Size(147, 51);
            btnTambahAlat.TabIndex = 0;
            btnTambahAlat.Text = "Tambah";
            btnTambahAlat.UseVisualStyleBackColor = true;
            btnTambahAlat.Click += btnTambahAlat_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(btnKelolaCust);
            panel3.Controls.Add(btnRiwayatPenyewaan);
            panel3.Controls.Add(btnProfil);
            panel3.Controls.Add(btnLogout);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(378, 1022);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(36, 529);
            panel5.Name = "panel5";
            panel5.Size = new Size(301, 84);
            panel5.TabIndex = 27;
            panel5.Paint += panel5_Paint;
            // 
            // btnKelolaCust
            // 
            btnKelolaCust.BackColor = Color.Transparent;
            btnKelolaCust.BackgroundImage = (Image)resources.GetObject("btnKelolaCust.BackgroundImage");
            btnKelolaCust.BackgroundImageLayout = ImageLayout.Stretch;
            btnKelolaCust.FlatAppearance.BorderSize = 0;
            btnKelolaCust.FlatStyle = FlatStyle.Flat;
            btnKelolaCust.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKelolaCust.ForeColor = SystemColors.ActiveCaptionText;
            btnKelolaCust.Location = new Point(36, 349);
            btnKelolaCust.Name = "btnKelolaCust";
            btnKelolaCust.Size = new Size(301, 84);
            btnKelolaCust.TabIndex = 26;
            btnKelolaCust.UseVisualStyleBackColor = false;
            btnKelolaCust.Click += btnKelolaCust_Click;
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
            btnRiwayatPenyewaan.TabIndex = 25;
            btnRiwayatPenyewaan.UseVisualStyleBackColor = false;
            btnRiwayatPenyewaan.Click += btnRiwayatPenyewaan_Click;
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
            btnProfil.Location = new Point(36, 619);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(301, 84);
            btnProfil.TabIndex = 23;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
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
            btnLogout.TabIndex = 22;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Location = new Point(436, 236);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1425, 732);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 346);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // V_deskripsiAlat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1870, 1022);
            Controls.Add(panel1);
            Name = "V_deskripsiAlat";
            Text = "V_deskripsiAlat";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnKelolaCust;
        private Button btnRiwayatPenyewaan;
        private Button btnProfil;
        private Button btnLogout;
        private Panel panel4;
        private Button btnTambahAlat;
        private Panel panel5;
    }
}