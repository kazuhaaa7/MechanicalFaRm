using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_kelolaPesanan : Form
    {
        private S_PesananService servicePesan;
        private int id;
        public V_kelolaPesanan(int id)
        {
            InitializeComponent();
            this.id = id;
            servicePesan = new S_PesananService();
        }

        public void DataPesanan()
        {
            List<M_DetailPesanan> daftarR = servicePesan.GetAllPesanan(id);

            if(daftarR.Count == 0)
            {
                MessageBox.Show("Kamu belum memiliki riwayat penyewaan alat.", "Informasi");
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("status", typeof(int));
            dt.Columns.Add("jumlah alat", typeof(int));
            dt.Columns.Add("total", typeof(int));
            dt.Columns.Add("Tanggal Sewa", typeof(DateOnly));
            dt.Columns.Add("Tanggal Akhir", typeof(DateOnly));

            foreach(var item in daftarR)
            {
                dt.Rows.Add(
                item.status,
                item.jumlah,
                item.total,
                item.tglSewa,
                item.tglSewa);
            }
        }
    }
}
