using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_popupBarang : Form
    {
        //Form V_dashboardCust
        public V_popupBarang()
        {
            InitializeComponent();
            //this.V_dashboardCust = induk;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void tbStoktersedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            V_keranjangCust keranjang = new V_keranjangCust();
            keranjang.Show();
            this.Hide();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alat berhasil ditambahkan ke keranjang.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //getbarang yg bisa menambhakan ke class keranjang
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
