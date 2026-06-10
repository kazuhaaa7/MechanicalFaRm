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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            btnLogout = new Button();
            btnDeskripsiAlat = new Button();
            btnProfile = new Button();
            btnHistoriPenyewaan = new Button();
            btnKelolaAkun = new Button();
            btnKelolaAlat = new Button();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1940, 1092);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1619, 1063);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btnDeskripsiAlat);
            panel3.Controls.Add(btnProfile);
            panel3.Controls.Add(btnHistoriPenyewaan);
            panel3.Controls.Add(btnKelolaAkun);
            panel3.Controls.Add(btnKelolaAlat);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(315, 1063);
            panel3.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkGray;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(9, 729);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(302, 67);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDeskripsiAlat
            // 
            btnDeskripsiAlat.BackColor = Color.DarkGray;
            btnDeskripsiAlat.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeskripsiAlat.FlatAppearance.BorderSize = 0;
            btnDeskripsiAlat.FlatStyle = FlatStyle.Flat;
            btnDeskripsiAlat.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeskripsiAlat.ForeColor = SystemColors.ActiveCaptionText;
            btnDeskripsiAlat.Location = new Point(10, 656);
            btnDeskripsiAlat.Name = "btnDeskripsiAlat";
            btnDeskripsiAlat.Size = new Size(302, 67);
            btnDeskripsiAlat.TabIndex = 5;
            btnDeskripsiAlat.Text = "Deskripsi Alat";
            btnDeskripsiAlat.UseVisualStyleBackColor = false;
            btnDeskripsiAlat.Click += btnDeskripsiAlat_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.DarkGray;
            btnProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = SystemColors.ActiveCaptionText;
            btnProfile.Location = new Point(9, 583);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(302, 67);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnHistoriPenyewaan
            // 
            btnHistoriPenyewaan.BackColor = Color.DarkGray;
            btnHistoriPenyewaan.BackgroundImageLayout = ImageLayout.Stretch;
            btnHistoriPenyewaan.FlatAppearance.BorderSize = 0;
            btnHistoriPenyewaan.FlatStyle = FlatStyle.Flat;
            btnHistoriPenyewaan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHistoriPenyewaan.ForeColor = SystemColors.ActiveCaptionText;
            btnHistoriPenyewaan.Location = new Point(9, 510);
            btnHistoriPenyewaan.Name = "btnHistoriPenyewaan";
            btnHistoriPenyewaan.Size = new Size(302, 67);
            btnHistoriPenyewaan.TabIndex = 3;
            btnHistoriPenyewaan.Text = "Kelola Histori Sewa";
            btnHistoriPenyewaan.UseVisualStyleBackColor = false;
            // 
            // btnKelolaAkun
            // 
            btnKelolaAkun.BackColor = Color.DarkGray;
            btnKelolaAkun.BackgroundImageLayout = ImageLayout.Stretch;
            btnKelolaAkun.FlatAppearance.BorderSize = 0;
            btnKelolaAkun.FlatStyle = FlatStyle.Flat;
            btnKelolaAkun.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKelolaAkun.ForeColor = SystemColors.ActiveCaptionText;
            btnKelolaAkun.Location = new Point(10, 437);
            btnKelolaAkun.Name = "btnKelolaAkun";
            btnKelolaAkun.Size = new Size(302, 67);
            btnKelolaAkun.TabIndex = 2;
            btnKelolaAkun.Text = "Kelola Akun";
            btnKelolaAkun.UseVisualStyleBackColor = false;
            btnKelolaAkun.Click += button4_Click;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.BackColor = Color.DarkGray;
            btnKelolaAlat.BackgroundImageLayout = ImageLayout.Stretch;
            btnKelolaAlat.FlatAppearance.BorderSize = 0;
            btnKelolaAlat.FlatStyle = FlatStyle.Flat;
            btnKelolaAlat.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKelolaAlat.ForeColor = SystemColors.ActiveCaptionText;
            btnKelolaAlat.Location = new Point(9, 364);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(302, 67);
            btnKelolaAlat.TabIndex = 1;
            btnKelolaAlat.Text = "Kelola Alat";
            btnKelolaAlat.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(371, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(1192, 73);
            panel2.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(400, 5);
            button3.Name = "button3";
            button3.Size = new Size(180, 56);
            button3.TabIndex = 3;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(203, 5);
            button2.Name = "button2";
            button2.Size = new Size(180, 56);
            button2.TabIndex = 2;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(3, 5);
            button1.Name = "button1";
            button1.Size = new Size(180, 56);
            button1.TabIndex = 1;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(347, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1241, 749);
            dataGridView1.TabIndex = 0;
            // 
            // V_kelolaAkunAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 1063);
            Controls.Add(flowLayoutPanel1);
            Name = "V_kelolaAkunAdmin";
            Text = "V_kelolaAkun";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button btnKelolaAkun;
        private Button btnKelolaAlat;
        private Button btnProfile;
        private Button btnHistoriPenyewaan;
        private Button btnLogout;
        private Button btnDeskripsiAlat;
    }
}