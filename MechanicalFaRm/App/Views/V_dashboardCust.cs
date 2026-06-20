using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Session;

namespace MechanicalFaRm.App.Views
{
    public partial class V_dashboardCust : Form
    {
        C_loginAuthController logout;
        private C_barangController ctrlBarang;
        public V_dashboardCust()
        {
            InitializeComponent();
            logout = new C_loginAuthController();
            ctrlBarang = new C_barangController();
            this.WindowState = FormWindowState.Maximized;

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
        }
        private Panel CreateCard(M_barang barang)
        {
            // KOREKSI UKURAN CARD: Dipertinggi menjadi 440 agar muat 2 tombol dengan lega
            Panel card = new Panel
            {
                Width = 260,
                Height = 440,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.White
            };

            // 1. PICTURE BOX (Foto Alat)
            PictureBox pic = new PictureBox
            {
                Width = card.Width - 20,
                Height = 140,
                Top = 10,
                Left = 10,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            if (barang.fotoBarang != null)
            {
                using (var ms = new MemoryStream(barang.fotoBarang))
                {
                    pic.Image = Image.FromStream(ms);
                }
            }

            Label lblNama = new Label
            {
                Text = barang.namaBarang,
                Top = pic.Bottom + 10,
                Left = 10,
                Width = card.Width - 20,
                Height = 25,
                Font = new Font("Arial", 11, FontStyle.Bold),
                AutoEllipsis = true
            };

            Label lblStok = new Label
            {
                Text = "Stok: " + barang.stok,
                Top = lblNama.Bottom + 5,
                Left = 10,
                Width = card.Width - 20,
                Height = 20,
                ForeColor = barang.stok < 1 ? Color.Red : Color.Black,
                Font = new Font("Arial", 9.5f)
            };

            Label lblHarga = new Label
            {
                Text = "Rp." + barang.hargaSewa + " Juta",
                Top = lblStok.Bottom + 5,
                Left = 10,
                Width = card.Width - 20,
                Height = 20,
                ForeColor = Color.Black,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            Label lblDeskripsi = new Label
            {
                Text = barang.deskripsi,
                Top = lblHarga.Bottom + 8,
                Left = 10,
                Width = card.Width - 20,
                Height = 110,
                AutoSize = false,
                AutoEllipsis = true,
                Font = new Font("Arial", 9),
                ForeColor = Color.DimGray
            };

            Button btnDeskripsi = new Button
            {
                Text = "Deskripsi",
                Width = 110,
                Height = 35,
                Top = card.Height - 50,
                Left = 15,
                BackColor = Color.LightGray,
                ForeColor = Color.Black,
                Font = new Font("Arial", 9.5f, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            btnDeskripsi.Click += (s, e) =>
            {
                var desForm = new V_deskripsiAlatCust(this, barang);
                desForm.Show();
                this.Hide();
            };

            Button btnSewa = new Button
            {
                Text = "Sewa",
                Width = 110,
                Height = 35,
                Top = card.Height - 50,
                Left = 135, // Bergeser ke kanan, sejajar dengan tombol deskripsi
                BackColor = Color.Moccasin,
                ForeColor = Color.Black,
                Font = new Font("Arial", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            btnSewa.Click += (s, e) =>
            {
                var sewaForm = new V_popupBarang(this, barang.id_barang);
                sewaForm.Show();
            };

            // Masukkan semua komponen ke dalam Card
            card.Controls.Add(pic);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblStok);
            card.Controls.Add(lblHarga);
            card.Controls.Add(lblDeskripsi);
            card.Controls.Add(btnDeskripsi);
            card.Controls.Add(btnSewa);

            return card;
        }

        private void V_dashboardUser_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            var listProduk = ctrlBarang.GetBarangList();

            foreach (var p in listProduk)
            {
                if (p.stok < 1)
                {
                    continue;
                }
                var card = CreateCard(p);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            V_riwayatPenyewaanCust riwayatPembelian = new V_riwayatPenyewaanCust();
            riwayatPembelian.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            V_profileCust profile = new V_profileCust(id);
            profile.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout.Logout(this);
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            V_keranjangCust kc = new V_keranjangCust();
            kc.Show();
            this.Hide();
        }

        private void btnDeskripsiAlat_Click(object sender, EventArgs e)
        {
                M_barang barang = new M_barang();
                V_deskripsiAlatCust des =  new V_deskripsiAlatCust(this, barang);
                des.Show();
                this.Hide();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
