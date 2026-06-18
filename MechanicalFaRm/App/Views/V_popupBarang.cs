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


        private void EksekusiSimpan(bool isInstantCheckout)
        {
            if (string.IsNullOrWhiteSpace(tbNamaPenyewa.Text))
            {
                MessageBox.Show("Invalid!! Nama penyewa harus diisi. Mohon diisi kembali.",
                                "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int qty = int.TryParse(tbQty.Text, out qty) ? qty : 0;
            if (qty <= 0)
            {
                MessageBox.Show("Jumlah yang disewa minimal harus 1 unit!", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var stok = 0;
            int.TryParse(lblStokAlat.Text, out stok);
            if (stok < qty)
            {
                MessageBox.Show("Invalid!! Stok yang ingin dipesan tidak tersedia. Mohon dipertimbangkan lagi", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Box Konfirmasi
            string pesanKotak = isInstantCheckout ? "Apakah Anda yakin ingin langsung memproses pesanan ini?" : "Masukkan ke keranjang?";
            DialogResult konfirmasi = MessageBox.Show(pesanKotak, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                M_user namaUser = new M_user() { namaPenyewa = tbNamaPenyewa.Text };
                var hargaBarang = 0;
                int.TryParse(lblHargaAlat.Text, out hargaBarang);

                DataKeranjangBaru = new M_Keranjang
                {
                    id_barang = idBarang,
                    namaBarang = lblNamaAlat.Text,
                    jumlah = qty,
                    tglSewa = dtpSewa.Value.Date,
                    tglKembali = dtpKembali.Value.Date,
                    hargaSewa = hargaBarang,
                    stok = stok,
                    Penyewa = namaUser
                };

                string status = pesananService.AddToKeranjang(DataKeranjangBaru);

                if (status.ToLower() == "sukses")
                {
                    if (isInstantCheckout)
                    {
                        C_PesananController pesananControll = new C_PesananController();
                        int idUserYangLogin = SE_userSession.id_user;

                        string hasilCheckout = pesananControll.ProsesInstantCo(DataKeranjangBaru, idUserYangLogin);

                        if (hasilCheckout == "Sukses")
                        {
                            MessageBox.Show("Pesanan berhasil dibuat secara langsung! Silakan lakukan pembayaran.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (parentForm != null) parentForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(hasilCheckout, "Peringatan Sistem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Berhasil menambahkan data ke keranjang", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (parentForm != null) parentForm.Show();
                        this.Close();
                    }
                }
            }
        }
        private void btnLanjut_Click(object sender, EventArgs e)
        {
            EksekusiSimpan(isInstantCheckout: true);
        }
        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            EksekusiSimpan(isInstantCheckout: false);
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
