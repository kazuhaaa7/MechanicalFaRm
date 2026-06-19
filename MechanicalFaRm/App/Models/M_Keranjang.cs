using Microsoft.VisualBasic.ApplicationServices;

namespace MechanicalFaRm.App.Models
{
    public class M_Keranjang : M_DetailPesanan
    {
        public int id_barang { get; set; }
        public int id_keranjang { get; set; } 
        public decimal jumlah;
        public M_user? Penyewa { get; set; }
        public int Durasi { get; set; }

        public decimal subTotalKeranjang {
            get
            {
                return (decimal)hargaSewa * jumlah * Durasi;
            }
                }

    }
}