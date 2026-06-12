using MechanicalFaRm.App.Service;
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
        public S_UserService _userService;
        public bool Login(string username, string password)
        {

            var result = _userService.Login(username, password);
            if (result == null) return false;
            if (result.role == "admin")
            {
                new V_editProfile().Show();
            }
            else if (result.role == "customer")
            {
                new V_dashboardCust().Show();
            }
            MessageBox.Show("Berhasil Login.");
            return true;
        }
    }
}
