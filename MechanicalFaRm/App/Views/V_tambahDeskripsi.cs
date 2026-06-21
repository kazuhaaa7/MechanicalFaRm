using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_tambahDeskripsi : Form
    {
        private C_loginAuthController logout;
        private C_barangController ctrlBarang;
        private V_deskripsiAlat parentForm;
        private M_barang editBarang;
        private byte[]? fotoByte = null;
        public V_tambahDeskripsi(V_deskripsiAlat parent, M_barang? barang = null)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            logout = new C_loginAuthController();
            parentForm = parent;
            ctrlBarang = new C_barangController();
            editBarang = barang;


            btnPicture.Text = "";
            btnPicture.SizeMode = PictureBoxSizeMode.Zoom;
            btnPicture.BorderStyle = BorderStyle.FixedSingle;

            if (editBarang != null)
            {
                tbNamaBarang.Text = editBarang.namaBarang;
                tbStok.Text = editBarang.stok.ToString();
            }
            else
            {
                tbStok.Text = "0";
            }
            //tbStok.ReadOnly = true;

            if (editBarang != null)
            {
                tbHarga.Text = editBarang.hargaSewa.ToString();
                rtbDeskripsi.Text = editBarang.deskripsi;

                try
                {
                    using var ms = new MemoryStream(editBarang.fotoBarang);
                    btnPicture.Image = new Bitmap(ms);
                    fotoByte = editBarang.fotoBarang;
                }
                catch
                {
                    btnPicture.Image = null;
                    fotoByte = null;
                }
            }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        var img = Image.FromStream(fs);
                        btnPicture.Image = new Bitmap(img);
                    }
                    fotoByte = File.ReadAllBytes(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Gagal memuat gambar.");
                    btnPicture.Image = null;
                    fotoByte = null;
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNamaBarang.Text))
            {
                MessageBox.Show("Nama produk harus diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbHarga.Text, out int hargaValue) || hargaValue < 0)
            {
                MessageBox.Show("Harga harus berupa angka bulat >= 0", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(tbStok.Text, out int stokValue) || stokValue < 0)
            {
                MessageBox.Show("Stok harus berupa angka bulat >= 0", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var barang = editBarang ?? new M_barang();
            barang.namaBarang = tbNamaBarang.Text;
            barang.stok = stokValue;
            barang.hargaSewa = hargaValue;
            barang.deskripsi = rtbDeskripsi.Text;
            barang.fotoBarang = fotoByte;


            try
            {
                bool success = editBarang == null ? ctrlBarang.InsertBarang(barang) : ctrlBarang.UpdateBarang(barang);
                if (success)
                {
                    MessageBox.Show("Data berhasil disimpan");
                    parentForm.LoadDeskripsi();
                    this.Close();
                    parentForm.Show();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void btnKelolaCust_Click(object sender, EventArgs e)
        {
            new V_kelolaAkunAdmin().Show();
            this.Hide();
        }

        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            new V_riwayatPenyewaanAdmin().Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            new V_profleAdmin(id).Show();
            this.Hide();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout.Logout(this);
        }
    }
}
