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
    public partial class V_profileCust : Form
    {
        private int idCurrent;
        private C_loginAuthController logout;
        public V_profileCust(int id)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.idCurrent = id;
            logout = new C_loginAuthController();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void V_profileCust_Load(object sender, EventArgs e)
        {
            idCurrent = SE_userSession.id_user;
            C_userController userController = new C_userController();
            M_user user = userController.TampilkanDataBasedId(idCurrent);

            if (user != null)
            {
                label1.Text = user.username;
                lblEmail.Text = user.email;
                lblNoTelp.Text = user.no_telepon;
            }
            else
            {
                MessageBox.Show("Data pengguna tidak ditemukan.");
            }

        }

        private void btnKelolaCust_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfileA_Click(object sender, EventArgs e)
        {
            using (V_editProfile formEdit = new V_editProfile(RefreshDataProfil))
            {
                formEdit.ShowDialog();
            }
        }

        private void RefreshDataProfil()
        {
            idCurrent = SE_userSession.id_user;

            C_userController userController = new C_userController();
            M_user user = userController.TampilkanDataBasedId(idCurrent);

            if (user != null)
            {
                label1.Text = user.username;
                lblEmail.Text = user.email;
                lblNoTelp.Text = user.no_telepon;
            }
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

        private void btnDeskripsiAlat_Click_1(object sender, EventArgs e)
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout.Logout(this);
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblNoTelp_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
