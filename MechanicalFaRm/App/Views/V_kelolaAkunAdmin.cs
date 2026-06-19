using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Service;
using MechanicalFaRm.App.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_kelolaAkunAdmin : Form
    {
        C_loginAuthController logout;
        private S_UserService _userService;
        public V_kelolaAkunAdmin()
        {
            InitializeComponent();
            logout = new C_loginAuthController();
            _userService = new S_UserService();
            this.WindowState = FormWindowState.Maximized;

            RefrestDataCus();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDeskripsiAlat_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda akan logout.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            new V_kelolaAlatAdmin().Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            new V_riwayatPenyewaanAdmin().Show();
            this.Close();
        }

        private void btnDeskripsiAlat_Click_1(object sender, EventArgs e)
        {
            new V_deskripsiAlat().Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            new V_profleAdmin(id).Show();
            this.Close();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            logout.Logout(this);
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void V_kelolaAkunAdmin_Load(object sender, EventArgs e)
        {
            RefrestDataCus();


        }
        private void RefrestDataCus()
        {
            var listCust = _userService.GetAllCust();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id Customoer", typeof(int));
            dt.Columns.Add("Nama Customer", typeof(string));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("No Telp", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Role", typeof(string));

            foreach (var items in listCust)
            {
                dt.Rows.Add(
                    items._id_user,
                    items.namaPenyewa,
                    items.username,
                    items.no_telepon,
                    items.email,
                    items.role
                    );


                dgvKelolaAkun.DataSource = dt;


                dgvKelolaAkun.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
                dgvKelolaAkun.ReadOnly = true;
                dgvKelolaAkun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvKelolaAkun.AllowUserToAddRows = false;

                dgvKelolaAkun.EnableHeadersVisualStyles = false; // Wajib false agar style custom bisa diterapkan
                dgvKelolaAkun.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 169, 0);
                dgvKelolaAkun.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvKelolaAkun.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                dgvKelolaAkun.ColumnHeadersHeight = 40;

                dgvKelolaAkun.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgvKelolaAkun.RowHeadersVisible = false;
            }
        }

        private void dgvKelolaAkun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
