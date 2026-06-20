namespace MechanicalFaRm.App.Models
{
    public class M_DetailPesanan : M_Pesanan
    {
        public int id_barang { get; set; }
        public int idPesanan { get; set; }

        public int jumlah {  get; set; }
        public int subtotal { get; set; }
        public DateTime tglSewa { get; set; }
        public DateTime tglKembali { get; set; }

        public M_user? PenyewaDP { get; set; }
        public int Durasi { get; set; }

        public M_jalan tujuan { get; set; }


    }
}