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
        private C_loginAuthController logout;
        public V_deskripsiAlatCust(V_dashboardCust parentform, M_barang barang)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            parent = parentform;

            flp1.AutoScroll = true;
            flp1.FlowDirection = FlowDirection.LeftToRight;
            flp1.WrapContents = true;

            c_barang = new C_barangController();
            userId = SE_userSession.id_user;
            logout = new C_loginAuthController();
            keranjang = new List<(M_barang, int)>();

            LoadDeskripsi();
        }


        public void LoadDeskripsi()
        {
            flp1.Controls.Clear();

            var listProduk = c_barang.GetBarangList();

            foreach (var p in listProduk)
            {

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
                Top = pic.Bottom + 15,
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
                ForeColor = Color.Black,
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
                Font = new Font("Arial", 10),
                ForeColor = Color.Black
            };

            card.Controls.Add(lblDeskripsi);
            card.Controls.Add(pic);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblStok);
            card.Controls.Add(lblHarga);

            Button btnDeskripsi = new Button
            {
                Text = "Deskripsi",
                Width = 120,
                Height = 35,
                Top = card.Height - 60,
                Left = (card.Width - 120) / 2,
                BackColor = Color.LightGray,
                ForeColor = Color.Black,
                Font = new Font("Arial", 9.5F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };

            btnDeskripsi.Click += (s, e) =>
            {

                TampilkanDetail(produk);
            };

            card.Controls.Add(btnDeskripsi);


            return card;
        }


        private void TampilkanDetail(M_barang produk)
        {
            panelRingkasan.Controls.Clear();

            Label lblJudul = new Label
            {
                Text = "DETAIL ALAT",
                Top = 10,
                Left = 10,
                Width = panelRingkasan.Width - 20,
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.Black
            };

            Label lblNama = new Label
            {
                Text = $"Nama: {produk.namaBarang}",
                Top = lblJudul.Bottom + 15,
                Left = 10,
                Width = panelRingkasan.Width - 20,
                Font = new Font("Arial", 11, FontStyle.Regular)
            };

            Label lblStok = new Label
            {
                Text = $"Stok Tersedia: {produk.stok}",
                Top = lblNama.Bottom + 5,
                Left = 10,
                Width = panelRingkasan.Width - 20,
                Font = new Font("Arial", 11, FontStyle.Regular)
            };

            Label lblHarga = new Label
            {
                Text = $"Harga: Rp {produk.hargaSewa} Juta",
                Top = lblStok.Bottom + 5,
                Left = 10,
                Width = panelRingkasan.Width - 20,
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Black
            };

            Label lblLabelDeskripsi = new Label
            {
                Text = "Deskripsi:",
                Top = lblHarga.Bottom + 15,
                Left = 10,
                Font = new Font("Arial", 11, FontStyle.Underline)
            };

            Label lblIsiDeskripsi = new Label
            {
                Text = produk.deskripsi,
                Top = lblLabelDeskripsi.Bottom + 5,
                Left = 10,
                Width = panelRingkasan.Width - 25,
                Height = 150,
                Font = new Font("Arial", 10, FontStyle.Italic),
                ForeColor = Color.DimGray,
            };

            panelRingkasan.Controls.AddRange(new Control[] {
        lblJudul, lblNama, lblStok, lblHarga, lblLabelDeskripsi, lblIsiDeskripsi
    });
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new V_dashboardCust().Show();
            this.Hide();
        }

        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            new V_riwayatPenyewaanCust().Show();
            this.Hide();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            new V_keranjangCust().Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            new V_profileCust(id).Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout.Logout(this);
        }
    }
}
