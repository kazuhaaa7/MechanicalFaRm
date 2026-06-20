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
            dt.Columns.Add("Nama Alat", typeof(string));
            dt.Columns.Add("Banyak Unit", typeof(int));
            dt.Columns.Add("Harga Sewa", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Durasi", typeof(string));
            dt.Columns.Add("Total", typeof(string));
            dt.Columns.Add("Tujuan", typeof(string));

            foreach (var item in listBarang)
            {
                dt.Rows.Add(
                item.namaBarang,
                item.jumlah,
                $"{item.hargaSewa} Juta",
                item.status,
                $"{item.Durasi} Hari",
                $"{item.total} Juta",
                item.tujuan?.Jalan??"Belum Input Tujuan"
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
            //new V_deskripsiAlatCust(this).Show();
            //this.Hide();
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
    }
}
