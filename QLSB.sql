create database QLSB
use QLSB
create table NhanVien
(
	MaNV nvarchar(20),
	TenNV nvarchar(20),
	CMND char(20),
	NamSinh datetime,
	Makhau varchar(20),
	primary key(MaNV)  
)
create table Khach
(
	MaKhach nvarchar(20),
	TenKhach nvarchar(20),
	CMND varchar(20),
	SDT nvarchar(20),
	primary key(MaKhach)
)
create table HoaDon
(
	MaHoaDon nvarchar(50),
	MaKhach nvarchar(20),
	MaNgay nvarchar(20),
	MaGio nvarchar(20),
	San nvarchar(20),
	MaHoaDonNuoc nvarchar(20),
	TongTien nvarchar(50)
)
create table Lich
(
	MaNgay nvarchar(20),
	MaGio nvarchar(20),
	San1 bit,
	San2 bit,
	San3 bit,
	San4 bit,
	San5 bit,
	San6 bit,
	San7 bit,
	San8 bit,
	San9 bit,
	CONSTRAINT PR_Lich PRIMARY KEY(MaNgay,MaGio)
)
create table Nuoc
(
	TenNuoc nvarchar(20),
	MaNuoc nvarchar(20),
	primary key(MaNuoc)
)
create table Kho
(
	MaNuoc nvarchar(20),
	SoLuong int,
)
create table HoaDonNuoc
(
	MaHoaDonNuoc nvarchar(20),
	MaNgay nvarchar(20),
	MaGio nvarchar(20),
	MaNuoc nvarchar(20),
	DonGia int,
	primary key(MaHoaDonNuoc,MaNgay,MaGio,MaNuoc)
)
create table NhapNuoc
(
	MaPhieuNhap nvarchar(20),
	NgayNhap datetime,
	NhanVienNhap nvarchar(20),
	primary key(MaPhieuNhap)
)
create table ChiTietPhieuNhapNuoc
(
	MaPhieuNhap nvarchar(20),
	MaNuoc nvarchar(20),
	SoLuong int
)
alter table HoaDon add constraint FK_HoaDon_Khach foreign key(MaKhach) references Khach(MaKhach)
alter table HoaDon add constraint FK_HoaDon_HoaDonNuoc foreign key(MaHoaDonNuoc) references HoaDonNuoc(MaHoaDonNuoc)
alter table HoaDonNuoc add constraint FK_HoaDonNuoc_Nuoc foreign key(MaNuoc) references Nuoc(MaNuoc)
alter table NhapNuoc add constraint FK_NhapNuoc_NhanVien foreign key(NhanVienNhap) references NhanVien(MaNV)
alter table Kho add constraint FK_Kho_Nuoc foreign key(MaNuoc) references Nuoc(MaNuoc)
alter table ChiTietPhieuNhapNuoc add constraint FK_CTPNN_NhapNuoc foreign key(MaPhieuNhap) references NhapNuoc(MaPhieuNhap)
alter table ChiTietPhieuNhapNuoc add constraint FK_CTPNN_Nuoc foreign key(MaNuoc) references Nuoc(MaNuoc)


select Makhau from NhanVien where MaNV like 'NV1'