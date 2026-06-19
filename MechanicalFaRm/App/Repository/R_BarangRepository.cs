using MechanicalFaRm.App.DbHelper;
using MechanicalFaRm.App.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalFaRm.App.Repository
{
    internal class R_BarangRepository  
    {

        public List<M_barang> GetListBarang()   
        { 
            var daftarBarang = new List<M_barang>();
            try
            {
                using var conn = dbconnect.GetConn();
                conn.Open();

                string rawsql = @"SELECT id_barang, nama_barang, deskripsi, harga_sewa, stok, foto_barang 
                          FROM barang ORDER BY id_barang ASC";
                using var cmd = new NpgsqlCommand(rawsql, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    daftarBarang.Add(new M_barang
                    {
                        id_barang = reader.GetInt32(reader.GetOrdinal("id_barang")),
                        namaBarang = reader.GetString(reader.GetOrdinal("nama_barang")),
                        deskripsi = reader.IsDBNull(reader.GetOrdinal("deskripsi")) ? "" : reader.GetString(reader.GetOrdinal("deskripsi")),
                        hargaSewa = reader.GetInt32(reader.GetOrdinal("harga_sewa")),
                        stok = reader.GetInt32(reader.GetOrdinal("stok")),
                        fotoBarang = reader.IsDBNull(reader.GetOrdinal("foto_barang")) ? null : (byte[])reader["foto_barang"]
                    });
                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error GetListBarang: {ex.Message}");
            }
            
            return daftarBarang;
        }

        public List<M_barang> GetListBarang(int limit)
        {
            var daftarBarang = new List<M_barang>();
            using var conn = dbconnect.GetConn();
            conn.Open();
            string rawsql = $"SELECT * FROM barang WHERE stok >1 ORDER BY id_barang ASC LIMIT @limit";

            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("limit", limit);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                daftarBarang.Add(new M_barang
                {
                    id_barang = reader.GetInt32(0),
                    namaBarang = reader.GetString(1),
                    deskripsi = reader.GetString(2),
                    hargaSewa = reader.GetInt32(3),
                    stok = reader.GetInt32(4)
                });
                
            }
            return daftarBarang;
        }
        public M_barang? GetBarangById(int id)
        {
            using var conn = dbconnect.GetConn();
            conn.Open();

            string rawsql = "SELECT id_barang, nama_barang, deskripsi, harga_sewa, stok FROM barang WHERE id_barang = @id";
            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("id", id);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                    return new M_barang
                    {
                        id_barang = reader.GetInt32(0),
                        namaBarang = reader.GetString(1),
                        deskripsi = reader.GetString(2),
                        hargaSewa = reader.GetInt32(3),
                        stok = reader.GetInt32(4)
                    };
            }

            return null;
        }
        public M_barang? GetStok()
        {
            using var conn = dbconnect.GetConn();
            conn.Open();
            string rawsql = @"SELECT * FROM 
            barang WHERE stok >0 AND stok < 5
            ORDER BY id_barang ASC LIMIT 1";

            using var cmd = new NpgsqlCommand(rawsql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                return new M_barang
                {
                    id_barang = reader.GetInt32(0),
                    namaBarang = reader.GetString(1),
                    deskripsi = reader.GetString(2),
                    hargaSewa = reader.GetInt32(3),
                    stok = reader.GetInt32(4)
                };
            }
            return null;
        }
        public bool InsertBarang(M_barang barang)
        {
            try
            {
                using var conn = dbconnect.GetConn();
                conn.Open();

                string rawsql =
                    @"INSERT INTO 
                public.barang (nama_barang, deskripsi, harga_sewa, stok, foto_barang)
                VALUES (@nama_barang, @deskripsi, @harga_sewa, @stok, @foto)";

                using var cmd = new NpgsqlCommand(rawsql, conn);
                cmd.Parameters.AddWithValue("@nama_barang", barang.namaBarang ?? "");
                cmd.Parameters.AddWithValue("@deskripsi", barang.deskripsi ?? "");
                cmd.Parameters.AddWithValue("@harga_sewa", barang.hargaSewa);
                cmd.Parameters.AddWithValue("@stok", barang.stok);
                cmd.Parameters.AddWithValue("@foto", barang.fotoBarang ?? (Object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch(Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Pesan Error Database: " + err.Message, "Database Bug Detected");
                return false;
            }
           
        }
        public bool UpdateBarang(M_barang barang)
        {
            try
            {
                using var conn = dbconnect.GetConn();
                conn.Open();
                System.Windows.Forms.MessageBox.Show("ID yang akan di-update adalah: " + barang.id_barang, "Cek ID");
                string rawsql =
                    @"UPDATE barang SET
                nama_barang = @nama_barang, deskripsi = 
                @deskripsi, harga_sewa = @harga_sewa, stok = @stok, foto_barang = @foto WHERE id_barang = @id";
                using var cmd = new NpgsqlCommand(rawsql, conn);
                cmd.Parameters.AddWithValue("@id", barang.id_barang);
                cmd.Parameters.AddWithValue("@nama_barang", barang.namaBarang);
                cmd.Parameters.AddWithValue("@deskripsi", barang.deskripsi);
                cmd.Parameters.AddWithValue("@harga_sewa", barang.hargaSewa);
                cmd.Parameters.AddWithValue("@stok", barang.stok);
                cmd.Parameters.AddWithValue("@foto", barang.fotoBarang);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Pesan Error Database: " + err.Message, "Database Bug Detected");
                return false;
            }

        }
        public void UpdateStokBarang(int barangId, int qtyNew)
        {
            using var conn = dbconnect.GetConn();
            conn.Open();

            string rawsql = "UPDATE barang SET stok = @stok WHERE id=@id";
            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("@stok", qtyNew);
            cmd.Parameters.AddWithValue("@id", barangId);

            cmd.ExecuteNonQuery();
        }
        public bool DeleteBarang(int barangId)
        {
            try
            {
                using var conn = dbconnect.GetConn();
                conn.Open();

                string rawswql = "DELETE FROM barang WHERE id = @id";
                using var cmd = new NpgsqlCommand(rawswql, conn);
                cmd.Parameters.AddWithValue("@id", barangId);

                return cmd.ExecuteNonQuery() > 0;
            }catch (Exception err)
            {
                Console.WriteLine("error delete date" + err.Message);
                return false;
            }

        }





    }
}
