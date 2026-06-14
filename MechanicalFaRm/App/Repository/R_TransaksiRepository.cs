using MechanicalFaRm.App.DbHelper;
using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Security.Cryptography;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Session;

namespace MechanicalFaRm.App.Repository
{
    internal class R_TransaksiRepository 
    {
//        Menerima data bersih dari Service yang sudah tervalidasi.

//Melakukan interaksi murni dengan Database.

//Contoh: Membuka koneksi SQL, menjalankan perintah INSERT INTO Tabel_Keranjang..., dan menutup koneksi.

//Mengembalikan status sukses atau gagal ke Service.


        public void BuatPesananBaru(M_Pesanan pesanan)
        {
            using var conn = dbconnect.GetConn();
            conn.Open();

            string sql = @"INSERT INTO pesanan (id_pesanan, tanggal_pesan, tanggal_kembali,status)
                        VALUES (@id, @tglP, @tglK, @status)";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", pesanan.id_pesanan);
            //cmd.Parameters.AddWithValue("@tglP", pesanan.tglSewa);
            //cmd.Parameters.AddWithValue("@tglK", pesanan.tglKembali);
            //cmd.Parameters.AddWithValue("@status", pesanan.statusPesanan);

            cmd.ExecuteNonQuery();

        }

        public bool PesananBaru(List<M_Keranjang> keranjang, decimal totalBayar, int idUser)
        {
            using var conn = dbconnect.GetConn();
            conn.Open();

            using var transaksiDB = conn.BeginTransaction();

            try
            {

                string queryInduk = @"
                                        INSERT INTO pesanan (id_user, status, ""totalBayar"") 
                                            VALUES (@id_user, @status, @total) 
                                            RETURNING id_pesanan;";

                int idPesananBaru = 0;

                using (NpgsqlCommand cmdInduk = new NpgsqlCommand(queryInduk, conn, transaksiDB))
                {
                    cmdInduk.Parameters.AddWithValue("@id_user",idUser);
                    cmdInduk.Parameters.AddWithValue("@status", "Menunggu Verifikasi Admin");
                    cmdInduk.Parameters.AddWithValue("@total", totalBayar);
                    idPesananBaru = Convert.ToInt32(cmdInduk.ExecuteScalar());
                }


                string queryAnak = @"
            INSERT INTO detail_pesanan (id_pesanan, id_barang, jumlah, subtotal, tanggal_sewa, tanggal_kembali) 
            VALUES (@id_pesanan, @id_barang, @jumlah, @subtotal, @tgl_sewa, @tgl_kembali)";

                foreach (var item in keranjang)
                {
                    using (NpgsqlCommand cmdAnak = new NpgsqlCommand(queryAnak, conn, transaksiDB))
                    {
                        cmdAnak.Parameters.AddWithValue("@id_pesanan", idPesananBaru);
                        cmdAnak.Parameters.AddWithValue("@id_barang", Convert.ToInt32(item.id_barang));
                        cmdAnak.Parameters.AddWithValue("@jumlah", item.jumlah);


                        int durasiHari = (item.tglKembali - item.tglSewa).Days;
                        if (durasiHari == 0) durasiHari = 3; 
                        decimal subtotalItem = item.hargaSewa * item.jumlah * durasiHari;

                        cmdAnak.Parameters.AddWithValue("@subtotal", subtotalItem);
                        cmdAnak.Parameters.AddWithValue("@tgl_sewa", item.tglSewa);
                        cmdAnak.Parameters.AddWithValue("@tgl_kembali", item.tglKembali);
                        cmdAnak.ExecuteNonQuery();
                    }

                    string queryStok = "UPDATE barang SET stok = stok - @jumlah WHERE id_barang = @id_barang";

                    using (NpgsqlCommand cmdStok = new NpgsqlCommand(queryStok, conn, transaksiDB))
                    {
                        cmdStok.Parameters.AddWithValue("@jumlah", item.jumlah);
                        cmdStok.Parameters.AddWithValue("@id_barang", Convert.ToInt32(item.id_barang));
                        cmdStok.ExecuteNonQuery(); // Tembak ke database untuk mengurangi stok
                    }
                }

                transaksiDB.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaksiDB.Rollback();
                MessageBox.Show($"{ex.Message}");
                return false;
            }
        }

    }
}
