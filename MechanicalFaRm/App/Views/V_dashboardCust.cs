using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Session;

namespace MechanicalFaRm.App.Views
{
    public partial class V_dashboardCust : Form
    {
        C_loginAuthController logout;
        public V_dashboardCust()
        {
            InitializeComponent();
            logout = new C_loginAuthController();
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


        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            V_riwayatPenyewaanCust riwayatPembelian = new V_riwayatPenyewaanCust();
            riwayatPembelian.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            V_profileCust profile = new V_profileCust(id);
            profile.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout.Logout(this);
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnSewaAlat1_Click(object sender, EventArgs e)
        {
            int idBarangSewa = 1;
            V_popupBarang popup1 = new V_popupBarang(idBarangSewa);
            popup1.idBarang = idBarangSewa;
            popup1.ShowDialog();
        }

        private void btnSewaAlat2_Click(object sender, EventArgs e)
        {
            int idBarangSewa = 2;
            V_popupBarang popup2 = new V_popupBarang(idBarangSewa);
            popup2.idBarang = idBarangSewa;
            popup2.ShowDialog();
        }

        private void btnSewaAlat3_Click(object sender, EventArgs e)
        {
            int idBarangSewa = 3;
            V_popupBarang popup3 = new V_popupBarang(idBarangSewa);
            popup3.idBarang = idBarangSewa;
            popup3.ShowDialog();
        }

        private void btnSewaAlat4_Click(object sender, EventArgs e)
        {
            int idBarangSewa = 4;
            V_popupBarang popup4 = new V_popupBarang(idBarangSewa);
            popup4.idBarang = idBarangSewa;
            popup4.ShowDialog();
        }

        private void btnSewaAlat5_Click(object sender, EventArgs e)
        {
            int idBarangSewa = 5;
            V_popupBarang popup5 = new V_popupBarang(idBarangSewa);
            popup5.idBarang = idBarangSewa;
            popup5.ShowDialog();
        }

        private void btnSewaAlat6_Click(object sender, EventArgs e)
        {
            int idBarangSewa = 6;
            V_popupBarang popup6 = new V_popupBarang(idBarangSewa);
            popup6.idBarang = idBarangSewa;
            popup6.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            V_keranjangCust kc = new V_keranjangCust();
            kc.Show();
            this.Hide();
        }

        private void btnDeskripsiAlat_Click(object sender, EventArgs e)
        {
            V_deskripsiAlatCust des =  new V_deskripsiAlatCust();
            des.Show();
            this.Hide();
        }
    }
}
