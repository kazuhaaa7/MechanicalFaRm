namespace MechanicalFaRm.App.Models
{
    internal class M_Pesanan
    {
        public DateTime tanggalPesan;
        public string statusPesanan;

        public M_Pesanan(DateTime tanggalpesan, string statuspesanan)
        {
            this.tanggalPesan = tanggalpesan;
            this.statusPesanan = statuspesanan;
        }
    }
}