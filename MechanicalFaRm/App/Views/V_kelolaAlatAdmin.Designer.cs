namespace MechanicalFaRm.App.Views
{
    partial class V_kelolaAlatAdmin
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 125);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1403, 719);
            panel1.TabIndex = 0;
            // 
            // V_kelolaAlatAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 689);
            Controls.Add(flowLayoutPanel1);
            Name = "V_kelolaAlatAdmin";
            Text = "V_kelolaAlatAdmin";
            Load += V_kelolaAlatAdmin_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
    }
}