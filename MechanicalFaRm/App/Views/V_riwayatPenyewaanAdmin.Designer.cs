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
            btnKelolaCust = new Button();
            btnKelolaAlat = new Button();
            btnDeskripsiAlat = new Button();
            btnProfil = new Button();
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
            panel2.Controls.Add(btnKelolaCust);
            panel2.Controls.Add(btnKelolaAlat);
            panel2.Controls.Add(btnDeskripsiAlat);
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(btnLogout);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 1082);
            panel2.TabIndex = 4;
            // 
            // btnKelolaCust
            // 
            btnKelolaCust.BackColor = Color.Transparent;
            btnKelolaCust.FlatAppearance.BorderSize = 0;
            btnKelolaCust.FlatStyle = FlatStyle.Flat;
            btnKelolaCust.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKelolaCust.ForeColor = SystemColors.ActiveCaptionText;
            btnKelolaCust.Location = new Point(42, 430);
            btnKelolaCust.Name = "btnKelolaCust";
            btnKelolaCust.Size = new Size(288, 67);
            btnKelolaCust.TabIndex = 31;
            btnKelolaCust.UseVisualStyleBackColor = false;
            btnKelolaCust.Click += btnKelolaCust_Click;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.BackColor = Color.Transparent;
            btnKelolaAlat.FlatAppearance.BorderSize = 0;
            btnKelolaAlat.FlatStyle = FlatStyle.Flat;
            btnKelolaAlat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKelolaAlat.ForeColor = SystemColors.ActiveCaptionText;
            btnKelolaAlat.Location = new Point(42, 331);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(288, 67);
            btnKelolaAlat.TabIndex = 30;
            btnKelolaAlat.UseVisualStyleBackColor = false;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
            // 
            // btnDeskripsiAlat
            // 
            btnDeskripsiAlat.BackColor = Color.Transparent;
            btnDeskripsiAlat.FlatAppearance.BorderSize = 0;
            btnDeskripsiAlat.FlatStyle = FlatStyle.Flat;
            btnDeskripsiAlat.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDeskripsiAlat.ForeColor = SystemColors.ActiveCaptionText;
            btnDeskripsiAlat.Location = new Point(42, 644);
            btnDeskripsiAlat.Name = "btnDeskripsiAlat";
            btnDeskripsiAlat.Size = new Size(288, 67);
            btnDeskripsiAlat.TabIndex = 29;
            btnDeskripsiAlat.UseVisualStyleBackColor = false;
            btnDeskripsiAlat.Click += btnDeskripsiAlat_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Transparent;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = SystemColors.ActiveCaptionText;
            btnProfil.Location = new Point(42, 749);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(288, 67);
            btnProfil.TabIndex = 28;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ActiveCaptionText;
            btnLogout.Location = new Point(42, 982);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(288, 63);
            btnLogout.TabIndex = 27;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvKelolaSewa
            // 
            dgvKelolaSewa.BackgroundColor = SystemColors.Control;
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
        private Button btnKelolaAlat;
        private Button btnDeskripsiAlat;
        private Button btnProfil;
        private Button btnLogout;
        private DataGridView dgvKelolaSewa;
    }
}