using Npgsql;

namespace MechanicalFaRm.App.DbHelper
{
    internal class dbconnect
    {
        string db_name;
        string db_host;
        string db_pw;
        string db_user;
        public string connstring;

        public dbconnect()
        {
            db_host = "localhost";
            db_name = "MechanicalFaRm";
            db_user = "postgres";
            db_pw = "postgre7";

            connstring = $"Host={db_host}; Username={db_user};Password={db_pw}; Database{db_name};";
        }

        public NpgsqlConnection getConn()
        {
            return new NpgsqlConnection(connstring);
        }


    }
}
