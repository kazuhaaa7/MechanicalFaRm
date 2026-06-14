using Microsoft.VisualBasic.ApplicationServices;

namespace MechanicalFaRm.App.Models
{
    public class M_Keranjang : M_DetailPesanan
    {
        public int id_barang { get; set; }
        public int idKeranjang { get; set; } 
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