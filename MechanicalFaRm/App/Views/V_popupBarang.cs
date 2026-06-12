using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_popupBarang : Form
    {
        public M_Keranjang? DataKeranjangBaru { get; private set; }
        //Form V_dashboardCust
        public int idBarang;
        private C_barangController barangController;
        public V_popupBarang()
        {
            InitializeComponent();
            //this.V_dashboardCust = induk;
            barangController = new C_barangController();

        }
        private void V_popupBarang_Load(object sender, EventArgs e)
        {
            M_barang barang = barangController.GetBarangById(idBarang);

            if (barang != null)
            {
                lblNamaAlat.Text = barang.namaBarang;
                lblHargaAlat.Text = barang.hargaSewa.ToString();
                lblStokAlat.Text = barang.stok.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void tbStoktersedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            //V_keranjangCust keranjang = new V_keranjangCust();
            //keranjang.Show();
            this.Close();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            
            //getbarang yg bisa menambhakan ke class keranjang
            
            int qty = int.TryParse(tbQty.Text, out qty) ? qty : 0;
            DateTime tglSewa = dtpSewa.Value.Date;
            DateTime tglKembali = dtpKembali.Value.Date;
            M_user namaUser = new M_user()
            {
                namaPenyewa = tbNamaPenyewa.Text
            };

            DataKeranjangBaru = new M_Keranjang
            {
                namaBarang = lblNamaAlat.Text,
                jumlah = qty,
                tglSewa = tglSewa,
                tglKembali = tglKembali,
                Penyewa = namaUser
            };
            S_PesananService service = new S_PesananService();
            string status = service.AddToKeranjang(DataKeranjangBaru);

            if(status == "sukses")
            {
                MessageBox.Show("Berhasil menambahkan data");
            }
            //this.DialogResult = DialogResult.OK;    
            this.Close();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNamaAlat_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
