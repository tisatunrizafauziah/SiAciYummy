# 🥗 SiAciYummy

**SiAciYummy** adalah aplikasi **Sistem Informasi Penjualan Online** untuk produk makanan berbahan dasar aci (tapioka).  
Aplikasi ini dibangun menggunakan **ASP.NET Core MVC** dengan **Entity Framework Core** sebagai ORM dan menggunakan **MySQL** sebagai database utama.

---

## 🚀 Fitur Utama

- **Autentikasi (Login & Register)**
  - Pengguna dapat membuat akun baru atau login.
  - Role: *Admin* dan *User*.

- **Manajemen Produk**
  - Admin dapat menambah, mengubah, menghapus produk.
  - Produk memiliki atribut: *Nama, Deskripsi, Harga, Stok, Gambar*.

- **Pemesanan (Order)**
  - User dapat memilih produk dan membuat pesanan.
  - Data pesanan mencakup: *Nama Pelanggan, Alamat, Nomor Telepon, Produk, Status Pesanan*.
  - Admin dapat melihat daftar pesanan, memperbarui status, atau menghapus.

- **Riwayat Pesanan**
  - Pesanan yang sudah diproses akan tersimpan di riwayat.

- **UI Responsif**
  - Menggunakan Bootstrap dengan desain modern (card, grid, hover effect, gradient background).

---

## 🗄️ Database: MySQL

Aplikasi menggunakan **MySQL** untuk menyimpan data.  
Konfigurasi koneksi database ada di file `appsettings.json`.

### Struktur Tabel Utama

- **Users**
  - `Id`, `Username`, `PasswordHash`, `Role`

- **Products**
  - `Id`, `Name`, `Description`, `Price`, `Stock`, `Image`

- **Orders**
  - `Id`, `CustomerName`, `Address`, `PhoneNumber`, `Status`, `ProductId (FK)`

Relasi:
- Satu **Order** terkait ke satu **Product**.
- Seorang **User** bisa membuat banyak **Orders**.

---


