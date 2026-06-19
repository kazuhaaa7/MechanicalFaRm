namespace MechanicalFaRm.App.Views
{
    partial class V_deskripsiAlatCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_deskripsiAlatCust));
            panel1 = new Panel();
            panelRingkasan = new Panel();
            flp1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(flp1);
            panel1.Controls.Add(panelRingkasan);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 1082);
            panel1.TabIndex = 0;
            // 
            // panelRingkasan
            // 
            panelRingkasan.Location = new Point(439, 164);
            panelRingkasan.Name = "panelRingkasan";
            panelRingkasan.Size = new Size(504, 862);
            panelRingkasan.TabIndex = 0;
            // 
            // flp1
            // 
            flp1.Location = new Point(973, 164);
            flp1.Name = "flp1";
            flp1.Size = new Size(883, 851);
            flp1.TabIndex = 2;
            // 
            // V_deskripsiAlatCust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1082);
            Controls.Add(panel1);
            Name = "V_deskripsiAlatCust";
            Text = "V_deskripsiAlatCust";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelRingkasan;
        private FlowLayoutPanel flp1;
    }
}