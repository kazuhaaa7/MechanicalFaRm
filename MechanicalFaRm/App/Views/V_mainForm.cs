using MechanicalFaRm.App.Authh;

namespace MechanicalFaRm.App.Views
{
    public partial class v_mainForm : Form
    {

        System.Windows.Forms.Timer timer;
        A_login pagelogin;
        public v_mainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            pagelogin = new A_login();

            //this.Controls.Add(pagelogin);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            ShowLogin();
        }

        public void ShowLogin()
        {
            pagelogin = new A_login();
            pagelogin.Show();
            this.Hide();
        }

        private void v_mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
