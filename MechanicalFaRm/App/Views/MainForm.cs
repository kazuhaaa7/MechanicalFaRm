using MechanicalFaRm.App.Authh;

namespace MechanicalFaRm.App.Views
{
    public partial class MainForm : Form
    {

        System.Windows.Forms.Timer timer;
        A_login pagelogin;
        public MainForm()
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
            pagelogin.Visible = true;
            this.Hide();
        }
    }
}
