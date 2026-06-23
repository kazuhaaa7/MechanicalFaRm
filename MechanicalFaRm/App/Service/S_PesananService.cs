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
        
      
        //logic
        public string  AddToKeranjang(M_Keranjang itemkeranjang)
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
            return _repopesan.AddToKeranjang(itemkeranjang);
        }

        //logic
        public string SubmitCheckout(int idUser, string alamat, string metodePembayaran, List<M_Keranjang> keranjang)
        {

            if (keranjang == null || keranjang.Count == 0)return "Gagal: Data barang tidak valid!";

            bool isSukses = _transaksiRepo.PesananBaru( idUser, alamat, metodePembayaran, keranjang);

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

        public bool UpdatePesanan(int idPesanan, string statusBaru)
        {
            return _repopesan.UpdatePesanan(idPesanan, statusBaru);
        }

        public List<M_DetailPesanan> GetAllPesananByUser(int idUser)
        {
            return _repopesan.GetAllPesananByUser(idUser);
        }

        public List<M_DetailPesanan> GetAllPesanan()
        {
            return _repopesan.GetAllPesanan();
        }

        public bool DeleteItemKeranjang(int idKeranjang)
        {
            // Memanggil metode Delete yang baru saja dibuat di Repository
            return _repopesan.DeleteDataKeranjang(idKeranjang);
        }
    }
}
