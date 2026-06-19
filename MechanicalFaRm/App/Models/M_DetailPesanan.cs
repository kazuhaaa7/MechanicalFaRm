namespace MechanicalFaRm.App.Models
{
    public class M_DetailPesanan : M_Pesanan
    {
        public int id_barang { get; set; }
        public int idPesanan { get; set; }

        public int jumlah {  get; set; }
        public decimal subtotal { get; set; }
        public DateTime tglSewa { get; set; }
        public DateTime tglKembali { get; set; }
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