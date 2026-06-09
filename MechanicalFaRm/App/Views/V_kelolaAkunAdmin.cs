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
        public V_kelolaAkunAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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
    }
}
