namespace MechanicalFaRm.App.Models
{
    internal class M_user
    {
        private string _username;
        private string _password;
        private string _no_telp;
        private string _email;
        public int _id_user;
        public string role = "user";




        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string no_telepon
        {
            get { return _no_telp; }
            set { _no_telp = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }


        //public M_user(string user, string pw, string telp, string email)
        //{
        //    this.username = user;
        //    this.password = pw;
        //    this.email = email;
        //    this.no_telp = telp;
        //}
    }
}
