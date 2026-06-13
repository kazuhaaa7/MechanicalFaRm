using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_keranjangCust : Form
    {
        private S_PesananService _servicePesanan;
        public V_keranjangCust()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _servicePesanan = new S_PesananService();
            RefreshData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvKelolaAlat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void V_keranjangCust_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var isiKeranjang = _servicePesanan.GetListKeranjang();
            DataTable datak = new DataTable();
            datak.Columns.Add("id barang", typeof(int));
            datak.Columns.Add("Nama Alat", typeof(string));
            datak.Columns.Add("Jumlah Alat", typeof(int));
            datak.Columns.Add("Stok", typeof(int));
            datak.Columns.Add("Harga Alat", typeof(int));
            datak.Columns.Add("Tanggal Sewa", typeof(DateTime));
            datak.Columns.Add("Tanggal Kembali", typeof(DateTime));
            datak.Columns.Add("Nama Penyewa", typeof(string));

            foreach (var item in isiKeranjang)
            {
                datak.Rows.Add(
                item.id_barang,
                item.namaBarang,
                item.jumlah,
                item.stok,
                item.hargaSewa,
                item.tglSewa,
                item.tglKembali,
                item.Penyewa.namaPenyewa);
            }
            dgvKeranjang.DataSource = null;
            dgvKeranjang.DataSource = datak;

            dgvKeranjang.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dgvKeranjang.ReadOnly = false;
            dgvKeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKeranjang.AllowUserToAddRows = false;

            dgvKeranjang.EnableHeadersVisualStyles = false; // Wajib false agar style custom bisa diterapkan
            dgvKeranjang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 169, 0);
            dgvKeranjang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvKeranjang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvKeranjang.ColumnHeadersHeight = 40;

            dgvKeranjang.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvKeranjang.RowHeadersVisible = false;
        }


        private void dgvKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("akan logout");
            this.Close();
        }

        private void btnDshbrd_Click(object sender, EventArgs e)
        {
            V_dashboardCust das = new V_dashboardCust();
            das.Show();
            this.Hide();
        }

        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            V_riwayatPenyewaanCust riwyatsewa = new V_riwayatPenyewaanCust();
            riwyatsewa.Show();
            this.Close();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            V_keranjangCust ker = new V_keranjangCust();
            ker.Show();
            this.Close();
        }

        private void btnDeskripsiAlat_Click(object sender, EventArgs e)
        {
            V_deskripsiAlat des = new V_deskripsiAlat();
            des.Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            V_profileCust prof = new V_profileCust();
            prof.Show();
            this.Close();
        }
    }
}
