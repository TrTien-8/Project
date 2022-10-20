create database quanlytietkiem1710

use quanlytietkiem1710

create table loaitk (
	maloai varchar(10) not null primary key,
	tenloai nvarchar(255) not null,
	kyhan int not null,
	loaitien varchar(10) not null,
	laisuat int not null,
)

insert into loaitk values ('maloai01', 'Loai 1', '200', N'VND', 2)
insert into loaitk values ('maloai02', 'Loai 2', '200', N'VND', 2)
insert into loaitk values ('maloai03', 'Loai 3', '200', N'VND', 3)
insert into loaitk values ('maloai04', 'Loai 4', '200', N'VND', 5)
insert into loaitk values ('maloai05', 'Loai 5', '200', N'VND', 6)
insert into loaitk values ('maloai06', 'Loai 6', '200', N'VND', 2)
select * from loaitk

create table nhanvien (
	manv varchar(10) not null primary key,
	ngaysinh date not null,
	diachi nvarchar(100),
	dienthoai varchar(20),
	maphong varchar(10) references phonggd(maphong)
)

insert into nhanvien values ('nv01', '2001-01-10', N'Hà Nội', '0123456321', 'maphong01')
insert into nhanvien values ('nv02', '2002-01-10', N'Hà Nội', '0123456321', 'maphong02')
insert into nhanvien values ('nv03', '2003-01-10', N'Hà Nội', '0123456321', 'maphong03')
insert into nhanvien values ('nv04', '2001-03-10', N'Hà Nội', '0123456321', 'maphong04')
insert into nhanvien values ('nv05', '2001-06-10', N'Hà Nội', '0123456321', 'maphong05')
insert into nhanvien values ('nv06', '2001-08-10', N'Hà Nội', '0123456321', 'maphong06')

select * from nhanvien

create table phonggd (
	maphong varchar(10) not null primary key,
	tenphong nvarchar(100) not null,
	diadiem nvarchar(255),
	dienthoai varchar(20)
)

insert into phonggd values ('maphong01', N'Phòng 1', N'Hà Nội', '0123675349')
insert into phonggd values ('maphong02', N'Phòng 2', N'Hà Nội', '0123675349')
insert into phonggd values ('maphong03', N'Phòng 3', N'Hà Nội', '0123675349')
insert into phonggd values ('maphong04', N'Phòng 4', N'Hà Nội', '0123675349')
insert into phonggd values ('maphong05', N'Phòng 5', N'Hà Nội', '0123675349')
insert into phonggd values ('maphong06', N'Phòng 6', N'Hà Nội', '0123675349')
select * from phonggd

create table login (
	madn nvarchar(50) not null primary key,
	mamk nvarchar(50) not null
)

insert into login values ('admin', '123')

select * from login


create or alter view v_tonghop
as
	select loaitk.maloai, tenloai, kyhan, loaitien, laisuat, nhanvien.manv, ngaysinh, diachi, nhanvien.dienthoai, phonggd.maphong,
		   phonggd.tenphong, phonggd.diadiem
	from loaitk, nhanvien, phonggd
	where nhanvien.maphong = phonggd.maphong

select * from v_tonghop where maphong = 'maphong01'
 

