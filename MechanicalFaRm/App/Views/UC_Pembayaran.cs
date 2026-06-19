using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Repository;
using MechanicalFaRm.App.Service;
using MechanicalFaRm.App.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class UC_Pembayaran : UserControl
    {
        S_PesananService _servicePesanan = new S_PesananService();
        S_KeranjangService _serviceker = new S_KeranjangService();
        private Action _callbackRefreshHalaman;
        private int _idPesanan;

        public UC_Pembayaran(M_Pesanan dataPesanan, Action callbackRefresh)
        {
            InitializeComponent();

            _servicePesanan = new S_PesananService();
            _idPesanan = dataPesanan.id_pesanan;
            _callbackRefreshHalaman = callbackRefresh;

            cbMetodeBayar.Items.Clear();
            cbMetodeBayar.Items.Add("Transfer Bank BCA");
            cbMetodeBayar.Items.Add("Scan QRIS (E-Wallet)");
            cbMetodeBayar.SelectedIndex = 0; 
            cbMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList; 

            lblIdPesanan.Text = $"ID Pemesanan: #{dataPesanan.id_pesanan}";
            lblTanggal.Text = $"Tanggal: {DateTime.Now:dd MMMM yyyy}";
            lblNamaPenyewa.Text = $"Penyewa: {dataPesanan.Penyewa.namaPenyewa}";
            lblTotalHarga.Text = string.Format("Total: Rp{0:N0}", dataPesanan.total);
            if (dataPesanan.jalan != null)
            {
                tbNamaJalan.Text = dataPesanan.jalan.Jalan;
            }
            else
            {
                tbNamaJalan.Text = "Alamat tidak ditemukan";
            }
            flpBarangSewa.Controls.Clear();

            foreach (var item in dataPesanan.detailBarang)
            {
                Label lblItem = new Label();

                lblItem.Text = $"• {item.namaBarang}  x{item.jumlah} Unit";

                lblItem.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
                lblItem.ForeColor = Color.FromArgb(0, 0, 0);
                lblItem.AutoSize = true;

                lblItem.Margin = new Padding(5, 2, 5, 2);
                flpBarangSewa.Controls.Add(lblItem);
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            string inputJalan = tbNamaJalan.Text.Trim();
            if(string.IsNullOrWhiteSpace(inputJalan))
            {
                MessageBox.Show("Nama jalan wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNamaJalan.Focus(); 
                return;
            }
            string metodeTerpilih = cbMetodeBayar.SelectedItem.ToString();

            DialogResult konfirmasi = MessageBox.Show($"Apakah Anda yakin ingin membayar transaksi #{_idPesanan} via {metodeTerpilih}?",
                                                       "Konfirmasi Pembayaran",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);


            int id = SE_userSession.id_user;
            
            if (konfirmasi == DialogResult.Yes)
            {
                bool isSukses = _servicePesanan.UpdateStatusPesanan(_idPesanan, "Sudah Terverifikasi Admin", inputJalan, id);

                if (isSukses)
                {
                    MessageBox.Show("Pembayaran sukses dikonfirmasi! Data otomatis berpindah ke Riwayat.",
                                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _serviceker.ClearKeranjang(id);
                    _callbackRefreshHalaman?.Invoke();

                }
                else
                {
                    MessageBox.Show("Gagal terhubung ke server database untuk memperbarui status.", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbMetodeBayar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalHarga_Click(object sender, EventArgs e)
        {

        }
    }
}
