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
        public string TambahKeranjanag(M_Keranjang newitem)
        {
            // Implementation for adding item to cart
            return "Item added to cart successfully.";
        }
        private static List<M_Keranjang> listKeranjang = new List<M_Keranjang>();
        private R_TransaksiRepository _transaksiRepo =  new R_TransaksiRepository();

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
            else if ((itemkeranjang.tglKembali - itemkeranjang.tglSewa).Days <= 3)
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

        //public string SubmitTransaksi(M_Keranjang itemkeranjang)
        //{
        //    // Implementation for submitting the transaction
        //    _transaksiRepo.InsertTransaksi(itemkeranjang);
        //    return "Transaction submitted successfully.";
        //}
    }
}
