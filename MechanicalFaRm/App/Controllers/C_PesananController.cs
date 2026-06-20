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
        public string ProsesCo(int idUser, string alamat, string metodePembayaran ,List<M_Keranjang> keranjangs)
        {
            return _service.SubmitCheckout(idUser, alamat,metodePembayaran, keranjangs);
        }


        public string ProsesInstantCo(int idUser, string alamat, string metodePembayaran, M_Keranjang item)
        {
            if (item == null) return "Gagal: Data barang tidak valid!";

            List<M_Keranjang> listInstan = new List<M_Keranjang> { item };

            int durasiHari = (item.tglKembali - item.tglSewa).Days;
            if (durasiHari == 0) durasiHari = 3; 

            var totalBayar = (decimal)item.hargaSewa * item.jumlah * durasiHari;

            bool isSukses = _transaksirepo.PesananBaru(idUser, alamat, metodePembayaran, listInstan);

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
