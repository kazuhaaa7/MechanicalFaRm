-- 1. Tabel User (Sudah ada, tapi ini struktur minimal yang diperlukan)
CREATE TABLE IF NOT EXISTS "user" (
    id_user SERIAL PRIMARY KEY,
	username VARCHAR(100) UNIQUE NOT NULL,
    nama VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
	no_telp VARCHAR(15) UNIQUE NOT NULL,
	role VARCHAR(20) NOT NULL DEFAULT 'customer'
);


-- 2. Tabel Barang (Katalog alat)
CREATE TABLE IF NOT EXISTS barang (
    id_barang SERIAL PRIMARY KEY,
    nama_barang VARCHAR(100) NOT NULL,
    harga_sewa INT NOT NULL,
    stok INT NOT NULL,
	foto_barang BYTEA NOT NULL, 
	deskripsi TEXT NOT NULL
);

-- 3. Tabel Keranjang (Data sementara untuk tiap user)
CREATE TABLE IF NOT EXISTS keranjang (
    id_keranjang SERIAL PRIMARY KEY,
    id_user INT REFERENCES "user"(id_user) ON DELETE CASCADE,
    id_barang INT REFERENCES barang(id_barang) ON DELETE CASCADE,
    jumlah INT NOT NULL,
    tgl_sewa DATE NOT NULL,
    tgl_kembali DATE NOT NULL
);
ALTER TABLE keranjang ADD COLUMN nama_penyewa VARCHAR(225);

-- 4. Tabel Pesanan (Header transaksi)
CREATE TABLE IF NOT EXISTS pesanan (
    id_pesanan SERIAL PRIMARY KEY,
    id_user INT REFERENCES "user"(id_user),
    status VARCHAR(50) DEFAULT 'Menunggu Verifikasi',
    total_bayar INT NOT NULL,
    dibuat TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	alamat_jalan VARCHAR(255) NOT NULL
);
ALTER TABLE pesanan ADD COLUMN metode_pembayaran VARCHAR(50);

-- 5. Tabel Detail Pesanan (Isi barang yang disewa)
CREATE TABLE IF NOT EXISTS detail_pesanan (
    id_detail SERIAL PRIMARY KEY,
    id_pesanan INT REFERENCES pesanan(id_pesanan) ON DELETE CASCADE,
    id_barang INT REFERENCES barang(id_barang),
    jumlah INT NOT NULL,
    tanggal_sewa DATE NOT NULL,
    tanggal_kembali DATE NOT NULL,
	sub_total INTEGER NOT NULL
);

-- Relasi untuk Keranjang
ALTER TABLE keranjang ADD CONSTRAINT fk_keranjang_user FOREIGN KEY (id_user) REFERENCES "user"(id_user) ON DELETE CASCADE;
ALTER TABLE keranjang ADD CONSTRAINT fk_keranjang_barang FOREIGN KEY (id_barang) REFERENCES barang(id_barang) ON DELETE CASCADE;

-- Relasi untuk Pesanan
ALTER TABLE pesanan ADD CONSTRAINT fk_pesanan_user FOREIGN KEY (id_user) REFERENCES "user"(id_user);

-- Relasi untuk Detail Pesanan
ALTER TABLE detail_pesanan ADD CONSTRAINT fk_detail_pesanan FOREIGN KEY (id_pesanan) REFERENCES pesanan(id_pesanan) ON DELETE CASCADE;
ALTER TABLE detail_pesanan ADD CONSTRAINT fk_detail_barang FOREIGN KEY (id_barang) REFERENCES barang(id_barang);