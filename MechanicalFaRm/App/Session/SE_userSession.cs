using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicalFaRm.App.Session
{
    public static class SE_userSession
    {
        public static int id_user {  get; set; }
        public static string userName { get; set; }
        public static string email{ get; set; }
        public static string role { get; set; } = "customer";
        
        public static void ClearSession()
        {
            id_user = 0;
            userName = string.Empty;
            email = string.Empty;
            role = "customer";
        }
    }
}
