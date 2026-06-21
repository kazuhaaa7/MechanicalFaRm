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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_riwayatPenyewaanCust : Form
    {

        S_PesananService _PesananService;
        C_loginAuthController logout;
        public V_riwayatPenyewaanCust()
        {
            InitializeComponent();
            _PesananService = new S_PesananService();
            logout = new C_loginAuthController();
            this.WindowState = FormWindowState.Maximized;
        }

        private void V_riwayatPembelian_Load(object sender, EventArgs e)
        {
            TampilkanDaftarPesanan();
        }

        public void TampilkanDaftarPesanan()
        {
            int _idUserAktif = SE_userSession.id_user;
            List<M_DetailPesanan> detail = _PesananService.GetAllPesanan(_idUserAktif);
            var listBarang = detail;

            DataTable dt = new DataTable();
            dt.Columns.Add("No Pesanan");
            dt.Columns.Add("Tanggal Sewa");
            dt.Columns.Add("Durasi");
            dt.Columns.Add("Nama Alat");
            dt.Columns.Add("Jumlah");
            dt.Columns.Add("Total");
            dt.Columns.Add("Status");
            dt.Columns.Add("Tujuan");
            dt.Columns.Add("Metode Pembayaran");

            foreach (var item in listBarang)
            {
                dt.Rows.Add(
                item.id_pesanan,
                item.tglSewa.ToString("dd-MM-yyyy"),
                $"{item.Durasi} Hari",
                item.namaBarang,
                item.jumlah,
                $"{item.total} Juta",
                item.status,
                item.tujuan?.Jalan ?? "Belum Input Tujuan",
                item.metode_pembayaran
                );
            }



            dataGridView1.DataSource = dt;


            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.EnableHeadersVisualStyles = false; // Wajib false agar style custom bisa diterapkan
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 169, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;

            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.RowHeadersVisible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDshbrd_Click(object sender, EventArgs e)
        {
            new V_dashboardCust().Show();
            this.Close();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            new V_keranjangCust().Show();
            this.Close();
        }

        private void btnDeskripsiAlat_Click(object sender, EventArgs e)
        {
            M_barang barang = new M_barang();
            V_deskripsiAlatCust des = new V_deskripsiAlatCust(null, barang);
            des.Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            new V_profileCust(id).Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout.Logout(this);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            new V_riwayatPenyewaanAdmin().Show();
            this.Hide();
        }
    }
}
