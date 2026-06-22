using MechanicalFaRm.App.DbHelper;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Session;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MechanicalFaRm.App.Repository
{
    internal class R_TransaksiRepository 
    {
        public bool PesananBaru(int idUser, string alamat, string metodePembayaran, List<M_Keranjang> keranjang)
        {
            using var conn = dbconnect.GetConn();
            conn.Open();
            using var transaksiDB = conn.BeginTransaction();    

            try
            {
                string namaPenyewa = keranjang.Count > 0 ? (keranjang[0].Penyewa?.namaPenyewa ?? "") : "";
                if (!string.IsNullOrWhiteSpace(namaPenyewa))
                {
                    string queryUser = @"UPDATE ""user"" SET nama = @nama_penyewa WHERE id_user = @id_user;";
                    using (NpgsqlCommand cmdUser = new NpgsqlCommand(queryUser, conn, transaksiDB))
                    {
                        cmdUser.Parameters.AddWithValue("@id_user", idUser);
                        cmdUser.Parameters.AddWithValue("@nama_penyewa", namaPenyewa);
                        cmdUser.ExecuteNonQuery();
                    }
                }
                //else
                //{
                //    MessageBox.Show("Nama kosong");
                //}
                decimal totalKeseluruhan = 0;
                foreach (var item in keranjang)
                {
                    int durasi = (item.tglKembali - item.tglSewa).Days;
                    if (durasi <= 0) durasi = 3;
                    totalKeseluruhan += (decimal)item.hargaSewa * item.jumlah * durasi;
                }

                string queryInduk = @"INSERT INTO pesanan (id_user, status, total_bayar, alamat_jalan, metode_pembayaran) 
                              VALUES (@id_user, @status, @total, @alamat, @mp) 
                              RETURNING id_pesanan;";

                int idPesananBaru = 0;
                using (NpgsqlCommand cmdInduk = new NpgsqlCommand(queryInduk, conn, transaksiDB))
                {
                    cmdInduk.Parameters.AddWithValue("@id_user", idUser);
                    cmdInduk.Parameters.AddWithValue("@status", "Menunggu Verifikasi Admin");
                    cmdInduk.Parameters.AddWithValue("@total", totalKeseluruhan);   
                    cmdInduk.Parameters.AddWithValue("@alamat", string.IsNullOrWhiteSpace(alamat) ? (object)DBNull.Value : alamat);
                    cmdInduk.Parameters.AddWithValue("@mp", metodePembayaran);
                    idPesananBaru = Convert.ToInt32(cmdInduk.ExecuteScalar());
                }

                string queryAnak = @"INSERT INTO detail_pesanan (id_pesanan, id_barang, jumlah, subtotal, tanggal_sewa, tanggal_kembali) 
                             VALUES (@id_pesanan, @id_barang, @jumlah, @subtotal, @tgl_sewa, @tgl_kembali)";
                string queryStok = "UPDATE barang SET stok = stok - @jumlah WHERE id_barang = @id_barang";

                foreach (var item in keranjang)
                {
                    using (NpgsqlCommand cmdAnak = new NpgsqlCommand(queryAnak, conn, transaksiDB))
                    {
                        cmdAnak.Parameters.AddWithValue("@id_pesanan", idPesananBaru);
                        cmdAnak.Parameters.AddWithValue("@id_barang", Convert.ToInt32(item.id_barang));
                        cmdAnak.Parameters.AddWithValue("@jumlah", item.jumlah);

                        int durasiHari = (item.tglKembali - item.tglSewa).Days;
                        if (durasiHari == 0) durasiHari = 3;
                        decimal subtotalItem = (decimal)item.hargaSewa * item.jumlah * durasiHari;

                        cmdAnak.Parameters.AddWithValue("@subtotal", subtotalItem);
                        cmdAnak.Parameters.AddWithValue("@tgl_sewa", item.tglSewa);
                        cmdAnak.Parameters.AddWithValue("@tgl_kembali", item.tglKembali);
                        cmdAnak.ExecuteNonQuery();
                    }

                    using (NpgsqlCommand cmdStok = new NpgsqlCommand(queryStok, conn, transaksiDB))
                    {
                        cmdStok.Parameters.AddWithValue("@jumlah", item.jumlah);
                        cmdStok.Parameters.AddWithValue("@id_barang", Convert.ToInt32(item.id_barang));
                        cmdStok.ExecuteNonQuery();
                    }
                }

                transaksiDB.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaksiDB.Rollback();
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
        public void ClearKeranjang(int idUser)
        {
            using (var conn = dbconnect.GetConn())
            {
                conn.Open();
                string query = "DELETE FROM keranjang WHERE id_user = @id_user;";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", idUser);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

