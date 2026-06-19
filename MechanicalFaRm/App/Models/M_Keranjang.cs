using Microsoft.VisualBasic.ApplicationServices;

namespace MechanicalFaRm.App.Models
{
    public class M_Keranjang : M_DetailPesanan
    {
        public int id_barang { get; set; }
        public int idKeranjang { get; set; } 
        public decimal jumlah;
        public M_user? Penyewa { get; set; }
        public int Durasi
        {
            get
            {
                TimeSpan selisih = tglKembali.Date - tglSewa.Date;

                int totalHari = selisih.Days;


                return totalHari <= 0 ? 1 : totalHari;
            }
        }

    }
}