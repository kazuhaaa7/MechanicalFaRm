namespace MechanicalFaRm.App.Models
{
    internal class M_Barang
    {
        public int idBarang;
        public int idUsers;
        public string namaBarang;
        public string deskripsi;
        public int hargaSewa;
        public decimal stok;

        public M_Barang(int idbarang, int idusers, string namabarang,
                        string deskripsi, int hargasewa, decimal stok)
        {
            this.idBarang = idbarang;
            this.idUsers = idusers;
            this.namaBarang = namabarang;
            this.deskripsi = deskripsi;
            this.hargaSewa = hargasewa;
            this.stok = stok;
        }
    }
}