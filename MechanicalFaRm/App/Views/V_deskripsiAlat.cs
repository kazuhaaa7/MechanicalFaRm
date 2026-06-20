using MechanicalFaRm.App.Controllers;
using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MechanicalFaRm.App.Views
{
    public partial class V_deskripsiAlat : Form
    {
        private C_loginAuthController logout;
        private C_barangController ctrlBarang;
        public V_deskripsiAlat()
        {
            InitializeComponent();
            logout = new C_loginAuthController();
            ctrlBarang = new C_barangController();
            this.WindowState = FormWindowState.Maximized;

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            LoadDeskripsi();
        }

        public void LoadDeskripsi()
        {
            flowLayoutPanel1.Controls.Clear();

            var listProduk = ctrlBarang.GetBarangList();

            foreach (var p in listProduk)
            {
                var card = CreateCard(p);
                flowLayoutPanel1.Controls.Add(card);
            }
        }


        private Panel CreateCard(M_barang barang)
        {
            Panel card = new Panel
            {
                Width = 260,
                Height = 410,
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
                Height = 90,
                AutoSize = true,
                MaximumSize = new Size(card.Width - 20, 0),
                Font = new Font("Arial", 9),
                ForeColor = Color.DimGray
            };

            card.Controls.Add(lblDeskripsi);

            card.Controls.Add(pic);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblStok);
            card.Controls.Add(lblHarga);

            Button btnEdit = new Button
            {
                Text = "Edit",
                Width = 110,
                Height = 35,
                Top = card.Height - 60,
                Left = 80,
                BackColor = Color.Moccasin,
                ForeColor = Color.Black,
                Font = new Font("Arial", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }

            };
            btnEdit.Click += (s, e) =>
            {
                var editForm = new V_tambahDeskripsi(this, barang);
                editForm.Show();
                this.Hide();
            };

            card.Controls.Add(btnEdit);

            return card;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            int id = SE_userSession.id_user;
            new V_profleAdmin(id).Show();
            this.Close();
        }

        private void btnKelolaAlat_Click(object sender, EventArgs e)
        {
            new V_kelolaAlatAdmin().Show();
            this.Close();
        }

        private void btnKelolaCust_Click(object sender, EventArgs e)
        {
            new V_kelolaAkunAdmin().Show();
            this.Close();
        }

        private void btnRiwayatPenyewaan_Click(object sender, EventArgs e)
        {
            new V_riwayatPenyewaanAdmin().Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e) => logout.Logout(this);

        private void btnKelolaAlat_Click_(object sender, EventArgs e)
        {
            new V_kelolaAlatAdmin().Show();
            this.Close();
        }

        private void btnTambahAlat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda ingin menambahkan produk baru?", "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                var tambahForm = new V_tambahDeskripsi(this);
                tambahForm.Show();
                this.Hide();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
