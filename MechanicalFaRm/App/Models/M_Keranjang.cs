using Microsoft.VisualBasic.ApplicationServices;

namespace MechanicalFaRm.App.Models
{
    public class M_Keranjang : M_Pesanan
    {
        public decimal jumlah;
        public M_user? Penyewa { get; set; }

        //public M_Keranjang(int idkeranjang, int idusers,
        //                   int idbarang, decimal jumlah)
        //{
        //    this.idKeranjang = idkeranjang;
        //    this.idUsers = idusers;
        //    this.idBarang = idbarang;
        //    this.jumlah = jumlah;
        //}
    }
}