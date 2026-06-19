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
        private static List<M_Keranjang> listKeranjang = new List<M_Keranjang>();
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

        public decimal HitungTotalKeseluruhan()
        {
            decimal gtotal = 0;
            foreach (var item in listKeranjang) 
            {
                int durasi = (item.tglKembali - item.tglSewa).Days;
                if (durasi == 0) durasi = 3;
                gtotal += (item.hargaSewa * item.jumlah * durasi);
            }
            return gtotal;
        }

        public string SubmitCheckout(int idUser)
        {

            if (_repopesan.GetListKeranjang(idUser).Count == 0)
            {
                return "Gagal: Keranjang belanja Anda masih kosong!";
            }

            decimal totalBayar = HitungTotalKeseluruhan();

            bool isSukses = _transaksiRepo.PesananBaru(listKeranjang, totalBayar, idUser);

            if (isSukses)
            {
                listKeranjang.Clear(); 
                return "Sukses";
            }
            else
            {
                return "Gagal: Terjadi kesalahan saat menyimpan ke database.";
            }
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
                    } // 👈 Reader Induk otomatis TERTUTUP di sini, sekarang koneksi aman digunakan lagi!
                }

                // 2. Ambil rincian barang untuk setiap pesanan
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
                                // Pastikan nama class penampungmu adalah M_DetailPesanan atau M_DetailPesananBarang
                                pesanan.detailBarang.Add(new M_DetailPesanan
                                {
                                    namaBarang = readerAnak.GetString(0),
                                    jumlah = readerAnak.GetInt32(1)
                                });
                            }
                        } // 👈 Reader Anak otomatis tertutup setiap satu putaran barang selesai
                    }
                }
            } // 👈 Koneksi utama otomatis tertutup di sini

            return listData;
        }

        public bool UpdateStatusPesanan(int idPesanan, string statusBaru, string namaJalanBaru, int idUserLogin)
        {
            bool isSukses = false;

            using (var conn = dbconnect.GetConn())
            {
                conn.Open();

                // Menggunakan Database Transaction agar data sinkron dan aman dari crash
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // LANGKAH 1: Masukkan data jalan baru ke tabel 'jalan' dan dapatkan id_jalan
                        int idJalanTerbuat = 0;
                        string sqlJalan = @"INSERT INTO jalan (nama_jalan) VALUES (@nama_jalan) RETURNING id_jalan;";
                        using (var cmdJalan = new NpgsqlCommand(sqlJalan, conn))
                        {
                            cmdJalan.Parameters.AddWithValue("@nama_jalan", namaJalanBaru);
                            idJalanTerbuat = Convert.ToInt32(cmdJalan.ExecuteScalar());
                        }

                        // LANGKAH 2: Daftarkan id_jalan dan id_user yang sedang login ke tabel 'alamat'
                        string sqlAlamat = @"INSERT INTO alamat (id_user, id_jalan) VALUES (@id_user, @id_jalan);";
                        using (var cmdAlamat = new NpgsqlCommand(sqlAlamat, conn))
                        {
                            cmdAlamat.Parameters.AddWithValue("@id_user", idUserLogin);
                            cmdAlamat.Parameters.AddWithValue("@id_jalan", idJalanTerbuat);
                            cmdAlamat.ExecuteNonQuery();
                        }

                        // LANGKAH 3: Update status transaksi pada tabel 'pesanan' menjadi 'Lunas'
                        string sqlPesanan = @"UPDATE pesanan SET status = @status WHERE id_pesanan = @id_pesanan;";
                        using (var cmdPesanan = new NpgsqlCommand(sqlPesanan, conn))
                        {
                            cmdPesanan.Parameters.AddWithValue("@status", statusBaru);
                            cmdPesanan.Parameters.AddWithValue("@id_pesanan", idPesanan);

                            int barisTerpengaruh = cmdPesanan.ExecuteNonQuery();
                            if (barisTerpengaruh > 0)
                            {
                                isSukses = true;
                            }
                        }

                        // Jika semua langkah aman, kunci perubahan ke dalam PostgreSQL
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Jika ada error, batalkan semua tahap agar tidak ada data sampah
                        transaction.Rollback();
                        MessageBox.Show("Gagal memproses pembayaran dan alamat: " + ex.Message, "Error DB Transaction");
                        isSukses = false;
                    }
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


                string sqlInduk = @"SELECT p.id_pesanan, u.nama, p.""totalBayar"", p.status 
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
                            M_user userObjek = new M_user();
                            userObjek.namaPenyewa = reader.IsDBNull(1) ? "" : reader.GetString(1);

                            M_jalan jalanObjek = new M_jalan();

                            pesanan = new M_Pesanan
                            {
                                id_pesanan = reader.GetInt32(0),
                                Penyewa = userObjek,
                                total = Convert.ToInt32(reader[2]),
                                status = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                jalan = jalanObjek,
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
    }
}
