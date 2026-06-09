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
            panel1 = new Panel();
            textBox4 = new TextBox();
            label6 = new Label();
            btnKeranjang = new Button();
            btnLanjut = new Button();
            tbStoktersedia = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            tb = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tb);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnKeranjang);
            panel1.Controls.Add(btnLanjut);
            panel1.Controls.Add(tbStoktersedia);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 452);
            panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(232, 217);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "YYYY-MM-DD";
            textBox4.Size = new Size(249, 34);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 263);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 12;
            label6.Text = "Lama Penyewaan";
            // 
            // btnKeranjang
            // 
            btnKeranjang.Location = new Point(313, 343);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(168, 42);
            btnKeranjang.TabIndex = 11;
            btnKeranjang.Text = "Keranjang";
            btnKeranjang.UseVisualStyleBackColor = true;
            btnKeranjang.Click += button1_Click_1;
            // 
            // btnLanjut
            // 
            btnLanjut.Location = new Point(515, 343);
            btnLanjut.Name = "btnLanjut";
            btnLanjut.Size = new Size(168, 42);
            btnLanjut.TabIndex = 10;
            btnLanjut.Text = "Lanjut";
            btnLanjut.UseVisualStyleBackColor = true;
            btnLanjut.Click += button1_Click;
            // 
            // tbStoktersedia
            // 
            tbStoktersedia.Location = new Point(232, 177);
            tbStoktersedia.Multiline = true;
            tbStoktersedia.Name = "tbStoktersedia";
            tbStoktersedia.Size = new Size(249, 34);
            tbStoktersedia.TabIndex = 8;
            tbStoktersedia.TextChanged += tbStoktersedia_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(232, 127);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 34);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 83);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 34);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 34);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 220);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 4;
            label5.Text = "Mulai Penyewaan";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 180);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Stok Tersedia";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 130);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 2;
            label3.Text = "Qty Penyewaan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 86);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Harga";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama Alat";
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // tb
            // 
            tb.BorderStyle = BorderStyle.None;
            tb.Location = new Point(232, 260);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.PlaceholderText = "YYYY-MM-DD";
            tb.Size = new Size(249, 34);
            tb.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(28, 240);
            label7.Name = "label7";
            label7.Size = new Size(164, 17);
            label7.TabIndex = 15;
            label7.Text = "*minimal penyewaan 3 hari";
            label7.Click += label7_Click;
            // 
            // V_popupBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "V_popupBarang";
            Text = "V_popupBarang_cs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private TextBox tbStoktersedia;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnLanjut;
        private Button btnKeranjang;
        private TextBox textBox4;
        private Label label6;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private TextBox tb;
        private Label label7;
    }
}