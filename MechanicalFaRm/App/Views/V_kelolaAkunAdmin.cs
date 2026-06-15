using MechanicalFaRm.App.Controllers;
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
    public partial class V_kelolaAkunAdmin : Form
    {
        C_loginAuthController logout;
        public V_kelolaAkunAdmin()
        {
            InitializeComponent();
            logout = new C_loginAuthController();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDeskripsiAlat_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda akan logout.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnKelolaCust_Click(object sender, EventArgs e)
        {
            V_kelolaAkunAdmin kelolaAkunAdmin = new V_kelolaAkunAdmin();
            kelolaAkunAdmin.Show();
            this.Hide();
        }

        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            new V_kelolaAlatAdmin().Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            new V_riwayatPenyewaanAdmin().Show();
            this.Close();
        }

        private void btnDeskripsiAlat_Click_1(object sender, EventArgs e)
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

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            logout.Logout(this);
        }
    }
}
