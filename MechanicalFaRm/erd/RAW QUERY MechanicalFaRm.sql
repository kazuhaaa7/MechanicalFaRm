insert into barang()
select * from public.barang
CREATE TABLE public.user
    ( 
     id_user serial PRIMARY KEY NOT NULL , 
     username VARCHAR(100)  NOT NULL , 
     password VARCHAR(255)  NOT NULL , 
     no_telp  varchar(15) not null UNIQUE,
	 email varchar(100) not null,
	 role varchar(10) not null check(role  
	 in ('customer', 'admin')) default 'customer',
     nama varchar(255)
    );


CREATE TABLE barang 
    ( 
     id_barang   serial PRIMARY KEY NOT NULL , 
     nama_barang VARCHAR(100)  NOT NULL , 
     deskripsi   text not null, 
     harga_sewa  INT not null, 
     stok NUMERIC not null,
     foto_barang bytea

    ) 
;


CREATE TABLE detail_pesanan 
    ( 
     id_detail_pesanan SERIAL PRIMARY KEY NOT NULL , 
     id_pesanan INT  NOT NULL , 
     id_barang INT NOT NULL , 
     jumlah INT  NOT NULL , 
     subtotal NUMERIC NOT NULL,
     tanggal_sewa DATE NOT NULL,
     tanggal_kembali DATE NOT NULL
    ) 
;



CREATE TABLE pesanan 
    ( 
     id_pesanan             SERIAL PRIMARY KEY NOT NULL , 
     id_user             INT  NOT NULL , 
     status varchar(50) NOT NULL check(status in('Menunggu Verifikasi Admin', 'Sudah Terverifikasi Admin')) default 'Menunggu Verifikasi Admin',
     ""totalBayar"" NUMERIC NOT NULL 
    ) 
;


ALTER TABLE pesanan 
    ADD CONSTRAINT id_users_FK FOREIGN KEY 
    (id_user) 
    REFERENCES public.user
    (id_user)
		ON DELETE CASCADE
	ON UPDATE CASCADE;

ALTER TABLE detail_pesanan
    ADD CONSTRAINT id_pesanan_FK FOREIGN KEY 
    (id_pesanan) 
    REFERENCES pesanan 
    (id_pesanan)
		ON DELETE CASCADE
	ON UPDATE CASCADE;
ALTER TABLE detail_pesanan
    ADD CONSTRAINT id_barang_FK FOREIGN KEY 
    (id_barang) 
    REFERENCES barang 
    (id_barang)
		ON DELETE CASCADE
	ON UPDATE CASCADE;

CREATE TABLE alamat (
	id_alamat SERIAL PRIMARY KEY NOT NULL,
	id_user INT NOT NULL,
	id_jalan INT NOT NULL,

	CONSTRAINT id_user_fk
	FOREIGN KEY (id_user)
	REFERENCES public.user (id_user),
	
	CONSTRAINT id_jalan_fk
	FOREIGN KEY (id_jalan)
	REFERENCES jalan (id_jalan)
	ON DELETE CASCADE
	ON UPDATE CASCADE
	)

CREATE TABLE jalan (
	id_jalan SERIAL PRIMARY KEY NOT NULL,
	id_kecamatan INT NOT NULL,
	nama_jalan VARCHAR(255) NOT NULL,
	
	CONSTRAINT id_kecamatan_fk
	FOREIGN KEY (id_kecamatan)
	REFERENCES kecamatan (id_kecamatan)
		ON DELETE CASCADE
	ON UPDATE CASCADE
)

CREATE TABLE kecamatan (
	id_kecamatan SERIAL PRIMARY KEY NOT NULL,
	nama_kacamatan VARCHAR(255) NOT NULL
)
