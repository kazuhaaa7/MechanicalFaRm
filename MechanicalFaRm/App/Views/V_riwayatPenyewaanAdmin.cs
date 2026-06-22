using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Service;
using MechanicalFaRm.App.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
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
            this.dgvKelolaSewa.DataError += new DataGridViewDataErrorEventHandler(dgvKelolaSewa_DataError);
            this.dgvKelolaSewa.CellValueChanged += new DataGridViewCellEventHandler(dgvKelolaSewa_CellValueChanged_1);
            this.dgvKelolaSewa.CurrentCellDirtyStateChanged += new EventHandler(dgvKelolaSewa_CurrentCellDirtyStateChanged);
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
            datak.Columns.Add("Id Customer");
            datak.Columns.Add("Nama Customer");
            datak.Columns.Add("Nama Alat");
            datak.Columns.Add("Jumlah Alat");
            datak.Columns.Add("Harga Alat");
            datak.Columns.Add("Durasi");
            datak.Columns.Add("Total");
            datak.Columns.Add("Tujuan");
            datak.Columns.Add("Status");
            datak.Columns.Add("Id Pesanan");


            foreach (var item in isiKeranjang)
            {
                datak.Rows.Add(
                    item.id_user,
                    item?.PenyewaDP?.namaPenyewa,
                    item.namaBarang,
                    item.jumlah,
                    $"{item.hargaSewa} Juta",
                    $"{item.Durasi} Hari",
                    $"{item.total} Juta",
                    item.tujuan.Jalan,
                    item.status.Trim(),
                    item.id_pesanan
                );
            }
            dgvKelolaSewa.DataSource = datak;

            if (dgvKelolaSewa.Columns.Contains("Status"))
                dgvKelolaSewa.Columns["Status"].Visible = false;

            if (dgvKelolaSewa.Columns.Contains("Id Pesanan"))
                dgvKelolaSewa.Columns["Id Pesanan"].Visible = false;

            if (!dgvKelolaSewa.Columns.Contains("cmbStatus"))
            {
                DataGridViewComboBoxColumn cmbStatus = new DataGridViewComboBoxColumn();
                cmbStatus.HeaderText = "Ubah Status";
                cmbStatus.Name = "cmbStatus";
                cmbStatus.DataPropertyName = "Status";

                cmbStatus.Items.Clear();
                cmbStatus.Items.AddRange("Menunggu Verifikasi Admin", "Sudah Terverifikasi Admin");
                cmbStatus.FlatStyle = FlatStyle.Flat;
                dgvKelolaSewa.Columns.Add(cmbStatus);
            }

            dgvKelolaSewa.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dgvKelolaSewa.ReadOnly = false;
            foreach (DataGridViewColumn col in dgvKelolaSewa.Columns)
            {
                if (col.Name != "cmbStatus")
                {
                    col.ReadOnly = true;
                }
            }
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

        private void dgvKelolaSewa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKelolaSewa.IsCurrentCellDirty)
            {
                dgvKelolaSewa.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvKelolaSewa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvKelolaSewa.Columns[e.ColumnIndex].Name == "cmbStatus")
            {
                int idPesanan = Convert.ToInt32(dgvKelolaSewa.Rows[e.RowIndex].Cells["Id Pesanan"].Value);
                string statusBaru = dgvKelolaSewa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                bool sukses = _servicesan.UpdatePesanan(idPesanan, statusBaru);

                if (sukses)
                {
                    MessageBox.Show("Status penyewaan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvKelolaSewa_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvKelolaSewa_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvKelolaSewa.Columns[e.ColumnIndex].Name == "cmbStatus")
            {
                int idPesanan = Convert.ToInt32(dgvKelolaSewa.Rows[e.RowIndex].Cells["Id Pesanan"].Value);
                string statusBaru = dgvKelolaSewa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                //MessageBox.Show($"Mencoba update DB...\nID Pesanan: {idPesanan}\nStatus Baru: {statusBaru}");

                bool sukses = _servicesan.UpdatePesanan(idPesanan, statusBaru);

                if (sukses)
                {
                    MessageBox.Show("Status penyewaan berhasil diperbarui!", "Sukses");
                    RefreshData(); 
                }
                else
                {
                    MessageBox.Show("GAGAL UPDATE KE DATABASE! Cek Query SQL Anda.", "Error");
                }
            }
        }

        private void dgvKelolaSewa_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKelolaCustomer_Click(object sender, EventArgs e)
        {
            new V_kelolaAkunAdmin().ShowDialog();
            this.Close();
        }
    }
}
