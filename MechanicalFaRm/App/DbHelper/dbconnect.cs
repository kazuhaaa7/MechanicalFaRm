using Npgsql;

namespace MechanicalFaRm.App.DbHelper
{
    internal class dbconnect
    {


        public static  NpgsqlConnection getConn()
        {
            string host = Environment.GetEnvironmentVariable("DB_HOST");
            string db = Environment.GetEnvironmentVariable("DB_NAME");
            string user = Environment.GetEnvironmentVariable("DB_USER");
            string pass = Environment.GetEnvironmentVariable("DB_PASS");


            string connString = $"Host={host}; Username={user};Password={pass}; Database={db};";

            return new NpgsqlConnection(connString);
        }


    }
}
