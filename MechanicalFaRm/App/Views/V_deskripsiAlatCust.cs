using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
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
    public partial class V_deskripsiAlatCust : Form
    {
        private C_loginAuthController logout;
        private C_barangController ctrlBarang;
        private V_dashboardCust parentForm;
        private M_barang showBarang;
        private byte[]? fotoByte = null;
        private V_riwayatPenyewaanCust v_riwayatPenyewaanCust;
        private V_profileCust v_profileCust;

        public V_deskripsiAlatCust(V_dashboardCust parent, M_barang? barang = null)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            parentForm = parent;
            ctrlBarang = new C_barangController();
            showBarang = barang;
            logout = new C_loginAuthController();

            btnPicture.Text = "";
            btnPicture.SizeMode = PictureBoxSizeMode.Zoom;
            btnPicture.BorderStyle = BorderStyle.FixedSingle;

            if (showBarang != null)
            {
                tbNamaBarang.Text = showBarang.namaBarang;
                tbStok.Text = showBarang.stok.ToString();
            }
            else
            {
                tbStok.Text = "0";
            }
            tbStok.ReadOnly = true;

            if (showBarang != null)
            {
                tbHarga.Text = showBarang.hargaSewa.ToString();
                rtbDeskripsi.Text = showBarang.deskripsi;
                tbHarga.ReadOnly = true;
                rtbDeskripsi.ReadOnly = true;

                try
                {
                    using var ms = new MemoryStream(showBarang.fotoBarang);
                    btnPicture.Image = new Bitmap(ms);
                    fotoByte = showBarang.fotoBarang;
                }
                catch
                {
                    btnPicture.Image = null;
                    fotoByte = null;
                }
            }
        }

        public V_deskripsiAlatCust( V_riwayatPenyewaanCust v_riwayatPenyewaanCust)
        {
            this.v_riwayatPenyewaanCust = v_riwayatPenyewaanCust;
        }

        public V_deskripsiAlatCust(V_profileCust v_profileCust)
        {
            this.v_profileCust = v_profileCust;
        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            V_profileCust profile = new V_profileCust(id);
            profile.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout.Logout(this);
        }
 

        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            V_riwayatPenyewaanCust riwayatPembelian = new V_riwayatPenyewaanCust();
            riwayatPembelian.Show();
            this.Hide();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            new V_keranjangCust().Show();
            this.Close();
        }
    }
}
