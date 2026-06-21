using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Repository;
using MechanicalFaRm.App.Service;
using MechanicalFaRm.App.Session;
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
        private C_PesananController _pesananControll;
        private R_PesananRepository _reposan;
        private C_loginAuthController logout;
        public V_keranjangCust()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            logout = new C_loginAuthController();
            _reposan = new R_PesananRepository();
            _servicePesanan = new S_PesananService();
            _pesananControll = new C_PesananController();
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
            var isiKeranjang = _servicePesanan.GetListKeranjang(SE_userSession.id_user);

            dgvKeranjang.Columns.Clear();

            DataTable datak = new DataTable();
            datak.Columns.Add("Id Keranjang");
            datak.Columns.Add("Nama Alat");
            datak.Columns.Add("Jumlah Alat");
            datak.Columns.Add("Harga Alat");
            datak.Columns.Add("Durasi");
            datak.Columns.Add("Sub Total");


            decimal grandTotalKeseluruhan = 0;
            foreach (var item in isiKeranjang)
            {
                int durasi = (item.tglKembali - item.tglSewa).Days;
                if (durasi <= 0) durasi = 3;

                decimal subTotal = (decimal)item.hargaSewa * item.jumlah * durasi;
                grandTotalKeseluruhan += subTotal;


                datak.Rows.Add(
                    item.id_keranjang,
                    item.namaBarang,
                    item.jumlah,
                    $"{item.hargaSewa} Juta",
                    $"{item.Durasi} Hari",
                    $"{item.subTotalKeranjang} Juta"
                );
            }
            dgvKeranjang.DataSource = datak;
            dgvKeranjang.Columns["Id Keranjang"].Visible = false;

            if (!dgvKeranjang.Columns.Contains("btnHapus"))
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.HeaderText = "Aksi";
                btnHapus.Name = "btnHapus";
                btnHapus.Text = "Hapus";
                btnHapus.UseColumnTextForButtonValue = true;
                btnHapus.FlatStyle = FlatStyle.Flat;
                btnHapus.DefaultCellStyle.BackColor = Color.Red;
                btnHapus.DefaultCellStyle.ForeColor = Color.White;

                dgvKeranjang.Columns.Add(btnHapus);
            }

            lblTotalTagihan.Text = $"Total Tagihan: Rp {grandTotalKeseluruhan:N0} Juta";

            dgvKeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKeranjang.RowHeadersVisible = false;

            dgvKeranjang.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dgvKeranjang.ReadOnly = true;
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
            if (e.RowIndex >= 0 && dgvKeranjang.Columns[e.ColumnIndex].Name == "btnHapus")
            {
                int idKeranjangYangDipilih = Convert.ToInt32(dgvKeranjang.Rows[e.RowIndex].Cells["Id Keranjang"].Value);
                string namaAlat = dgvKeranjang.Rows[e.RowIndex].Cells["Nama Alat"].Value.ToString();

                DialogResult konfirmasi = MessageBox.Show($"Apakah Anda yakin ingin menghapus {namaAlat} dari keranjang?",
                                                          "Konfirmasi Hapus",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                if (konfirmasi == DialogResult.Yes)
                {
                    bool berhasilHapus = _servicePesanan.DeleteItemKeranjang(idKeranjangYangDipilih);

                    if (berhasilHapus)
                    {
                        MessageBox.Show("Barang berhasil dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus barang dari keranjang.", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout.Logout(this);
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
            M_barang barang = new M_barang();
            V_deskripsiAlatCust des = new V_deskripsiAlatCust(null, barang);
            des.Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            V_profileCust prof = new V_profileCust(id);
            prof.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Lanjut ke pembayaran?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi != DialogResult.Yes) return;

            int idUserYangLogin = SE_userSession.id_user;

            List<M_Keranjang> isiKeranjang = _servicePesanan.GetListKeranjang(idUserYangLogin);

            if (isiKeranjang == null || isiKeranjang.Count == 0)
            {
                MessageBox.Show("Keranjang Anda kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (V_pembayaran formBayar = new V_pembayaran(isiKeranjang, true))
            {
                formBayar.ShowDialog();
            }

            RefreshData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
