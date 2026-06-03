using MechanicalFaRm.App.DbHelper;
using MechanicalFaRm.App.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalFaRm.App.Repository
{
    internal class BarangRepository : IBarangRepository
    {

        public List<M_barang> GetListBarang() //public: supaya bisa diakses lewat class interface(IBarangRepo)
        {
            var daftarBarang = new List<M_barang>();
            using var conn = dbconnect.getConn();
            conn.Open();

            string rawsql = "SELECT * FROM barang WHERE stok >1 ORDER BY id_users ASC";
            using var cmd = new NpgsqlCommand(rawsql, conn);
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

        public List<M_barang> GetListBarang(int limit)
        {
            var daftarBarang = new List<M_barang>();
            using var conn = dbconnect.getConn();
            conn.Open();
            string rawsql = $"SELECT * FROM barang WHERE stok >1 ORDER BY id_users ASC LIMIT @limit";

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
            using var conn = dbconnect.getConn();
            conn.Open();

            string rawsql = "SELECT * FROM barang WHERE id = @id";
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
            using var conn = dbconnect.getConn();
            conn.Open();
            string rawsql = @"SELECT * FROM 
            barang WHERE stok >0 AND stok < 5
            ORDER BY id_users ASC LIMIT 1";

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
        public void InsertBarang(M_barang barang)
        {
            using var conn = dbconnect.getConn();
            conn.Open();

            string rawsql = 
                @"INSERT INTO 
                barang (nama_barang, deskripsi, harga_sewa, stok)
                VALUES (@nama_barang, @deskripsi, @harga_sewa, @stok)";

            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("nama_barang", barang.namaBarang);
            cmd.Parameters.AddWithValue("deskripsi", barang.deskripsi);
            cmd.Parameters.AddWithValue("harga_sewa", barang.hargaSewa);
            cmd.Parameters.AddWithValue("stok", barang.stok);

            cmd.ExecuteNonQuery();
        }
        public void UpdateBarang(M_barang barang)
        {
            using var conn = dbconnect.getConn();
            conn.Open();

            string rawsql = 
                @"UPDATE barang SET
                nama_barang = @nama_barang, deskripsi = 
                @deskripsi, harga_sewa = @harga_sewa, stok = @stok WHERE id = @id";
            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("nama_barang", barang.namaBarang);
            cmd.Parameters.AddWithValue("deskripsi", barang.deskripsi);
            cmd.Parameters.AddWithValue("harga_sewa", barang.hargaSewa);
            cmd.Parameters.AddWithValue("stok", barang.stok);

            cmd.ExecuteNonQuery();

        }
        public void UpdateStokBarang(int barangId, int qtyNew)
        {
            using var conn = dbconnect.getConn();
            conn.Open();

            string rawsql = "UPDATE barang SET stok = @stok WHERE id=@id";
            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("@stok", qtyNew);
            cmd.Parameters.AddWithValue("@id", barangId);

            cmd.ExecuteNonQuery();
        }
        public void DeleteBarang(int barangId)
        {
            using var conn = dbconnect.getConn();
            conn.Open();

            string rawswql = "DELETE FROM barang WHERE id = @id";
            using var cmd = new NpgsqlCommand(rawswql, conn);
            cmd.Parameters.AddWithValue("id", barangId);

            cmd.ExecuteNonQuery();
        }
    }
}
