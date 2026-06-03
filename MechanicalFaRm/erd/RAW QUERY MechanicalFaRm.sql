CREATE TABLE users
    ( 
     id_users serial PRIMARY KEY NOT NULL , 
     username VARCHAR(100)  NOT NULL , 
     password VARCHAR(255)  NOT NULL , 
	 nama varchar(100) not null,
     no_telp  varchar(15) not null UNIQUE,
	 email varchar(100) not null,
	 tipe_pengguna varchar(10) not null check(tipe_pengguna 
	 in ('customer', 'admin')) default 'customer',
	 alamat text not null
    );


CREATE TABLE barang 
    ( 
     id_barang   serial PRIMARY KEY NOT NULL , 
	 id_users integer not null,
     nama_barang VARCHAR(100)  NOT NULL , 
     deskripsi   VARCHAR(255) not null, 
     harga_sewa  INT not null, 
     stok NUMERIC not null
    ) 
;


CREATE TABLE detail_pesanan 
    ( 
     id_detail_pesanan SERIAL PRIMARY KEY NOT NULL , 
     id_pesanan INT  NOT NULL , 
     id_barang INT NOT NULL , 
     jumlah INT  NOT NULL , 
     subtotal NUMERIC NOT NULL
    ) 
;

CREATE TABLE keranjang 
    ( 
     id_keranjang SERIAL PRIMARY KEY NOT NULL , 
     id_users      INT  NOT NULL , 
     id_barang    INT NOT NULL,
     jumlah       NUMERIC NOT NULL
    ) 
;


CREATE TABLE pesanan 
    ( 
     id_pesanan             SERIAL PRIMARY KEY NOT NULL , 
     id_users                INT  NOT NULL , 
     tanggal_pesan          DATE , 
     status_pesanan varchar(20) NOT NULL check(status_pesanan in('progress pemesanan', 'sudah terpesan')) 
	 default 'progress pemesanan'
    ) 
;
CREATE UNIQUE INDEX pesanan__IDX ON pesanan 
    ( 
     keranjang_id_keranjang ASC 
    ) 
;



ALTER TABLE pesanan 
    ADD CONSTRAINT id_users_FK FOREIGN KEY 
    (id_users) 
    REFERENCES users
    (id_users);

ALTER TABLE detail_pesanan
    ADD CONSTRAINT id_pesanan_FK FOREIGN KEY 
    (id_pesanan) 
    REFERENCES pesanan 
    (id_pesanan);
ALTER TABLE detail_pesanan
    ADD CONSTRAINT id_barang_FK FOREIGN KEY 
    (id_barang) 
    REFERENCES barang 
    (id_barang);


ALTER TABLE keranjang 
    ADD CONSTRAINT id_user_FK FOREIGN KEY 
    ( id_users) 
    REFERENCES users (id_users);

ALTER TABLE keranjang 
    ADD CONSTRAINT id_barang_FK FOREIGN KEY 
    ( id_barang) 
    REFERENCES barang (id_barang);

ALTER TABLE barang 
	ADD CONSTRAINT id_users FOREIGN KEY
	(id_users)
	REFERENCES users (id_users)