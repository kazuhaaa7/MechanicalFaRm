using MechanicalFaRm.App.DbHelper;
using MechanicalFaRm.App.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace MechanicalFaRm.App.Repository
{

    public class R_PesananRepository 
    {
        private static List<M_Keranjang> listKeranjang = new List<M_Keranjang>();
        private static List<M_Keranjang> listRiwayat = new List<M_Keranjang>();
        public static HashSet<int> listPesananTersubmit = new HashSet<int>();
        public List<M_DetailPesanan> GetAllPesananByUser(int idUser)
        {
            var listpesanan = new List<M_DetailPesanan>();
            using var conn = dbconnect.GetConn();
            conn.Open();

            string sql = @"SELECT 
                    u.nama, 
                    b.nama_barang,
                    dp.jumlah, 
                    b.harga_sewa, 
                    (dp.tanggal_kembali - dp.tanggal_sewa)::INT AS durasi,
                    p.total_bayar, 
                    p.status
                   FROM pesanan p
                   JOIN detail_pesanan dp ON p.id_pesanan = dp.id_pesanan 
                   JOIN barang b ON b.id_barang = dp.id_barang
                   JOIN public.user u ON u.id_user = p.id_user
                   WHERE u.id_user = @id_user 
                   ORDER BY p.id_pesanan ";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_user", idUser);

            using var reader = cmd.ExecuteReader();


            // Menggunakan while langsung tanpa if (!reader.Read()) agar tidak membuang data baris pertama
            while (reader.Read())
            {
                var detail = new M_DetailPesanan
                {
                    PenyewaDP= new M_user
                    {
                        namaPenyewa = reader.GetString(0)
                    },
                    namaBarang = reader.GetString(1),     
                    jumlah = reader.GetInt32(2),         
                    hargaSewa = reader.GetInt32(3),
                    Durasi = Convert.ToInt32(reader.GetValue(4)),
                    total = reader.GetInt32(5),          
                    status = reader.GetString(6)      
                };
                listpesanan.Add(detail);
            }

            if (listpesanan.Count == 0)
            {
                MessageBox.Show("Data belum ada");
            }

            return listpesanan;
        }

        public List<M_Keranjang> GetListKeranjang(int idUser)
        {
            List<M_Keranjang> list = new List<M_Keranjang>();

            using (var conn = dbconnect.GetConn())
            {
                conn.Open();
                string sql = @"SELECT k.id_keranjang, k.id_barang, k.jumlah, k.tgl_sewa, k.tgl_kembali, 
                      b.nama_barang, b.harga_sewa, u.nama 
               FROM keranjang k
               JOIN barang b ON k.id_barang = b.id_barang
               JOIN public.user u ON k.id_user = u.id_user 
               WHERE k.id_user = @id_user";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", idUser);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime tglSewa = reader.GetDateTime(3);
                            DateTime tglKembali = reader.GetDateTime(4);
                            int durasi = (tglKembali - tglSewa).Days;
                            if (durasi == 0) durasi = 3; // Minimal sewa 3 hari sesuai aturan Anda

                            list.Add(new M_Keranjang
                            {
                                id_keranjang = reader.GetInt32(0),
                                id_barang = reader.GetInt32(1),
                                jumlah = reader.GetInt32(2),
                                tglSewa = tglSewa,
                                tglKembali = tglKembali,
                                namaBarang = reader.GetString(5),
                                hargaSewa = (int)reader.GetInt64(6), // Sesuaikan dengan tipe data BIGINT Anda
                                Durasi = durasi,
                                Penyewa = new M_user
                                {
                                    namaPenyewa = reader.GetString(7)
                                }
                            });
                        }
                    }
                }
            }
            return list;
        }
        public string GetNamaPenyewaLama(int idUser)
        {
            using var conn = dbconnect.GetConn(); // Sesuaikan dengan helper database milikmu
            conn.Open();

            // Cari nama penyewa dari transaksi terakhir milik user ini
            string rawsql = "SELECT nama FROM public.user WHERE id_user = @id_user LIMIT 1";

            using var cmd = new NpgsqlCommand(rawsql, conn);
            cmd.Parameters.AddWithValue("@id_user", idUser);

            object result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : string.Empty;
        }

        public string AddToKeranjang(M_Keranjang itemkeranjang)
        {
            // 1. Validasi Tanggal (Tetap dipertahankan)
            if (itemkeranjang.tglKembali < itemkeranjang.tglSewa)
            {
                MessageBox.Show("Tanggal kembali tidak boleh lebih awal dari tanggal sewa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "gagal";
            }
            else if ((itemkeranjang.tglKembali - itemkeranjang.tglSewa).Days < 2)
            {
                MessageBox.Show("Minimal penyewaan 3 hari!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "gagal";
            }

            try
            {
                using (var conn = dbconnect.GetConn())
                {
                    conn.Open();
                    string sql = @"INSERT INTO keranjang (id_user, id_barang, jumlah, tgl_sewa, tgl_kembali) 
                           VALUES (@id_user, @id_barang, @jumlah, @tgl_sewa, @tgl_kembali)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_user", itemkeranjang.Penyewa._id_user);
                        cmd.Parameters.AddWithValue("@id_barang", itemkeranjang.id_barang);
                        cmd.Parameters.AddWithValue("@jumlah", itemkeranjang.jumlah);
                        cmd.Parameters.AddWithValue("@tgl_sewa", itemkeranjang.tglSewa);
                        cmd.Parameters.AddWithValue("@tgl_kembali", itemkeranjang.tglKembali);

                        cmd.ExecuteNonQuery();
                    }
                }
                return "sukses";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah ke keranjang: " + ex.Message);
                return "gagal";
            }
        }

        public List<M_DetailPesanan> GetAllPesanan()
        {
            var listpesanan = new List<M_DetailPesanan>();
            using var conn = dbconnect.GetConn();
            conn.Open();

            string sql = @"SELECT 
                    u.id_user, 
                    b.nama_barang,
                    dp.jumlah, 
                    b.harga_sewa, 
                    (dp.tanggal_kembali - dp.tanggal_sewa)::INT AS durasi,
                    p.total_bayar, 
                    p.status
                   FROM pesanan p
                   JOIN detail_pesanan dp ON p.id_pesanan = dp.id_pesanan 
                   JOIN barang b ON b.id_barang = dp.id_barang
                   LEFT JOIN ""user"" u ON u.id_user = p.id_user
                   ORDER BY p.id_pesanan ";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();


            // Menggunakan while langsung tanpa if (!reader.Read()) agar tidak membuang data baris pertama
            while (reader.Read())
            {
                var detail = new M_DetailPesanan
                {
                    PenyewaDP = new M_user { _id_user = reader.IsDBNull(0) ? 0 : reader.GetInt32(0) },
                    namaBarang = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    jumlah = Convert.ToInt32(reader.GetValue(2)),
                    hargaSewa = Convert.ToInt32(reader.GetValue(3)),
                    Durasi = Convert.ToInt32(reader.GetValue(4)),
                    total = Convert.ToInt32(reader.GetValue(5)),
                    status = reader.IsDBNull(6) ? "" : reader.GetString(6)
                };
                listpesanan.Add(detail);
            }

            if (listpesanan.Count == 0)
            {
                MessageBox.Show("Data belum ada");
            }

            return listpesanan;
        }



    }
}
