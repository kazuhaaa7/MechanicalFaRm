namespace MechanicalFaRm.App.Models
{
    internal class M_DetailPesanan
    {
        public int idDetailPesanan;
        public int idPesanan;
        public int idBarang;
        public int jumlah;
        public decimal subtotal;

        public M_DetailPesanan(int iddetailpesanan, int idpesanan,
                               int idbarang, int jumlah, decimal subtotal)
        {
            this.idDetailPesanan = iddetailpesanan;
            this.idPesanan = idpesanan;
            this.idBarang = idbarang;
            this.jumlah = jumlah;
            this.subtotal = subtotal;
        }
    }
}