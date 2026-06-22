using MechanicalFaRm.App.Controllers;

namespace MechanicalFaRm.App.Authh
{
    public partial class V_regis : Form
    {
        private C_userController controlUser;

        public V_regis()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            controlUser = new C_userController();
        }


        public void OpenFormLogin()
        {
            new V_login().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenFormLogin();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            string username = tbUsernameR.Text.Trim();
            string password = tbPasswordR.Text;
            string notelp = tbNoTelpR.Text.Trim();
            string email = tbEmailR.Text.Trim();

            bool result = controlUser.RegisterCustomer(username, password, notelp, email);
            if (result == true)
            {
                MessageBox.Show("Akun berhasil dibuat! Silahkan Login");
                OpenFormLogin();
            }
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(notelp) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Semua kolom harus terisi!");
            }
        }

        private void A_regis_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbNoTelpR_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbEmailR_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsernameR_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPasswordR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
