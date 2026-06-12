namespace MechanicalFaRm.App.Models
{
    public class M_Pesanan : M_barang
    {
        public DateTime tglSewa { get; set; }
        public DateTime tglKembali { get; set; }
        public string statusPesanan { get; set; }= "menunggu konfirmasi";

        //public M_Pesanan(DateOnly tanggalpesan, DateOnly tanggalkembali, string statuspesanan)
        //{
        //    this.tanggalPesan = tanggalpesan;
        //    this.tanggalKembali = tanggalkembali;
        //    this.statusPesanan = statuspesanan;
        //}
    }
}