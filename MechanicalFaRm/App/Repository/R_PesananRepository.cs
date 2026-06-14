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
        public List<M_DetailPesanan> GetAllPesananByUser(int idUser)
        {
            var listpesanan = new List<M_DetailPesanan>();
            using var conn = dbconnect.GetConn();
            conn.Open();

            string sql = @"SELECT p.id_pesanan, p.status,p.""totalBayar"", dp.jumlah, dp.tanggal_sewa, dp.tanggal_kembali,b.nama_barang FROM pesanan p
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
                    namaBarang = reader.GetString(6)
                };
                listpesanan.Add(detail);
            }

            return listpesanan;

        }
    }
}
