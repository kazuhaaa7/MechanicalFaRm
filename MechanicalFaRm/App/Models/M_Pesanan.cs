namespace MechanicalFaRm.App.Models
{
    internal class M_Pesanan
    {
        public int idPesanan;
        public int idUsers;
        public DateTime tanggalPesan;
        public string statusPesanan;

        public M_Pesanan(int idpesanan, int idusers,
                         DateTime tanggalpesan, string statuspesanan)
        {
            this.idPesanan = idpesanan;
            this.idUsers = idusers;
            this.tanggalPesan = tanggalpesan;
            this.statusPesanan = statuspesanan;
        }
    }
}