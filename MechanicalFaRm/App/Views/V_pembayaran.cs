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
        private List<M_Keranjang> _listPesananHantaran;

        public V_pembayaran(List<M_Keranjang> listPesanan, bool isDariKeranjang)
        {
            InitializeComponent();
            _listPesananHantaran = listPesanan;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Detail Pembayaran Nota";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            try
            {
                UC_Pembayaran ucBayar = new UC_Pembayaran(listPesanan, () => { this.Close(); }, isDariKeranjang);
                //ucBayar.Dock = DockStyle.Fill;
                //this.Width = ucBayar.Width + 20;
                //this.Height = ucBayar.Height + 40;


                ucBayar.Location = new Point(0, 0);

                this.ClientSize = new Size(ucBayar.Width, ucBayar.Height);

                this.Controls.Add(ucBayar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal merender form pembayaran: " + ex.Message, "Error UI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void V_pembayaran_Load_1(object sender, EventArgs e)
        {

        }
    }

}
