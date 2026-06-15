using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Session;
using MechanicalFaRm.App.Views;
namespace MechanicalFaRm.App.Authh
{
    public partial class V_login : Form
    {
        private V_dashboardCust _dashboarduser;
        private C_userController controlUser;
        private C_loginAuthController _authLogin;

        public V_login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _authLogin = new C_loginAuthController();
            controlUser = new C_userController();
        }

        public void OpenDashboard()
        {
            _dashboarduser = new V_dashboardCust();
            _dashboarduser.Show();
            this.Hide();
        }

        public void ProfileAdmin()
        {
            int idlog = SE_userSession.id_user;
            V_profleAdmin padmin = new V_profleAdmin(idlog);
            padmin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void A_login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbUsername.Focus();
            string usernameInput = tbUsername.Text.Trim();
            string passwordInput = tbPassword.Text.Trim();
            tbUsername.Text = "";//gunanya untuk otomatis menghilangkan value yg ada di textbox untuk mengurangi kemungkinan terjadinya shoulder surfing
            tbPassword.Text = "";

            if (string.IsNullOrEmpty(usernameInput))
            {
                MessageBox.Show("Username tidak boleh kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Password tidak boleh kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return;
            }
            bool succes = _authLogin.Login(usernameInput, passwordInput);
            if (!succes)
            {
                MessageBox.Show("Username atau Password salah. Silahkan Coba Lagi!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }



            //if (usernameInput == this.username && passwordInput == this.password)
            //{
            //    MessageBox.Show("Login Berhasil", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    V_dashboardUser pagedashborad = new V_dashboardUser();
            //    pagedashborad.Show();
            //    this.Hide();
            //}


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnRegist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Move to Form Regist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            V_regis regis = new V_regis();
            regis.Show();
            this.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
