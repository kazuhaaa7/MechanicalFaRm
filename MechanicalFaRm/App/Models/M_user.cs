namespace MechanicalFaRm.App.Models
{
    internal class M_user
    {
        public string username;
        public string password;


        public M_user(string user, string pw)
        {
            this.username = user;
            this.password = pw;
        }
    }
}
