using MechanicalFaRm.App.DbHelper;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Repository;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MechanicalFaRm.App.Service
{
    internal class S_PesananService : S_IPesananService
    {
        private List<M_Keranjang> listKeranjang = new List<M_Keranjang>();
        private R_TransaksiRepository _transaksiRepo =  new R_TransaksiRepository();
        private R_PesananRepository _repopesan = new R_PesananRepository();

       public List<M_Keranjang> GetListKeranjang(int id)
        {   
            return _repopesan.GetListKeranjang(id);
        }
        
      

        public string  AddToKeranjang(M_Keranjang itemkeranjang)
        {
            return _repopesan.AddToKeranjang(itemkeranjang);
        }

        public string SubmitCheckout(int idUser, string alamat, List<M_Keranjang> keranjang)
        {
            var keranjangDB = _repopesan.GetListKeranjang(idUser);

            if (keranjangDB.Count == 0)
            {
                return "Gagal: Keranjang belanja Anda masih kosong!";
            }

            if (keranjang == null || keranjang.Count == 0)
                return "Gagal: Data barang tidak valid!";

            bool isSukses = _transaksiRepo.PesananBaru(keranjang, idUser, alamat);

            return isSukses ? "Sukses" : "Gagal: Terjadi kesalahan saat menyimpan ke database.";
        }

        public List<M_DetailPesanan> GetAllPesanan(int id)
        {
            return _repopesan.GetAllPesananByUser(id);
            
        }

        public string GetNamaPenyewaLama(int idUser)
        {
            return _repopesan.GetNamaPenyewaLama(idUser);
        }
        public int GetIdPesananTerbaru(int idUser)
        {
            using var conn = dbconnect.GetConn();
            conn.Open();
            string sql = "SELECT id_pesanan FROM pesanan WHERE id_user = @id_user ORDER BY id_pesanan DESC LIMIT 1;";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_user", idUser);

            object res = cmd.ExecuteScalar();
            return res != null ? Convert.ToInt32(res) : 0;
        }

        public List<M_Pesanan> GetPesananBelumBayar(int idUser)
        {
            List<M_Pesanan> listData = new List<M_Pesanan>();

            // Gunakan blok using agar koneksi otomatis tertutup jika terjadi error
            using (var conn = dbconnect.GetConn())
            {
                conn.Open();

                // 1. Ambil data induk pesanan
                string sqlInduk = @"SELECT p.id_pesanan, u.nama, p.""totalBayar"", p.status 
                            FROM pesanan p 
                            JOIN public.user u ON p.id_user = u.id_user 
                            WHERE p.id_user = @id_user AND p.status = 'Menunggu Verifikasi Admin' 
                            ORDER BY p.id_pesanan DESC";

                using (var cmd = new NpgsqlCommand(sqlInduk, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", idUser);

                    // Menggunakan using pada reader agar langsung bersih setelah loop selesai
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            M_user userObjek = new M_user();
                            userObjek.namaPenyewa = reader.GetString(1);
                            listData.Add(new M_Pesanan
                            {
                                id_pesanan = reader.GetInt32(0),
                                Penyewa = userObjek,
                                total = reader.GetInt32(2),   
                                status = reader.GetString(3)
                            });
                        }
                    } 
                }

                
                foreach (var pesanan in listData)
                {
                    string sqlAnak = @"SELECT b.nama_barang, dp.jumlah 
                               FROM detail_pesanan dp 
                               JOIN barang b ON dp.id_barang = b.id_barang 
                               WHERE dp.id_pesanan = @id_pesanan";

                    using (var cmdAnak = new NpgsqlCommand(sqlAnak, conn))
                    {
                        cmdAnak.Parameters.AddWithValue("@id_pesanan", pesanan.id_pesanan);

                        using (var readerAnak = cmdAnak.ExecuteReader())
                        {
                            while (readerAnak.Read())
                            {
         
                                pesanan.detailBarang.Add(new M_DetailPesanan
                                {
                                    namaBarang = readerAnak.GetString(0),
                                    jumlah = readerAnak.GetInt32(1)
                                });
                            }
                        } 
                    }
                }
            } 

            return listData;
        }

        public bool UpdatePesanan(int idPesanan, string statusBaru, string namaJalanBaru, int idUserLogin)
        {
            bool isSukses = false;

            using (var conn = dbconnect.GetConn())
            {
                conn.Open();

                // Kita tidak butuh BeginTransaction jika hanya meng-update 1 tabel
                try
                {
                    // Cukup 1 query ini saja: update status DAN alamat sekaligus
                    string sql = @"UPDATE pesanan 
                           SET status = @status, 
                               alamat_jalan = @alamat 
                           WHERE id_pesanan = @id_pesanan AND id_user = @id_user;";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", statusBaru);
                        cmd.Parameters.AddWithValue("@alamat", namaJalanBaru);
                        cmd.Parameters.AddWithValue("@id_pesanan", idPesanan);
                        cmd.Parameters.AddWithValue("@id_user", idUserLogin);

                        int barisTerpengaruh = cmd.ExecuteNonQuery();

                        if (barisTerpengaruh > 0)
                        {
                            isSukses = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengupdate pesanan: " + ex.Message, "Error Database");
                    isSukses = false;
                }
            }

            return isSukses;
        }

        public M_Pesanan GetPesananById(int idPesanan)
        {
            M_Pesanan pesanan = null;

            using (var conn = dbconnect.GetConn())
            {
                conn.Open();

                string sqlInduk = @"SELECT p.id_pesanan, u.nama, p.total_bayar, p.status 
                            FROM pesanan p 
                            JOIN public.user u ON p.id_user = u.id_user 
                            WHERE p.id_pesanan = @id_pesanan";

                using (var cmd = new NpgsqlCommand(sqlInduk, conn))
                {
                    cmd.Parameters.AddWithValue("@id_pesanan", idPesanan);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pesanan = new M_Pesanan
                            {
                                id_pesanan = reader.GetInt32(0),
                                Penyewa = new M_user { namaPenyewa = reader.IsDBNull(1) ? "" : reader.GetString(1) },
                                total = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                                status = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                detailBarang = new List<M_DetailPesanan>()
                            };
                        }
                    }
                }

                if (pesanan != null)
                {
                    string sqlAnak = @"SELECT b.nama_barang, dp.jumlah 
                               FROM detail_pesanan dp 
                               JOIN barang b ON dp.id_barang = b.id_barang 
                               WHERE dp.id_pesanan = @id_pesanan";

                    using (var cmdAnak = new NpgsqlCommand(sqlAnak, conn))
                    {
                        cmdAnak.Parameters.AddWithValue("@id_pesanan", idPesanan);

                        using (var readerAnak = cmdAnak.ExecuteReader())
                        {
                            while (readerAnak.Read())
                            {
                                pesanan.detailBarang.Add(new M_DetailPesanan
                                {
                                    namaBarang = readerAnak.IsDBNull(0) ? "" : readerAnak.GetString(0),
                                    jumlah = readerAnak.GetInt32(1)
                                });
                            }
                        }
                    }
                }
            }
            return pesanan;
        }

        public List<M_DetailPesanan> GetAllPesananByUser(int idUser)
        {
            return _repopesan.GetAllPesananByUser(idUser);
        }

        public List<M_DetailPesanan> GetAllPesanan()
        {
            return _repopesan.GetAllPesanan();
        }
    }
}
