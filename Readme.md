#  🚜 Judul Proyek: MechanicalFaRm

MechanicalFaRm merupakan suatu plaftform yang menyediakan penyewaan alat berat yang bisa dijangkau dengan skala kabupaten.
Sistem ini merupakan sistem oneline berbasis website dengan menghadirkan beberapa fitur untuk customer seperti regis, login, dasboard penyewaan alat, daftar keranjang, serta histori penyewaaan

--- 
Proyek ini menghadirkan sistem multi-role yang memisahkan hak akses antara pihak manajemen (Admin) dan pengguna akhir (Customer).
### 👤 Fitur Customer
* 🖥️ **Dashboard Alat Berat:** Menampilkan alat berat yang tersedia dengan stok < 0, deskripsi singkat, stok, nama serta harga.
* 🛒 **Keranjang & Checkout:** Manajemen item penyewaan alat (bisa menghapus alat yang pernah masuk keranjang) dan kalkulasi total penyewaan otomatis.
* 📜 **Riwayat Penyewaan:** Memaantau status (Menunggu diverifikasi admin dan Sudah diverifikasi admin) penyewaan setelah transaksi.  
* ⚙️ **Manajemen Profile:** Mengubah data diri: username, nomer telepon, email.
* 🛍️ **Pembayaran:** Menampilkan daftar alat yang disewa, harga tiap alat, durasi penyewaa, serta kolom pengisian alamat tujuan.
* 📝 **Deskripsi Alat:** Menampilkan chard detail alat yang berisi stok(tanpa ada perkondisian < 0), nama alat, harga, dan deskripsi. 


### 🔐 Fitur Admin
* 📊 **Ringkasan Penyewaan:** Melihat daftar penyewaan, dan validasi status pembayaran customer.
* 🙋 **Daftar Customer yang pernah Loggin:** Menampilkan daftar customer yang pernah loggin.
* 📦 **Manajemen Alat Berat (CRUD):** Menambah, dan mengubahdata stok barang, nama, harga serta deskripsi.

---

## ⚙️ Prasyarat Sistem

Sebelum menjalankan proyek ini, pastikan perangkat kamu sudah terinstal:
* [ ] **Runtime:** .NET SDK - sesuaikan dengan kebutuhan (disarankan versi 10)
* [ ] **Database:** PostgreSQL 
* [ ] **IDE:** Visual Studio 

---
  
## 🏃‍♂️Cara Penggunaan

Ikuti langkah-langkah di bawah ini untuk menjalankan aplikasi di komputer kamu.

> 💡 **Penting:** Pastikan semua prasyarat di atas sudah terpenuhi sebelum masuk ke langkah pertama.

> ### 1️⃣ Clone Repositori 
> Buka terminal atau command prompt, lalu jalankan perintah berikut:
> #### -> Melakukan git clone
> ```bash 
> git clone [link repo]
> ```
> #### -> Masuk ke file directory - cd (nama-repo)

> ### 2️⃣ Memuat Proyek 

> * **Memuat file solusi:** klik dua kali pada file solusi proyek:
> ```text
>  MechanicalFaRm.sln
> ```
---

> ### 🔧 Konfigurasi Database
> Pergi ke:
> ``` text
> MechanicalFaRm\App\DbHelper
>  ```
> dan buka file:
> ``` text
> dbconnect.cs
> ```
> Sesuaikan nilai di dalam file tersebut dengan kredensial PostgreSQL milikmu:


| Config Key | Description |
| :--- | :--- |
| 🖥️ **Host/Server** | Your database host |
| 📁 **Database** | Database name |
| 👤 **Username** | PostgreSQL user |
| 🔒 **Password** | User password |
