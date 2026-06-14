using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Repository;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using System.Web;

namespace MechanicalFaRm.App.Service
{
    internal class S_PesananService : S_IPesananService
    {
        private static List<M_Keranjang> listKeranjang = new List<M_Keranjang>();
        private R_TransaksiRepository _transaksiRepo =  new R_TransaksiRepository();
        private R_PesananRepository _repopesan = new R_PesananRepository();

        public List<M_Keranjang> GetListKeranjang()
        {
            return listKeranjang;
        }

        public string  AddToKeranjang(M_Keranjang itemkeranjang)
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
            if (listKeranjang.Count == 0)
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
    }
}
