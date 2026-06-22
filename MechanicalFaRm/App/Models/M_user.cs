namespace MechanicalFaRm.App.Models
{
    public class M_user
    {
        public string _username;
        private string _password;
        private string _no_telp;
        private string _email;
        public int _id_user;
        public string namaPenyewa { get; set; }
        public string role = "customer";




        public string username //encapsulasi
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

    }
}
