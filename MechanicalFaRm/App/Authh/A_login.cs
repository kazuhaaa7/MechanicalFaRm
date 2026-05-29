using MechanicalFaRm.App.Views;
namespace MechanicalFaRm.App.Authh
{
    public partial class A_login : Form
    {

        private string username;
        private string password;
        private V_dashboardUser _dashboarduser;
        public A_login()
        {
            InitializeComponent();
            username = "rossi";
            password = "rossi123";
            //this._dashboarduser = dashboardUser;
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
            string passwordInput = tbPassword.Text;

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

            if (usernameInput == this.username && passwordInput == this.password)
            {
                MessageBox.Show("Login Berhasil", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                V_dashboardUser pagedashborad = new V_dashboardUser();
                pagedashborad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pssword atau Usernamw salah. Silahkan Login ulang", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
