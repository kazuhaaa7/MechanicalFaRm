namespace MechanicalFaRm.App.Models
{
    public class M_Pesanan:M_barang
    {
        public int id_pesanan { get; set; }
        public decimal total {  get; set; }

        public string status { get; set; }  
        public List<M_DetailPesanan> detailBarang { get; set; } = new List<M_DetailPesanan>();

        public M_user? Penyewa { get; set; } =  new M_user();

        public string jalan { get; set; }
        //public string username 
        //{
        //    get { return _username; }
        //    set { _username = value; }
        //}
    }
}