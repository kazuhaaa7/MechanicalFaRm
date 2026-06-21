using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_editProfile : Form
    {
        private C_userController _userController;
        private Action _callbackRefreshProfil;
        public V_editProfile(Action callbackRefreshProfil)
        {
            InitializeComponent();
            _userController = new C_userController();
            _callbackRefreshProfil = callbackRefreshProfil;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string email = tbEmail.Text.Trim();
            string notelp = tbNoTelp.Text.Trim();
            M_user databaru = new M_user();
            databaru.username = username;
            databaru.email = email;
            databaru.no_telepon = notelp;

            _userController.UpdateUser(databaru);
            MessageBox.Show("Berhasil mengedit data", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _callbackRefreshProfil?.Invoke();
            this.Close();
            
        }
    }
}
