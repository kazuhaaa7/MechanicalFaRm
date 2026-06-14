using MechanicalFaRm.App.DbHelper;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Service;
using MechanicalFaRm.App.Session;
using Npgsql;

namespace MechanicalFaRm.App.Controllers
{
    internal class C_userController
    {
        //private M_userContext ucontext = new M_userContext();
        //private M_userContext GetAllUser()
        //{
        //    return ucontext;
        //}

        private readonly string connString;

        public C_userController()
        {
            dbconnect db = new dbconnect();
            connString = dbconnect.GetConn().ConnectionString;
        }

        public static M_user CurrentUser { get; private set; }

        public bool RegisterCustomer  (string username, string password, string no_telp, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(no_telp) || string.IsNullOrEmpty(email))
                return false;
            try
            {
                var regis = userService.Register(username,password, no_telp, email);
                if (regis == false) return false;
                
                return regis;

            }
            catch (Exception err)
            {
                MessageBox.Show($"eror: {err.Message}");
                return false;
            }

        }

        private S_UserService userService = new S_UserService();
        public M_user? TampilkanDataBasedId(int userId)
        {
            return userService.GetUserById(userId);
        }

        public bool UpdateUser(M_user user)
        {
            userService.UpdateProfile(user);
            return true;
        }
    }
}
