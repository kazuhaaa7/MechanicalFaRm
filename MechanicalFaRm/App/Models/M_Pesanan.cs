namespace MechanicalFaRm.App.Models
{
    public class M_Pesanan:M_barang
    {
        public int id_pesanan { get; set; }
        public int total {  get; set; }

        public string status { get; set; }

        //public M_Pesanan(DateOnly tanggalpesan, DateOnly tanggalkembali, string statuspesanan)
        //{
        //    this.tanggalPesan = tanggalpesan;
        //    this.tanggalKembali = tanggalkembali;
        //    this.statusPesanan = statuspesanan;
        //}
    }
}