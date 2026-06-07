using Npgsql;

namespace MechanicalFaRm.App.DbHelper
{
    internal class dbconnect
    {
        private static readonly string connString;

        static dbconnect()
        {
            string host = Environment.GetEnvironmentVariable("DB_HOST");
            string db = Environment.GetEnvironmentVariable("DB_NAME");
            string user = Environment.GetEnvironmentVariable("DB_USER");
            string pass = Environment.GetEnvironmentVariable("DB_PASS");


            connString = $"Host=localhost; Username=postgres;Password=postgre7; Database=MechanicalFaRm;";


        }

        public static NpgsqlConnection GetConn()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
