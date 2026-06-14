using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Session;

namespace MechanicalFaRm.App.Views
{
    public partial class V_profleAdmin : Form
    {
        private static C_userController userController;
        private int currentUserId;
        public V_profleAdmin(int userId)
        {
            InitializeComponent();
            userController = new C_userController();
            this.WindowState = FormWindowState.Maximized;
            this.currentUserId = userId;

        }



        private void V_profle_Load(object sender, EventArgs e)
        {
            int idUserLogin = SE_userSession.id_user;
            C_userController userController = new C_userController();
            M_user user = userController.TampilkanDataBasedId(idUserLogin);

            if (user != null)
            {
                lblUsername.Text = user.username;
                lblEmail.Text = user.email;
                lblNoTelp.Text = user.no_telepon;
            }
            else
            {
                MessageBox.Show("Data pengguna tidak ditemukan.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //ganti class dashbioard admin
            V_kelolaAlatAdmin du = new V_kelolaAlatAdmin();
            du.Show();
            this.Hide();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda akan logout");
            this.Close();
        }

        private void txtName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNoTelp_Click(object sender, EventArgs e)
        {

        }

        private void btnKelolaCust_Click(object sender, EventArgs e)
        {
            V_kelolaAkunAdmin ka = new V_kelolaAkunAdmin();
            ka.Show();
            this.Close();
        }

        private void btnEditProfileA_Click(object sender, EventArgs e)
        {
            V_editProfile editProfile = new V_editProfile();
            editProfile.Show();
            this.Close();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click_1(object sender, EventArgs e)
        {

        }

        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            V_kelolaAlatAdmin kal = new V_kelolaAlatAdmin();
            kal.Show();
            this.Close();
        }

        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            V_riwayatPenyewaanAdmin riad = new V_riwayatPenyewaanAdmin();
            riad.Show();
            this.Close();
        }

        private void btnProfilA_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            V_profleAdmin pad = new V_profleAdmin(id);
            pad.Show();
            this.Close();
        }
    }
}
