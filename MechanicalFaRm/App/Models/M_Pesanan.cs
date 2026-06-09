namespace MechanicalFaRm.App.Models
{
    internal class M_Pesanan
    {
        public DateOnly tanggalPesan { get; set; }
        public DateOnly tanggalKembali { get; set; }
        public string statusPesanan { get; set; }= "menunggu konfirmasi";

        public M_Pesanan(DateOnly tanggalpesan, DateOnly tanggalkembali, string statuspesanan)
        {
            this.tanggalPesan = tanggalpesan;
            this.tanggalKembali = tanggalkembali;
            this.statusPesanan = statuspesanan;
        }
    }
}