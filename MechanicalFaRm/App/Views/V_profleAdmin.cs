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

        private void btnEditProfileA_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //ganti class dashbioard admin
            V_dashboardCust du = new V_dashboardCust();
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
    }
}
