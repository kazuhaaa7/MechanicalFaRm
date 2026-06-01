using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;

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

            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                userController.GetUserById(currentUserId);

                var user = C_userController.CurrentUser;

                if (userController!= null)
                {
                    txtName.Text = user.username;
                    txtEmail.Text = user.email;
                    txtNoTelp.Text = user.no_telepon;
                    txtPassword.Text = user.password;
                }
            }
            catch
            {
            }

        }

        private void V_profle_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEditProfileA_Click(object sender, EventArgs e)
        {

        }
    }
}
