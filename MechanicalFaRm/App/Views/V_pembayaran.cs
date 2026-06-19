using MechanicalFaRm.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_pembayaran : Form
    {
        public V_pembayaran(M_Pesanan pesananTerbaru)
        {
            InitializeComponent();
            if (pesananTerbaru == null)
            {
                MessageBox.Show("Sistem gagal menarik data transaksi terbaru dari database PostgreSQL.",
                                "Debug Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Detail Pembayaran Nota";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

           
            UC_Pembayaran ucBayar = new UC_Pembayaran(pesananTerbaru, () => { this.Close(); });
            ucBayar.Dock = DockStyle.Fill;
            this.Width = ucBayar.Width + 20;  
            this.Height = ucBayar.Height + 40;

            this.Controls.Add(ucBayar);
        }
    }
}
