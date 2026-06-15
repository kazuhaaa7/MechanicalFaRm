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
    public partial class V_kelolaAlatAdmin : Form
    {
        private S_BarangService _barangService;
        public V_kelolaAlatAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void V_kelolaAlatAdmin_Load(object sender, EventArgs e)
        {
            _barangService = new S_BarangService();
            //dgvKelolaAlat.DataSource = _barangService.GetListBarang();
            var listBarang = _barangService.GetListBarang();

            DataTable dt = new DataTable();
            dt.Columns.Add("Barang", typeof(int));
            dt.Columns.Add("Nama Alat", typeof(string));
            dt.Columns.Add("Deskripsi", typeof(string));
            dt.Columns.Add("Stok", typeof(int));
            dt.Columns.Add("Harga Sewa *satuan juta", typeof(int));

            foreach (var item in listBarang)
            {
                dt.Rows.Add(
                item.id_barang,
                item.namaBarang,
                item.deskripsi,
                item.stok,
                item.hargaSewa);
            }



            dgvKelolaAlat.DataSource = dt;


            dgvKelolaAlat.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dgvKelolaAlat.ReadOnly = false;
            dgvKelolaAlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKelolaAlat.AllowUserToAddRows = false;

            dgvKelolaAlat.EnableHeadersVisualStyles = false; // Wajib false agar style custom bisa diterapkan
            dgvKelolaAlat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 169, 0);
            dgvKelolaAlat.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvKelolaAlat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvKelolaAlat.ColumnHeadersHeight = 40;

            dgvKelolaAlat.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvKelolaAlat.RowHeadersVisible = false;


            //dgvKelolaAlat.CellClick -= dgvKelolaAlat_CellClick;
            //dgvKelolaAlat.CellClick += dgvKelolaAlat_CellClick;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvKelolaAlat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeskripsiAlat_Click(object sender, EventArgs e)
        {
            new V_deskripsiAlat().Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            new V_profleAdmin(id).Show();
            this.Close();
        }

        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            new V_kelolaAlatAdmin().Show();
            this.Close();
        }

        private void btnKelolaCust_Click(object sender, EventArgs e)
        {
            new V_kelolaAkunAdmin().Show();
            this.Close();
        }

        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            new V_riwayatPenyewaanAdmin().Show();
            this.Close();
        }
    }
}
