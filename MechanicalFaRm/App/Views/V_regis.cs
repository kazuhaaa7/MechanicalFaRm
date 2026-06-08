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
            MessageBox.Show("Move to Form login", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string password = tbPasswordR.Text.Trim();
            string notelp = tbNoTelpR.Text.Trim();
            string email = tbEmailR.Text.Trim();



            if (username == "" || password == "" || notelp == "" || email == "")
            {
                MessageBox.Show("Semua kolom data harus diisi");
                return;
                tbUsernameR.Focus();
            }

            if (username.Length < 5)
            {
                MessageBox.Show("username minimal 5 character");
                return;
                tbUsernameR.Focus();
            }

            if (password.Length <= 4)
            {
                MessageBox.Show("password minimal 4 character");
                return;
                tbUsernameR.Focus();
            }

            if (!long.TryParse(notelp, out _))//out ("_" = discard => ingin memeriksa apakah notelp bisa diconvert tanpa disimpan di dalam variabel) 
            {
                MessageBox.Show("no telepon harus berupa angka");
                if (notelp.Length > 13)
                {
                    MessageBox.Show("no telepon harus 12 angka");
                    tbUsernameR.Focus();
                }
                return;
            }

            string result = controlUser.RegisterCustomer(username, password, notelp, email);
            if (result == "Registrasi akun berhasil")
            {
                MessageBox.Show("Akun berhasil dibuat! Silahkan Login");
                OpenFormLogin();

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
    }
}
