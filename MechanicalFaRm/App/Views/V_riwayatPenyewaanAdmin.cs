using MechanicalFaRm.App.Controllers;
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
    public partial class V_riwayatPenyewaanAdmin : Form
    {
        S_PesananService _servicesan;
        C_loginAuthController logout;
        public V_riwayatPenyewaanAdmin()
        {
            InitializeComponent();
            logout = new C_loginAuthController();
            _servicesan = new S_PesananService();
            this.WindowState = FormWindowState.Maximized;

            RefreshData();
        }

        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            new V_kelolaAlatAdmin().ShowDialog();
            this.Close();
        }

        private void btnKelolaCust_Click(object sender, EventArgs e)
        {
            new V_kelolaAkunAdmin().ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeskripsiAlat_Click(object sender, EventArgs e)
        {
            new V_deskripsiAlat().Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            new V_profleAdmin(id).Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout.Logout(this);
        }

        private void V_riwayatPenyewaanAdmin_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var isiKeranjang = _servicesan.GetAllPesanan();

            DataTable datak = new DataTable();
            datak.Columns.Add("Id Customer", typeof(string));
            datak.Columns.Add("Nama Alat", typeof(string));
            datak.Columns.Add("Jumlah Alat", typeof(int));
            datak.Columns.Add("Harga Alat", typeof(string));
            datak.Columns.Add("Durasi", typeof(string));
            datak.Columns.Add("Total", typeof(string));
            datak.Columns.Add("Status", typeof(string));

            foreach (var item in isiKeranjang)
            {
                datak.Rows.Add(
                    item?.Penyewa?._id_user,
                    item.namaBarang,
                    item.jumlah,
                    $"{item.hargaSewa} Juta",
                    $"{item.Durasi} Hari",
                    $"{item.total} Juta",
                    item.status
                );
            }
            dgvKelolaSewa.DataSource = datak;

            dgvKelolaSewa.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dgvKelolaSewa.ReadOnly = true;
            dgvKelolaSewa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKelolaSewa.AllowUserToAddRows = false;
            dgvKelolaSewa.EnableHeadersVisualStyles = false; // Wajib false agar style custom bisa diterapkan
            dgvKelolaSewa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 169, 0);
            dgvKelolaSewa.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvKelolaSewa.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvKelolaSewa.ColumnHeadersHeight = 40;
            dgvKelolaSewa.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvKelolaSewa.RowHeadersVisible = false;
        }
    }
}
