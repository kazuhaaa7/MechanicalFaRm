namespace database_mechanical_farm.Models
{
    public class m_Barang
    {
        public int id_barang { get; set; }
        public int id_users { get; set; }

        public string nama_barang { get; set; }
        public string deskripsi { get; set; }

        public int harga_sewa { get; set; }
        public decimal stok { get; set; }
    }
}