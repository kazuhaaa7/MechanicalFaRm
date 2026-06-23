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
    public class polimor
    {
        public virtual bool Login(string username, string password) // polimorphsim
        {
            return true;
        }

    }
    public class C_loginAuthController:polimor //inheritance
    {
        public S_UserService _userService = new S_UserService();
        public override bool Login(string username, string password)
        {

            var result = _userService.Login(username, password);
            if (result == null) return false;
            if (result.role == "admin")
            {
                MessageBox.Show("Berhasil Login. role Admin");
                int id = SE_userSession.id_user;
                new V_profleAdmin(id).Show();
            }
            else if (result.role == "customer")
            {
                MessageBox.Show("Berhasil Login. role Customer");
                new V_dashboardCust().Show();
            }
            return true;
        } 

        public void Logout(Form currentForm)
        {
            SE_userSession.ClearSession();
            MessageBox.Show("Logout Berhasil", "Logout", MessageBoxButtons.OK, MessageBoxIcon.None);
            currentForm.Close();
        }
    }
}
