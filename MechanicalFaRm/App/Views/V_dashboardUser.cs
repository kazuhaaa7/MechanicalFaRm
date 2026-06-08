namespace MechanicalFaRm.App.Views
{
    public partial class V_dashboardUser : Form
    {
        public V_dashboardUser()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void V_dashboardUser_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            V_dashboardUser dashboard = new V_dashboardUser();
            dashboard.Show();
            this.Hide();
        }

        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            V_riwayatPenyewaan riwayatPembelian = new V_riwayatPenyewaan();
            riwayatPembelian.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda akan logout");
            this.Close();
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnSewaAlat1_Click(object sender, EventArgs e)
        {
            V_popupBarang popup = new V_popupBarang();
            popup.Show();
        }

        private void btnSewaAlat2_Click(object sender, EventArgs e)
        {
            V_popupBarang popup = new V_popupBarang();
            popup.Show();
        }

        private void btnSewaAlat3_Click(object sender, EventArgs e)
        {
            V_popupBarang popup = new V_popupBarang();
            popup.Show();
        }

        private void btnSewaAlat4_Click(object sender, EventArgs e)
        {
            V_popupBarang popup = new V_popupBarang();
            popup.Show();
        }

        private void btnSewaAlat5_Click(object sender, EventArgs e)
        {
            V_popupBarang popup = new V_popupBarang();
            popup.Show();
        }

        private void btnSewaAlat6_Click(object sender, EventArgs e)
        {
            V_popupBarang popup = new V_popupBarang();
            popup.Show();
        }
    }
}
