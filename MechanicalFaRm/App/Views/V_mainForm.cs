using MechanicalFaRm.App.Authh;

namespace MechanicalFaRm.App.Views
{
    public partial class v_mainForm : Form
    {

        System.Windows.Forms.Timer timer;
        A_regis pageregis;
        public v_mainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //pageregis = new A_regis();

            //this.Controls.Add(pageregis);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            ShowRegis();
        }

        public void ShowRegis()
        {
            pageregis = new A_regis();
            pageregis.Show();
            this.Hide();
        }

        private void v_mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
