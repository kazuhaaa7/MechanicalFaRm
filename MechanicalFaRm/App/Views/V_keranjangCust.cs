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
        public V_keranjangCust()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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

            DataTable datak = new DataTable();
            datak.Columns.Add("Nama Customer", typeof(string));
            datak.Columns.Add("Nama Alat", typeof(string));
            datak.Columns.Add("Jumlah Alat", typeof(int));
            datak.Columns.Add("Harga Alat", typeof(string));
            datak.Columns.Add("Durasi", typeof(string));
            datak.Columns.Add("Sub Total", typeof(string));

            foreach (var item in isiKeranjang)
            {
                datak.Rows.Add(
                    item.Penyewa.namaPenyewa,
                    item.namaBarang,
                    item.jumlah,
                    $"{item.hargaSewa} Juta",
                    $"{item.Durasi} Hari",
                    $"{item.subTotalKeranjang} Juta"
                );
            }
            dgvKeranjang.DataSource = datak;

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
            int id = SE_userSession.id_user;
            V_profileCust prof = new V_profileCust(id);
            prof.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin memproses pesanan ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes) return;

            int idUserYangLogin = SE_userSession.id_user;
            string hasil = _pesananControll.ProsesCo(idUserYangLogin);

            if (string.Equals(hasil, "sukses", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Pesanan berhasil dibuat! Silakan lakukan pembayaran.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int idPesananTerbaru = _servicePesanan.GetIdPesananTerbaru(idUserYangLogin);
                M_Pesanan datapesanan = _servicePesanan.GetPesananById(idPesananTerbaru);

                using (V_pembayaran formBayar = new V_pembayaran(datapesanan))
                {
                    formBayar.ShowDialog();
                }

                RefreshData(); 
            }
            else
            {
                MessageBox.Show(hasil, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }
