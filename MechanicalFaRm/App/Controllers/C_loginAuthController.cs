using MechanicalFaRm.App.Authh;
using MechanicalFaRm.App.Service;
using MechanicalFaRm.App.Session;
using MechanicalFaRm.App.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalFaRm.App.Controllers
{
    internal class C_loginAuthController
    {
        public S_UserService _userService = new S_UserService();
        public bool Login(string username, string password)
        {

            var result = _userService.Login(username, password);
            if (result == null) return false;
            if (result.role == "admin")
            {
                int id = SE_userSession.id_user;
                new V_profleAdmin(id).Show();
            }
            else if (result.role == "customer")
            {
                new V_dashboardCust().Show();
            }
            MessageBox.Show("Berhasil Login.");
            return true;
        }


        public void logout(Form currentForm)
        {
            SE_userSession.ClearSession();
            MessageBox.Show("Logout Berhasil", "Logout", MessageBoxButtons.OK, MessageBoxIcon.None);
            currentForm.Close();
        }
    }
}
