namespace MechanicalFaRm.App.Views
{
    partial class V_editProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_editProfile));
            panel1 = new Panel();
            panel2 = new Panel();
            btnLanjut = new Button();
            btnKeranjang = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnLanjut);
            panel2.Controls.Add(btnKeranjang);
            panel2.Location = new Point(373, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 57);
            panel2.TabIndex = 22;
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
            btnLanjut.Size = new Size(168, 42);
            btnLanjut.TabIndex = 10;
            btnLanjut.Text = "Lanjut";
            btnLanjut.UseVisualStyleBackColor = false;
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
            btnKeranjang.Size = new Size(168, 42);
            btnKeranjang.TabIndex = 11;
            btnKeranjang.Text = "Keranjang";
            btnKeranjang.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Moccasin;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(214, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 20);
            textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Moccasin;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(214, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 20);
            textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Moccasin;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(214, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 20);
            textBox3.TabIndex = 25;
            // 
            // V_editProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "V_editProfile";
            Text = "V_editProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnLanjut;
        private Button btnKeranjang;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}