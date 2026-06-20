using MechanicalFaRm.App.DbHelper;
using MechanicalFaRm.App.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalFaRm.App.Repository
{
    internal class R_UserRepository : R_IUserRepository
    {
        public M_user? GetById(int id)
        {
            using var conn = dbconnect.GetConn();
            conn.Open();
            string rawsql = @"SELECT id_user, username, email,no_telp, role FROM public.user WHERE id_user=@id";

            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            return new M_user
            {
                _id_user = reader.GetInt32(0),
                username = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                email = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                no_telepon = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                role = reader.IsDBNull(4) ? string.Empty : reader.GetString(4)
            };
        }
        public M_user? GetByUsername(string username)
        {
            var daftarUser = new M_user();
            using var conn = dbconnect.GetConn();
            conn.Open();

            string rawsql = "SELECT id_user, username, email,no_telp, role  FROM public.user WHERE username=@u";
            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("@u", username);

            using var reader = cmd.ExecuteReader();


            if (!reader.Read()) return null;

            return new M_user
            {
                _id_user = reader.GetInt32(0),
                username = reader.GetString(1),
                email = reader.GetString(2),
                no_telepon = reader.GetString(3),
                role = reader.GetString(4)
            };
        }

        public M_user? GetByNotelp(string notelp)
        {
            var daftarUser = new M_user();
            using var conn = dbconnect.GetConn();
            conn.Open();

            string rawsql = "SELECT id_user, username, email,no_telp, role  FROM public.user WHERE no_telp=@n";
            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("@n", notelp);

            using var reader = cmd.ExecuteReader();


            if (!reader.Read()) return null;

            return new M_user
            {
                _id_user = reader.GetInt32(0),
                username = reader.GetString(1),
                email = reader.GetString(2),
                no_telepon = reader.GetString(3),
                role = reader.GetString(4)
            };
        }

        public M_user? GetUserByEmail(string email)
        {
            using var conn = dbconnect.GetConn();
            conn.Open();

            
            using var cmd = new NpgsqlCommand(
                @"SELECT id_user, username, email,no_telp, role  FROM public.user
                  WHERE email = @e", conn);
            cmd.Parameters.AddWithValue("@e", email);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            return new M_user
            {
                _id_user = reader.GetInt32(0),
                username = reader.GetString(1),
                email = reader.GetString(2),
                no_telepon = reader.GetString(3),
                role = reader.GetString(4)
            };
        }
        public void Register(M_user user)
        {
            using var conn = dbconnect.GetConn();  
            conn.Open();
            string rawsql = @"INSERT INTO ""user"" (username, password, no_telp, email) 
            VALUES(@u, @p, @n, @e)";
            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("@u", user.username);
            cmd.Parameters.AddWithValue("@p", user.password);
            cmd.Parameters.AddWithValue("@n", user.no_telepon);
            cmd.Parameters.AddWithValue("@e", user.email);

            cmd.ExecuteNonQuery();


        }
        public void UpdateUser(M_user user)
        {
            using var conn = dbconnect.GetConn();
            conn.Open();

            string rawsql = @"UPDATE public.user SET 
            username=@u, no_telp=@n, email=@e, role=@r, id_user=@id WHERE id_user=@id";

            using var cmd = new NpgsqlCommand(rawsql, conn);

            cmd.Parameters.AddWithValue("@u", user.username);
            cmd.Parameters.AddWithValue("@n", user.no_telepon);
            cmd.Parameters.AddWithValue("@e", user.email);
            cmd.Parameters.AddWithValue("@r", user.role);
            cmd.Parameters.AddWithValue("@id", user._id_user);

            cmd.ExecuteNonQuery();
        }
        public void Delete(M_user user)
        {
            using var conn = dbconnect.GetConn();
            conn.Open();

            string rawsql = @"DELETE FROM public.user WHERE id=@id";
            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("@id", user._id_user);

            cmd.ExecuteNonQuery();
        }
        public List<M_user> GetAllCust()
        {
            var daftarAdmin = new List<M_user>();
            using var conn = dbconnect.GetConn();
            conn.Open();

            string rawsql = @"SELECT * FROM ""user"" WHERE role='customer'";
            using var cmd = new NpgsqlCommand(rawsql, conn);
            using var reader = cmd.ExecuteReader();
            

            while (reader.Read())
            {
                daftarAdmin.Add(new M_user
                {
                    _id_user = reader.GetInt32(0),
                    namaPenyewa = reader.GetString(1),
                    username = reader.GetString(2),
                    password = reader.GetString(3),
                    no_telepon = reader.GetString(4),
                    email = reader.GetString(5),
                    role = reader.GetString(6)
                });
            }
            return daftarAdmin;
        }
    }
}
