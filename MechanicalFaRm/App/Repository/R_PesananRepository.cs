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
            // Validasi tanggal sewa dan kembali


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
    }
}
