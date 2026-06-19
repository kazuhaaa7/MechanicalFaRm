using MechanicalFaRm.App.DbHelper;
using MechanicalFaRm.App.Models;
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
        public List<M_DetailPesanan> GetAllPesananByUser(int idUser)
        {
            var listpesanan = new List<M_DetailPesanan>();
            using var conn = dbconnect.GetConn();
            conn.Open();

            string sql = @"SELECT p.id_pesanan, p.status,p.""totalBayar"", dp.jumlah, dp.tanggal_sewa, dp.tanggal_kembali,b.nama_barang, b.harga_sewa FROM pesanan p
                        JOIN detail_pesanan dp on p.id_pesanan = dp.id_pesanan 
                        JOIN barang b on b.id_barang = dp.id_barang
                        JOIN public.user u on u.id_user = p.id_user
                        WHERE u.id_user=@id_user 
                        ORDER BY p.id_pesanan";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_user", idUser);
            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("Data belum ada");
            }
            while (reader.Read())
            {
                var detail = new M_DetailPesanan
                {
                    id_pesanan = reader.GetInt32(0),
                    status = reader.GetString(1),
                    total = reader.GetInt32(2),
                    jumlah = reader.GetInt32(3),
                    tglSewa = reader.GetDateTime(4),
                    tglKembali = reader.GetDateTime(5),
                    namaBarang = reader.GetString(6),
                    hargaSewa = reader.GetInt32(7)
                };
                listpesanan.Add(detail);
            }

            return listpesanan;

        }

        public List<M_Keranjang> GetListKeranjang(int id)
        {
            return listKeranjang;
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
            else
            {
                TimeSpan totalHariSewa = itemkeranjang.tglKembali - itemkeranjang.tglSewa;
                int selsisih = totalHariSewa.Days;
            }
            listKeranjang.Add(itemkeranjang);
            return "sukses";
        }

        //public M_Struk GetStrukData(int idPesanan)
        //{
        //    M_Struk struk = new M_Struk();
        //    using var conn = dbconnect.GetConn(); // Sesuaikan dengan helper DB-mu
        //    conn.Open();

        //    // 1. QUERY INDUK: Ambil data pesanan dan nama dari tabel users
        //    // ⚠️ GANTI 'users' dan 'nama_kolom_di_db' sesuai nama asli di DB-mu!
        //    string sqlInduk = @"SELECT p.id_pesanan, u.nama_kolom_di_db, p.status, p.""totalBayar"" 
        //                        FROM pesanan p
        //                        JOIN users u ON p.id_user = u.id_user
        //                        WHERE p.id_pesanan = @id_pesanan";

        //    using (var cmd = new NpgsqlCommand(sqlInduk, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@id_pesanan", idPesanan);
        //        using var reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            struk.id_pesanan = reader.GetInt32(0);
        //            struk.namaPenyewa = reader.GetString(1);
        //            struk.status = reader.GetString(2);
        //            struk.totalBayar = reader.GetDecimal(3);
        //        }
        //    }

        //    // 2. QUERY ANAK: Ambil rincian barang yang disewa di dalam pesanan tersebut
        //    string sqlAnak = @"SELECT b.nama_barang, dp.jumlah, dp.subtotal, dp.tanggal_sewa, dp.tanggal_kembali 
        //                       FROM detail_pesanan dp
        //                       JOIN barang b ON dp.id_barang = b.id_barang
        //                       WHERE dp.id_pesanan = @id_pesanan";

        //    using (var cmdAnak = new NpgsqlCommand(sqlAnak, conn))
        //    {
        //        cmdAnak.Parameters.AddWithValue("@id_pesanan", idPesanan);
        //        using var readerAnak = cmdAnak.ExecuteReader();
        //        while (readerAnak.Read())
        //        {
        //            struk.detailBarang.Add(new M_DetailStrukBarang
        //            {
        //                namaBarang = readerAnak.GetString(0),
        //                jumlah = readerAnak.GetInt32(1),
        //                subtotal = readerAnak.GetDecimal(2),
        //                tglSewa = readerAnak.GetDateTime(3),
        //                tglKembali = readerAnak.GetDateTime(4)
        //            });
        //        }
        //    }

        //    return struk;
        //}
    }
}
