using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Views;
namespace MechanicalFaRm.App.Authh
{
    public partial class V_login : Form
    {
        private V_dashboardUser _dashboarduser;
        private C_userController controlUser;
        private readonly C_loginAuthController _authLogin;

        public V_login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _authLogin = new C_loginAuthController();
            controlUser = new C_userController();
        }

        public void OpenDashboard()
        {
            _dashboarduser = new V_dashboardUser();
            _dashboarduser.Show();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Verifikasi 2 Langkah", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameInput = tbUsername.Text.Trim();
            string passwordInput = tbPassword.Text.Trim();
            tbUsername.Text = "";//gunanya untuk otomatis menghilangkan value yg ada di textbox untuk mengurangi kemungkinan terjadinya shoulder surfing
            tbPassword.Text = "";

            bool suksesLogin = _authLogin.Login(usernameInput, passwordInput);

            if (!suksesLogin)
            {
                MessageBox.Show("Pw atau Username salah");
            }
            try
            {
                if (string.IsNullOrEmpty(usernameInput))
                {
                    MessageBox.Show("Username tidak boleh kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbUsername.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(passwordInput))
                {
                    MessageBox.Show("Password tidak boleh kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPassword.Focus();
                    return;
                }
                string result = controlUser.Login(usernameInput, passwordInput);
                if (result == "Login Berhasil")
                {
                    MessageBox.Show("Berhasil Login.");
                    if (C_userController.CurrentUser.role == "admin")
                    {
                        // Assuming CurrentUser has a property 'id' or similar for userId
                        V_profleAdmin admin = new(C_userController.CurrentUser._id_user);
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        OpenDashboard();

                    }
                }
                else if (result == "pw atau user salah")
                {
                    MessageBox.Show("Pssword atau Username salah. Silahkan Login ulang", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(result, "Informasi Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"error {err.Message}");
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
