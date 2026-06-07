using MechanicalFaRm.App.DbHelper;
using MechanicalFaRm.App.Models;
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

        public string RegisterCustomer(string username, string password, string no_telp, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(no_telp) || string.IsNullOrEmpty(email))
                return "Semua data harus diisi";
            try
            {
                using var conn = new NpgsqlConnection(connString);
                conn.Open();
                string checkQuery = "SELECT 1 FROM public.user WHERE username=@u LIMIT 1";
                using (var cmd = new NpgsqlCommand(checkQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    if (cmd.ExecuteScalar() != null)
                        return "Username sudah digunakan";
                }
                string insertQuery = @"INSERT INTO public.user  (username, password, no_telp, email) VALUES (@username, @password, @no_telp, @email)";
                using (var cmd = new NpgsqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@no_telp", no_telp);
                    cmd.Parameters.AddWithValue("@email", email);


                    cmd.ExecuteNonQuery();
                }
                return "Registrasi akun berhasil";
            }
            catch (Exception err)
            {
                MessageBox.Show($"eror: {err.Message}");
                return "ERROR";
            }

        }

        public string Login(string username, string password)
        {

            try
            {

                using var conn = new NpgsqlConnection(connString);
                conn.Open();
                string query = @"SELECT * FROM public.user WHERE username=@u AND password=@p LIMIT 1";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);


                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    M_user member = new M_user();
                    member._id_user = reader.GetInt32(reader.GetOrdinal("id_user"));
                    member.username = reader["username"].ToString();
                    member.password = reader["password"].ToString();
                    member.no_telepon = reader["no_telp"].ToString();
                    member.email = reader["email"].ToString();
                    member.role = member.username == "admin" ? "admin" : "customer"; // Tentukan role berdasarkan username

                    CurrentUser = member;

                    return "Login Berhasil";
                }
                else
                {
                    return "pw atau user salah";
                }
            }
            catch (Exception err)
            {
                return $"terjadi kesalahan pada {err.Message}";
            }

        }

        public void GetUserById(int userId)
        {
            try
            {
                string query = @"SELECT * FROM public.user WHERE id_user=@id LIMIT 1";
                using var conn = new NpgsqlConnection(connString);
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    M_user user = new M_user
                    {
                        _id_user = reader.GetInt32(reader.GetOrdinal("id_user")),
                        username = reader["username"].ToString(),
                        password = reader["password"].ToString(),
                        no_telepon = reader["no_telp"].ToString(),
                        email = reader["email"].ToString(),
                        role = reader["role"].ToString()
                    };
                    // Gunakan objek user sesuai kebutuhan
                }
                else
                {
                    MessageBox.Show("User tidak ditemukan.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: {err.Message}");
            }

        }
    }
}
