using MechanicalFaRm.App.Controllers;
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
        C_loginAuthController logout;
        public V_riwayatPenyewaanAdmin()
        {
            InitializeComponent();
            logout = new C_loginAuthController();
            this.WindowState = FormWindowState.Maximized;
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


    }
}
