using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Service;
using MechanicalFaRm.App.Session;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class UC_Pembayaran : UserControl
    {
        private S_KeranjangService _serviceker = new S_KeranjangService();
        private C_PesananController _pesananControll = new C_PesananController();
        private Action _callbackRefreshHalaman;
        private List<M_Keranjang> _listPesananFinal;

        bool _isDariKeranjang;

        public UC_Pembayaran(List<M_Keranjang> listPesanan, Action callbackRefresh, bool isDariKeranjang)
        {
            InitializeComponent();

            _isDariKeranjang = isDariKeranjang;
            _listPesananFinal = listPesanan;
            _callbackRefreshHalaman = callbackRefresh;  

            cbMetodeBayar.Items.Clear();
            cbMetodeBayar.Items.Add("Transfer Bank BCA");
            cbMetodeBayar.Items.Add("Scan QRIS (E-Wallet)");
            cbMetodeBayar.SelectedIndex = 0;
            cbMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;



            // Setup Data Label Atas
            lblIdPesanan.Text = "ID Pemesanan: (Menunggu Konfirmasi)";
            lblTanggal.Text = $"Tanggal: {DateTime.Now:dd MMMM yyyy}";

            string nama = listPesanan.Count > 0 && listPesanan[0].Penyewa != null
                          ? listPesanan[0].Penyewa.namaPenyewa
                          : "Penyewa";
            lblNamaPenyewa.Text = $"Penyewa: {nama}";

            tbNamaJalan.Text = "";

            decimal totalKeseluruhan = 0;

            foreach (var item in listPesanan)
            {
                int durasi = (item.tglKembali - item.tglSewa).Days;
                if (durasi <= 0) durasi = 3;

                decimal subTotal = (decimal)item.hargaSewa * item.jumlah * durasi;
                totalKeseluruhan += subTotal;

                Label lblItem = new Label();

                string tglMulai = item.tglSewa.ToString("dd MMM yyyy");
                string tglSelesai = item.tglKembali.ToString("dd MMM yyyy");

                lblItem.Text = $"• {item.namaBarang}  x{item.jumlah} Unit\n   (Durasi: {durasi} Hari | {tglMulai} - {tglSelesai})";

                lblItem.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
                lblItem.ForeColor = Color.Black;
                lblItem.AutoSize = true;
                lblItem.Margin = new Padding(5, 5, 5, 10); 

                flpBarangSewa.Controls.Add(lblItem);
            }

            // Setup Total Harga Bawah
            lblTotalHarga.Text = string.Format("Total: Rp{0:N0} Juta", totalKeseluruhan);

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            string inputJalan = tbNamaJalan.Text.Trim();

            // Validasi Alamat
            if (string.IsNullOrWhiteSpace(inputJalan))
            {
                MessageBox.Show("Nama jalan wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNamaJalan.Focus();
                return;
            }

            string metodeTerpilih = cbMetodeBayar.SelectedItem.ToString();
            //DialogResult konfirmasi = MessageBox.Show($"Apakah Anda yakin ingin menyelesaikan transaksi via {metodeTerpilih}?",
            //                                           "Konfirmasi Pembayaran",
            //                                           MessageBoxButtons.YesNo,
            //                                           MessageBoxIcon.Question);


            //if (konfirmasi == DialogResult.Yes) return;

            int idUser = SE_userSession.id_user;
            string hasil = _pesananControll.ProsesCo(idUser, inputJalan, metodeTerpilih, _listPesananFinal);

            if (hasil.Equals("Sukses", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Pembayaran sukses!",
                                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_isDariKeranjang)
                {
                _serviceker.ClearKeranjang(idUser);

                }
                _callbackRefreshHalaman?.Invoke();

                var formInduk = this.FindForm();
                if (formInduk != null && formInduk.Name == "V_pembayaran")
                {
                    formInduk.Close();
                }
                }
                else
                {
                    MessageBox.Show(hasil, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void cbMetodeBayar_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblTotalHarga_Click(object sender, EventArgs e) { }

        private void flpBarangSewa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Pembayaran_Load(object sender, EventArgs e)
        {

        }
    }
}