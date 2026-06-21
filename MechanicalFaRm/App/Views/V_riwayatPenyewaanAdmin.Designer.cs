namespace MechanicalFaRm.App.Views
{
    partial class V_riwayatPenyewaanAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_riwayatPenyewaanAdmin));
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            btnKelolaCustomer = new Button();
            btnProfil = new Button();
            btnDeskripsiAlat = new Button();
            btnLogout = new Button();
            dgvKelolaSewa = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKelolaSewa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvKelolaSewa);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 1082);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btnKelolaCustomer);
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(btnDeskripsiAlat);
            panel2.Controls.Add(btnLogout);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 1082);
            panel2.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(39, 454);
            panel5.Name = "panel5";
            panel5.Size = new Size(301, 84);
            panel5.TabIndex = 44;
            panel5.Paint += panel5_Paint;
            // 
            // btnKelolaCustomer
            // 
            btnKelolaCustomer.BackColor = Color.Transparent;
            btnKelolaCustomer.BackgroundImage = (Image)resources.GetObject("btnKelolaCustomer.BackgroundImage");
            btnKelolaCustomer.BackgroundImageLayout = ImageLayout.Stretch;
            btnKelolaCustomer.FlatAppearance.BorderSize = 0;
            btnKelolaCustomer.FlatStyle = FlatStyle.Flat;
            btnKelolaCustomer.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKelolaCustomer.ForeColor = SystemColors.ActiveCaptionText;
            btnKelolaCustomer.Location = new Point(39, 364);
            btnKelolaCustomer.Name = "btnKelolaCustomer";
            btnKelolaCustomer.Size = new Size(301, 84);
            btnKelolaCustomer.TabIndex = 43;
            btnKelolaCustomer.UseVisualStyleBackColor = false;
            btnKelolaCustomer.Click += btnKelolaCustomer_Click;
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
            btnProfil.Location = new Point(39, 634);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(301, 84);
            btnProfil.TabIndex = 42;
            btnProfil.UseVisualStyleBackColor = false;
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
            btnDeskripsiAlat.Location = new Point(39, 544);
            btnDeskripsiAlat.Name = "btnDeskripsiAlat";
            btnDeskripsiAlat.Size = new Size(301, 84);
            btnDeskripsiAlat.TabIndex = 41;
            btnDeskripsiAlat.UseVisualStyleBackColor = false;
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
            btnLogout.TabIndex = 27;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvKelolaSewa
            // 
            dgvKelolaSewa.BackgroundColor = Color.White;
            dgvKelolaSewa.BorderStyle = BorderStyle.None;
            dgvKelolaSewa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKelolaSewa.Location = new Point(436, 207);
            dgvKelolaSewa.Name = "dgvKelolaSewa";
            dgvKelolaSewa.RowHeadersWidth = 51;
            dgvKelolaSewa.Size = new Size(1430, 817);
            dgvKelolaSewa.TabIndex = 3;
            // 
            // V_riwayatPenyewaanAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1082);
            Controls.Add(panel1);
            Name = "V_riwayatPenyewaanAdmin";
            Text = "V_riwayatPenyewaanAdmin";
            Load += V_riwayatPenyewaanAdmin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKelolaSewa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvKelolaAlat;
        private Panel panel2;
        private Button btnKelolaCust;
        private Button btnLogout;
        private DataGridView dgvKelolaSewa;
        private Panel panel5;
        private Panel panel3;
        private Button btnRiwayatPenyewaan;
        private Button btnProfil;
        private Button btnDeskripsiAlat;
        private Button btnKelolaCustomer;
    }
}