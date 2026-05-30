namespace MechanicalFaRm.App.Models
{
    internal class M_Keranjang
    {
        public int idKeranjang;
        public int idUsers;
        public int idBarang;
        public decimal jumlah;

        public M_Keranjang(int idkeranjang, int idusers,
                           int idbarang, decimal jumlah)
        {
            this.idKeranjang = idkeranjang;
            this.idUsers = idusers;
            this.idBarang = idbarang;
            this.jumlah = jumlah;
        }
    }
}