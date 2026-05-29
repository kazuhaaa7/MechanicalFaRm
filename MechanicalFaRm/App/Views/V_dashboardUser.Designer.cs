namespace MechanicalFaRm.App.Views
{
    partial class V_dashboardUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_dashboardUser));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            button5 = new Button();
            panel3 = new Panel();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 901);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(78, 473);
            button4.Name = "button4";
            button4.Size = new Size(207, 43);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(78, 398);
            button3.Name = "button3";
            button3.Size = new Size(207, 46);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(78, 337);
            button2.Name = "button2";
            button2.Size = new Size(207, 43);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button5);
            panel2.Location = new Point(498, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 307);
            panel2.TabIndex = 2;
            // 
            // button5
            // 
            button5.Location = new Point(31, 30);
            button5.Name = "button5";
            button5.Size = new Size(314, 242);
            button5.TabIndex = 0;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(button6);
            panel3.Location = new Point(498, 618);
            panel3.Name = "panel3";
            panel3.Size = new Size(382, 296);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // button6
            // 
            button6.Location = new Point(29, 13);
            button6.Name = "button6";
            button6.Size = new Size(328, 266);
            button6.TabIndex = 0;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // V_dashboardUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1864, 901);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "V_dashboardUser";
            Text = "dashboardUser";
            Load += V_dashboardUser_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private Button button5;
        private Panel panel3;
        private Button button6;
    }
}