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
            tbNoTelp = new TextBox();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            panel2 = new Panel();
            btnSimpan = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tbNoTelp);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // tbNoTelp
            // 
            tbNoTelp.BackColor = Color.Moccasin;
            tbNoTelp.BorderStyle = BorderStyle.None;
            tbNoTelp.Location = new Point(214, 265);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(205, 20);
            tbNoTelp.TabIndex = 25;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.Moccasin;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Location = new Point(214, 211);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(205, 20);
            tbEmail.TabIndex = 24;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.Moccasin;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Location = new Point(214, 144);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(205, 20);
            tbUsername.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnSimpan);
            panel2.Location = new Point(373, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 57);
            panel2.TabIndex = 22;
            // 
            // btnSimpan
            // 
            btnSimpan.BackgroundImage = (Image)resources.GetObject("btnSimpan.BackgroundImage");
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.ButtonHighlight;
            btnSimpan.Image = (Image)resources.GetObject("btnSimpan.Image");
            btnSimpan.Location = new Point(101, 0);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(234, 61);
            btnSimpan.TabIndex = 11;
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
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
        private Button btnSimpan;
        private TextBox tbUsername;
        private TextBox tbNoTelp;
        private TextBox tbEmail;
    }
}