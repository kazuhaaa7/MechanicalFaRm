using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Repository;
using MechanicalFaRm.App.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicalFaRm.App.Controllers
{
    public class C_PesananController
    {
        private S_PesananService _service = new S_PesananService();
        private R_TransaksiRepository _transaksirepo = new R_TransaksiRepository();
        public string ProsesCo(int idUser)
        {
            return _service.SubmitCheckout(idUser);
        }
        public string ProsesInstantCo(M_Keranjang item, int idUser)
        {
            if (item == null) return "Gagal: Data barang tidak valid!";

            // 1. Masukkan 1 barang ini ke dalam List instan khusus transaksi langsung
            List<M_Keranjang> listInstan = new List<M_Keranjang> { item };

            // 2. Hitung total bayar untuk 1 barang ini (Sesuai dengan rumus durasi hari di Repository-mu)
            int durasiHari = (item.tglKembali - item.tglSewa).Days;
            if (durasiHari == 0) durasiHari = 3; // Aturan minimal 3 hari milikmu

            decimal totalBayar = item.hargaSewa * item.jumlah * durasiHari;

            // 3. Tembak langsung ke fungsi transaksi database rapi milikmu tanpa cek keranjang kosong!
            bool isSukses = _transaksirepo.PesananBaru(listInstan, totalBayar, idUser);

            if (isSukses)
            {
                return "Sukses";
            }
            else
            {
                return "Gagal: Terjadi kesalahan saat menyimpan ke database.";
            }
        }
    }
}
