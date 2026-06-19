using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Session;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_deskripsiAlatCust : Form
    {
        C_barangController c_barang;
        private int? userId;
        private List<(M_barang produk, int jumlah)> keranjang;
        private V_dashboardCust parent;
        public V_deskripsiAlatCust(V_dashboardCust parentform, M_barang barang)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            parent = parentform;

            flp1.AutoScroll = true;
            flp1.FlowDirection = FlowDirection.LeftToRight;
            flp1.WrapContents = true;

            c_barang = new C_barangController();
            userId = SE_userSession.id_user; ;
            keranjang = new List<(M_barang, int)>();

            LoadDeskripsi();
            //UpdateRingkasan();
        }


        public void LoadDeskripsi()
        {
            flp1.Controls.Clear();

            var listProduk = c_barang.GetBarangList();

            foreach (var p in listProduk)
            {
                if (p.stok <= 0)
                    continue;

                var card = CreateCard(p);
                flp1.Controls.Add(card);
            }
        }

        private Panel CreateCard(M_barang produk)
        {
            Panel card = new Panel
            {
                Width = 260,
                Height = 380,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.White
            };

            PictureBox pic = new PictureBox
            {
                Width = card.Width - 20,
                Height = 140,
                Top = 10,
                Left = 10,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            if (produk.fotoBarang != null)
            {
                using (var ms = new MemoryStream(produk.fotoBarang))
                {
                    pic.Image = Image.FromStream(ms);
                }
            }

            Label lblNama = new Label
            {
                Text = produk.namaBarang,
                Top = pic.Bottom + 10,
                Left = 10,
                Width = card.Width - 20,
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoEllipsis = true
            };

            Label lblStok = new Label
            {
                Text = "Stok: " + produk.stok,
                Top = lblNama.Bottom + 5,
                Left = 10,
                Width = card.Width - 20,
                ForeColor = produk.stok == 0 ? Color.Red : Color.Black
            };

            Label lblHarga = new Label
            {
                Text = "Harga: Rp." + produk.hargaSewa,
                Top = lblStok.Bottom + 5,
                Left = 10,
                Width = card.Width - 20,
                ForeColor = Color.DarkGreen,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            Label lblDeskripsi = new Label
            {
                Text = produk.deskripsi,
                Top = lblHarga.Bottom + 5,
                Left = 10,
                Width = card.Width - 20,
                Height = 50,
                AutoSize = false,
                MaximumSize = new Size(card.Width - 20, 50),
                Font = new Font("Arial", 9),
                ForeColor = Color.DimGray
            };

            card.Controls.Add(lblDeskripsi);
            card.Controls.Add(pic);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblStok);
            card.Controls.Add(lblHarga);

            Button btnPesan = new Button
            {
                Text = "Pesan",
                Width = 120,
                Height = 35,
                Top = card.Height - 60,
                Left = (card.Width - 120) / 2,
                BackColor = Color.MediumSeaGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            //btnPesan.Click += (s, e) =>
            //{
            //    if (produk.s <= 0)
            //    {
            //        MessageBox.Show("Maaf, stok produk habis!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    TambahKeKeranjang(produk);
            //    UpdateRingkasan();
            //};

            //card.Controls.Add(btnPesan);

            return card;
        }
    }
}
