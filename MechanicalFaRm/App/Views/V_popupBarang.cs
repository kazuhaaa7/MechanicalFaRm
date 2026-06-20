using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Service;
using MechanicalFaRm.App.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_popupBarang : Form
    {
        public M_Keranjang? DataKeranjangBaru { get; private set; }
        private V_dashboardCust parentForm;
        public int idBarang;
        private C_barangController barangController;
        private S_PesananService pesananService;
        public V_popupBarang(V_dashboardCust parernt ,int idbarang)
        {
            InitializeComponent();
            parentForm = parernt;
            pesananService = new S_PesananService();
            barangController = new C_barangController();
            idBarang = idbarang;

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

            int idUserYangLogin = SE_userSession.id_user;
            string namaTerdaftar = pesananService.GetNamaPenyewaLama(idUserYangLogin);


            if (!string.IsNullOrWhiteSpace(namaTerdaftar))
            {
                tbNamaPenyewa.Text = namaTerdaftar;
                tbNamaPenyewa.ReadOnly = true;
                tbNamaPenyewa.TextAlign = HorizontalAlignment.Center;
                tbNamaPenyewa.BorderStyle = BorderStyle.None;
                tbNamaPenyewa.BackColor = Color.Moccasin;

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
            if (string.IsNullOrWhiteSpace(tbNamaPenyewa.Text))
            {
                MessageBox.Show("Invalid!! Nama penyewa harus diisi. Mohon diisi kembali.",
                                "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Jumlah yang disewa minimal harus 1 unit!", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(lblStokAlat.Text, out int stok);
            if (stok < qty)
            {
                MessageBox.Show("Invalid!! Stok yang ingin dipesan tidak tersedia. Mohon dipertimbangkan lagi", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin langsung memproses pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi != DialogResult.Yes) return;
            int.TryParse(lblHargaAlat.Text, out int hargaBarang);
            M_Keranjang dataKeranjangBaru = new M_Keranjang
            {
                id_barang = this.idBarang,
                namaBarang = lblNamaAlat.Text,
                jumlah = qty,
                tglSewa = dtpSewa.Value.Date,
                tglKembali = dtpKembali.Value.Date,
                hargaSewa = hargaBarang,
                stok = stok,
                Penyewa = new M_user() {
                    _id_user = SE_userSession.id_user,
                    namaPenyewa = tbNamaPenyewa.Text }
            };


            List<M_Keranjang> listPopUp = new List<M_Keranjang> { dataKeranjangBaru };

            using (V_pembayaran formBayar = new V_pembayaran(listPopUp, false))
            {
                this.Hide();
                formBayar.ShowDialog();
            }
        }
        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNamaPenyewa.Text))
            {
                MessageBox.Show("Invalid!! Nama penyewa harus diisi. Mohon diisi kembali.",
                                "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Jumlah yang disewa minimal harus 1 unit!", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(lblStokAlat.Text, out int stok);
            if (stok < qty)
            {
                MessageBox.Show("Invalid!! Stok yang ingin dipesan tidak tersedia. Mohon dipertimbangkan lagi", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int.TryParse(lblHargaAlat.Text, out int hargaBarang);
            TimeSpan durasiSpan = dtpKembali.Value.Date - dtpSewa.Value.Date;
            int jumlahHari = durasiSpan.Days;

            var totalBayar = (decimal)hargaBarang * qty * jumlahHari;
            M_Keranjang dataKeranjangBaru = new M_Keranjang
            {
                id_barang = idBarang,
                namaBarang = lblNamaAlat.Text,
                jumlah = qty,
                tglSewa = dtpSewa.Value.Date,
                tglKembali = dtpKembali.Value.Date,
                hargaSewa = hargaBarang,
                stok = stok,
                total = totalBayar,
                Penyewa = new M_user() {
                    _id_user = SE_userSession.id_user,
                    namaPenyewa = tbNamaPenyewa.Text }
            };

            // 4. Proses Tambah Keranjang
            string status = pesananService.AddToKeranjang(dataKeranjangBaru);

            if (string.Equals(status, "sukses", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Berhasil menambahkan data ke keranjang", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (parentForm != null) parentForm.Show();
                this.Close();
            }
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

        private void tbNamaPenyewa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
