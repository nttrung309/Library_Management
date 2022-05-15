CREATE DATABASE QLTV
USE QLTV
-----------------------
CREATE FUNCTION [dbo].[AUTO_IDDG]()
RETURNS VARCHAR(5)--
AS
BEGIN
	DECLARE @ID VARCHAR(5)--
	IF (SELECT COUNT(MaDocGia) FROM DOCGIA) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaDocGia, 3)) FROM DocGia--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'DG00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'DG0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
---------------
CREATE TABLE DOCGIA (
	MaDocGia Varchar(50) PRIMARY KEY DEFAULT ([DBO].[AUTO_IDDG]()),
	HoTen Nvarchar(100) not null,
	MaLoaiDocGia Varchar(50) not null,
	NgSinh Date not null,
	DChi Nvarchar(200) not null,
	Email Varchar(100) not null,
	NgLapThe Smalldatetime not null,
	NgHetHan Smalldatetime not null,
	TongNo money not null
	)
	alter table DocGIA
	ALTER COLUMN NgLapThe smalldatetime SET DATEFORMAT DMY
		alter table DocGIA
	ALTER COLUMN NgHetHan smalldatetime SET DATEFORMAT DMY
	
----------------
CREATE FUNCTION [dbo].[AUTO_IDLDG]()--
RETURNS VARCHAR(7)--
AS
BEGIN
	DECLARE @ID VARCHAR(7)--
	IF (SELECT COUNT(MaLoaiDocGia) FROM LOAIDOCGIA) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaLoaiDocGia, 3)) FROM LOAIDOCGIA--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MLDG00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MLDG0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
CREATE TABLE LOAIDOCGIA (
	MaLoaiDocGia Varchar(50) primary key DEFAULT ([DBO].[AUTO_IDLDG]()),
	TenLoaiDocGia Nvarchar(100) not null
	)
------------
CREATE FUNCTION [dbo].[AUTO_IDS]()--
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaSach) FROM SACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaSach, 3)) FROM Sach--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
CREATE TABLE SACH (
	MaSach Varchar(50) primary key DEFAULT ([DBO].[AUTO_IDS]()) ,
	MaDauSach Varchar(50) not null,
	NhaXuatBan Nvarchar(100) not null,
	NamXuatBan int not null,
	SoLuong int not null,
	TriGia money not null
	)
	-----------------
	CREATE FUNCTION [dbo].[AUTO_CS]()--
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaCuonSach) FROM CuonSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCuonSach, 3)) FROM CuonSach--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MCS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MCS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
CREATE TABLE CUONSACH(
	MaCuonSach Varchar(50) primary key DEFAULT ([DBO].[AUTO_CS]()),
	MaSach Varchar(50) not null,
	TinhTrang Bit not null
	)
	----------------
		CREATE FUNCTION [dbo].[AUTO_MTL]()--
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaTheLoai) FROM TheLOAI) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaTheLoai, 3)) FROM TheLoai--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MTL00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MTL0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
CREATE TABLE THELOAI (
	MaTheLoai Varchar(50) primary key default ([dbo].[AUTO_MTL]()),
	TenTheLoai Nvarchar(100) not null
	)
--------------------
CREATE FUNCTION [dbo].[AUTO_MDS]()--
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaDauSach) FROM DAUSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaDauSach, 3)) FROM DAUSACH--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MDS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MDS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
GO
CREATE TABLE DAUSACH (
	MaDauSach Varchar(50) primary key default ([dbo].[AUTO_MDS]()) ,
	TenDauSach Nvarchar(100) not null,
	MaTheLoai Varchar(50) not null
	)
------------
CREATE FUNCTION [dbo].[AUTO_MTG]()--
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaTacGia) FROM TACGIA) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaTacGia, 3)) FROM TacGia--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MTG00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MTG0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE TACGIA (
	MaTacGia Varchar(50) primary key default ([dbo].[AUTO_MTG]()),
	TenTacGia Nvarchar(100) not null
	)	
	--------------

CREATE TABLE CTTACGIA (
	MaDauSach Varchar(50) ,
	MaTacGia Varchar(50) not null,
	PRIMARY KEY (MaDauSach, MaTacGia)
	)
-------------------
CREATE FUNCTION [dbo].[AUTO_MPMS]()--
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @ID VARCHAR(7)
	IF (SELECT COUNT(MaPhieuMuonSach) FROM PHIEUMUON) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuMuonSach, 3)) FROM PHIEUMUON--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MPMS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MPMS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE PHIEUMUON (
	MaPhieuMuonSach Varchar(50) primary key DEFAULT ([dbo].[AUTO_MPMS]()),
	MaDocGia Varchar(50) not null,
	NgMuon Smalldatetime not null,
	HanTra Smalldatetime not null
	)
	alter table PHIEUMUON
	ALTER COLUMN NgMuon smalldatetime SET DATEFORMAT DMY
	alter table PHIEUMUON
	ALTER COLUMN HanTra smalldatetime SET DATEFORMAT DMY
	-----------------------------
CREATE FUNCTION [dbo].[AUTO_MCTPM]()--
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(MaChiTietPhieuMuon) FROM CTPHIEUMUON) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaChiTietPhieuMuon, 3)) FROM CTPHIEUMUON--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MCTPM00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MCTPM0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE CTPHIEUMUON(
	MaChiTietPhieuMuon Varchar(50) primary key default ([dbo].[AUTO_MCTPM]()),
	MaPhieuMuonSach Varchar(50) not null,
	MaCuonSach Varchar(50) not null,
	TinhTrangPM Bit not null
	)
------------------------------
CREATE FUNCTION [dbo].[AUTO_MPTS]()--
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @ID VARCHAR(7)
	IF (SELECT COUNT(MaPhieuTraSach) FROM PHIEUTraSach) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuTraSach, 3)) FROM PhieuTraSach--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MPTS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MPTS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE PHIEUTRASACH (
	MaPhieuTraSach Varchar(50) primary key default ([dbo].[AUTO_MPTS]()),
	MaDocGia Varchar(50) not null,
	NgTra Smalldatetime not null,
	TienPhatKyNay money not null
	)
	alter table phieutrasach
	alter column NgTra smalldatetime set DATEFORMAT DMY
	------------------
CREATE FUNCTION [dbo].[AUTO_MCTPTS]()--
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(MaChiTietPhieuTra) FROM CTPT) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaChiTietPhieuTra, 3)) FROM CTPT--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MCTPT00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MCTPT0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE CTPT(
	MaChiTietPhieuTra Varchar(50) primary key default ([dbo].[AUTO_MCTPTS]()),
	MaPhieuTraSach Varchar(50) not null,
	MaCuonSach Varchar(50) not null,
	MaPhieuMuonSach Varchar(50) not null,
	SoNgayMuon int not null,
	TienPhat money not null
	)
-----------------------------
CREATE FUNCTION [dbo].[AUTO_MPNS]()--
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @ID VARCHAR(7)
	IF (SELECT COUNT(MaPhieuNhapSach) FROM PHIEUNHAPSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuNhapSach, 3)) FROM PHIEUNHAPSACH--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MPNS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MPNS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE PHIEUNHAPSACH (
	MaPhieuNhapSach Varchar(50) primary key default ([dbo].[AUTO_MPNS]()),
	NgLap Smalldatetime not null,
	TongTien money not null
	)
	alter table PHIEUNHAPSACH 
	alter column NgLap smalldatetime set dateformat DMY
	-------------------
CREATE FUNCTION [dbo].[AUTO_MCTPN]()--
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(MaCTPN) FROM CTPHIEUNHAP) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCTPN, 3)) FROM CTPHIEUNHAP--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MCTPN00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MCTPN0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE CTPHIEUNHAP(
	MaCTPN Varchar(50) primary key default ([dbo].[AUTO_MCTPN]()),
	MaPhieuNhapSach Varchar(50) not null,
	MaSach Varchar(50) not null,
	SoLuong int not null,
	DonGia money not null,
	ThanhTien money not null,
	)
----------------------------
CREATE FUNCTION [dbo].[AUTO_MPT]()--
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaPhieuThu) FROM PHIEUTHUTIEN) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuThu, 3)) FROM PHIEUTHUTIEN--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MPT00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MPT0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE PHIEUTHUTIEN (
	MaPhieuThu Varchar(50) primary key default ([dbo].[AUTO_MPT]()),
	MaDocGia Varchar(50) not null,
	NgThu Smalldatetime not null,
	SoTienThu money not null,
	ConLai money not null
	)
	alter table phieuthutien
	alter column Ngthu smalldatetime set dateformat DMY
	-----------------------------
CREATE FUNCTION [dbo].[AUTO_MBCMS]()--
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(MaBaoCaoMuonSach) FROM BAOCAOMUONSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaBaoCaoMuonSach, 3)) FROM BAOCAOMUONSACH--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MBCMS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MBCMS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE BAOCAOMUONSACH (
	MaBaoCaoMuonSach Varchar(50) primary key default ([dbo].[AUTO_MBCMS]()),
	ThangNam Smalldatetime not null,
	TongSoLuotMuon int not null
	)
	alter table BAOCAOMUONSACH
	alter column ThangNam smalldatetime set dateformat DMY
	-----------------------
CREATE FUNCTION [dbo].[AUTO_MCTBCMS]()--
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @ID VARCHAR(10)
	IF (SELECT COUNT(MaCTBCMS) FROM CTBCMS) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCTBCMS, 3)) FROM CTBCMS--
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MCTBCMS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
			WHEN @ID >= 9 THEN 'MCTBCMS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)--
		END
	RETURN @ID
END
go
CREATE TABLE CTBCMS(
	MaCTBCMS Varchar(50) primary key default ([dbo].[AUTO_MCTBCMS]()),
	MaBaoCaoMuonSach Varchar(50) not null,
	MaTheLoai Varchar(50) not null,
	SoLuotMuon int not null,
	TiLe float not null
	)
------------------------------------

CREATE TABLE BCTRATRE(
	NgayThangNam smalldatetime primary key default getdate(),
	MaCuonSach Varchar(50) not null,
	MaPhieuMuonSach Varchar(50) not null,
	SoNgayTraTre int not null
	)
CREATE TABLE THAMSO(
	ThoiHanThe int not null,
	TuoiToiThieu int not null,
	TuoiToiDa int not null,
	ThoiGianLuuHanh int not null,
	SoNgayMuonMax int not null,
	SoSachMuonMax int not null,
	MucThuTienPhat money not null
	)
------------------------------------
ALTER TABLE DOCGIA ADD CONSTRAINT FK_DG FOREIGN KEY (MaLoaiDocGia) REFERENCES LOAIDOCGIA(MaLoaiDocGia)
ALTER TABLE SACH ADD CONSTRAINT FK_S FOREIGN KEY (MaDauSach) REFERENCES DAUSACH(MaDauSach)
ALTER TABLE DAUSACH ADD CONSTRAINT FK_DS FOREIGN KEY (MaTheLoai) REFERENCES THELOAI(MaTheLoai)
ALTER TABLE CUONSACH ADD CONSTRAINT FK_CS FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
ALTER TABLE CTTACGIA ADD CONSTRAINT FK_CTTG FOREIGN KEY (MaDauSach) REFERENCES DAUSACH(MaDauSach)
ALTER TABLE CTTACGIA ADD CONSTRAINT FK_CTTG01 FOREIGN KEY (MaTacGia) REFERENCES TACGIA(MaTacGia)
ALTER TABLE PHIEUMUON ADD CONSTRAINT FK_PM FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia)
ALTER TABLE CTPHIEUMUON ADD CONSTRAINT FK_CTPM FOREIGN KEY (MaCuonSach) REFERENCES CUONSACH(MaCuonSach)
ALTER TABLE CTPHIEUMUON ADD CONSTRAINT FK_CTPM01 FOREIGN KEY (MaPhieuMuonSach) REFERENCES PHIEUMUON(MaPhieuMuonSach)
ALTER TABLE PHIEUTRASACH ADD CONSTRAINT FK_PT FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia)
ALTER TABLE CTPT ADD CONSTRAINT FK_CTPT FOREIGN KEY (MaCuonSach) REFERENCES CUONSACH(MaCuonSach)
ALTER TABLE CTPT ADD CONSTRAINT FK_CTPT01 FOREIGN KEY (MaPhieuTraSach) REFERENCES PHIEUTRASACH(MaPhieuTraSach)
ALTER TABLE CTPT ADD CONSTRAINT FK_CTPT02 FOREIGN KEY (MaPhieuMuonSach) REFERENCES PHIEUMUON(MaPhieuMuonSach)
ALTER TABLE CTPHIEUNHAP ADD CONSTRAINT FK_CTPN FOREIGN KEY (MaPhieuNhapSach) REFERENCES PHIEUNHAPSACH(MaPhieuNhapSach)
ALTER TABLE CTPHIEUNHAP ADD CONSTRAINT FK_CTPN01 FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
ALTER TABLE PHIEUTHUTIEN ADD CONSTRAINT FK_PTT FOREIGN KEY (MaDocGia) REFERENCES DOCGIA(MaDocGia)
ALTER TABLE CTBCMS ADD CONSTRAINT FK_CTBCMS FOREIGN KEY (MaTheLoai) REFERENCES THELOAI(MaTheLoai)
ALTER TABLE CTBCMS ADD CONSTRAINT FK_CTBCMS01 FOREIGN KEY (MaBaoCaoMuonSach) REFERENCES BAOCAOMUONSACH(MaBaoCaoMuonSach)
ALTER TABLE BCTRATRE ADD CONSTRAINT FK_BCTT FOREIGN KEY (MaCuonSach) REFERENCES CUONSACH(MaCuonSach)
ALTER TABLE BCTRATRE ADD CONSTRAINT FK_BCTT02 FOREIGN KEY (MaPhieuMuonSach) REFERENCES PHIEUMUON(MaPhieuMuonSach)
------------------
---------------------------------------------------------
insert into TACGIA (TenTacGia) values (N'Nguyễn Nhật Ánh')
insert into TACGIA (TenTacGia) values (N'Dale Caregie')
insert into TACGIA (TenTacGia)values (N'Nam Cao')
insert into TACGIA (TenTacGia)values (N'Kim Lân')
insert into TACGIA (TenTacGia)values (N'Ngô Tất Tố')
insert into TACGIA (TenTacGia)values (N'Vũ Trọng Phụng')
insert into TACGIA (TenTacGia)values (N'Hồ Chí Minh')
insert into TACGIA (TenTacGia) values (N'Andrew Matthews')
insert into TACGIA (TenTacGia) values (N'Paulo Coelho')
insert into TACGIA (TenTacGia) values (N'Xuân Diệu')
---------------------------------------------------------
insert into THELOAI (TenTheLoai) values ('A')
insert into THELOAI (TenTheLoai) values ('B')
insert into THELOAI (TenTheLoai) values ('C')
---------------------------------------------------------
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Đắc Nhân Tâm','MTL001')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Tắt Đèn','MTL002')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Số Đỏ','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Chí Phèo','MTL002')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Nhà Giả Kim','MTL002')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Đời Thay Đổi Khi Chúng Ta Thay Đổi','MTL001')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Vợ Nhặt','MTL002')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Sống Mòn','MTL001')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Thơ Thơ','MTL003')
insert into DAUSACH (TenDauSach,MaTheLoai) values (N'Nhật Ký Trong Tù','MTL002')
---------------------------------------------------------

insert into CTTACGIA values ('MDS001','MTG002')
insert into CTTACGIA values ('MDS002','MTG005')
insert into CTTACGIA values ('MDS003','MTG006')
insert into CTTACGIA values ('MDS004','MTG003')
insert into CTTACGIA values ('MDS005','MTG009')
insert into CTTACGIA values ('MDS006','MTG008')
insert into CTTACGIA values ('MDS007','MTG004')
insert into CTTACGIA values ('MDS008','MTG003')
insert into CTTACGIA values ('MDS009','MTG010')
insert into CTTACGIA values ('MDS010','MTG007')

---------------------------------------------------------
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,SoLuong,TriGia) values ('MDS001',N'Nhà Xuất Bản Trẻ','2018','1','100000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,SoLuong,TriGia) values ('MDS002',N'Nhà Xuất Bản Văn Học','2019','1','100000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,SoLuong,TriGia) values ('MDS003',N'Nhà Xuất Bản Văn Học','2019','1','200000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,SoLuong,TriGia) values ('MDS004',N'Nhà Xuất Bản Văn Học','2018','1','150000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,SoLuong,TriGia) values ('MDS005',N'Nhà Xuất Bản Văn Học','2019','1','100000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,SoLuong,TriGia) values ('MDS006',N'Nhà Xuất Bản Trẻ','2020','1','105000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,SoLuong,TriGia) values ('MDS007',N'Nhà Xuất Bản Văn Học','2021','1','100000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,SoLuong,TriGia) values ('MDS008',N'Nhà Xuất Bản Văn Học','2020','1','120000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,SoLuong,TriGia) values ('MDS009',N'Nhà Xuất Bản Văn Học','2019','1','170000')
insert into SACH (MaDauSach,NhaXuatBan,NamXuatBan,SoLuong,TriGia) values ('MDS010',N'Nhà Xuất Bản Văn Học','2020','1','150000')
---------------------------------------------------------
insert into CUONSACH (MaSach,TinhTrang) values ('MS001','1')
insert into CUONSACH (MaSach,TinhTrang) values ('MS002','1')
insert into CUONSACH (MaSach,TinhTrang) values ('MS003','1')
insert into CUONSACH (MaSach,TinhTrang) values ('MS004','1')
insert into CUONSACH (MaSach,TinhTrang) values ('MS005','1')
insert into CUONSACH (MaSach,TinhTrang) values ('MS006','1')
insert into CUONSACH (MaSach,TinhTrang) values ('MS007','1')
insert into CUONSACH (MaSach,TinhTrang) values ('MS008','1')
insert into CUONSACH (MaSach,TinhTrang) values ('MS009','1')
insert into CUONSACH (MaSach,TinhTrang) values ('MS010','1')

---------------------------------------------------------
insert into LOAIDOCGIA(TenLoaiDocGia) values ('X')
insert into LOAIDOCGIA(TenLoaiDocGia) values ('Y')
---------------------------------------------------------
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,NgHetHan,TongNo) values (N'Nguyễn Phúc Khang','MLDG001','10/5/2001',N'Hồ Chí Minh',N'Khang001@gmail.com','2-1-2022','2-7-2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,NgHetHan,TongNo) values (N'Nguyễn Văn Pháp','MLDG001','22/5/2002',N'Đông Hòa, Dĩ An',N'PhapNguyen@gmail.com','12/3/2022','12/9/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,NgHetHan,TongNo) values (N'Nguyễn Khúc Thùy Tiên','MLDG001','1/2/2000',N'khu phố 9, Linh Trung, Thủ Đức',N'TienHoaHau@gmail.com','1/4/2022','1/10/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,NgHetHan,TongNo) values (N'Trần Đình Phúc','MLDG002','23/6/1999',N'Linh Trung, Thủ Đức',N'PhucBoy@gmail.com','13/4/2022','13/10/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,NgHetHan,TongNo) values (N'Nguyễn Thị Linh','MLDG002','2/1/1998',N'Bình Dương',N'LinhCute@gmail.com','10/4/2022','10/10/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,NgHetHan,TongNo) values (N'Trần Bảo Ngọc','MLDG001','1/1/2000',N'Hồ Chí Minh',N'NgocIUI@gmail.com','13/4/2022','13/10/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,NgHetHan,TongNo) values (N'Nguyễn Hoàng Linh Chi','MLDG002','1/10/1997',N'Khu phố 7,Linh Trung, Thủ Đức',N'LinhChi1997@gmail.com','1/5/2022','1/11/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,NgHetHan,TongNo) values (N'Trần Dư Gia Bảo','MLDG001','8/1/2002',N'Linh Trung, Thủ Đức',N'BaoVip@gmail.com','5/5/2022','5/11/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,NgHetHan,TongNo) values (N'Nguyễn Cát Thiên Di','MLDG001','20/02/2002',N'Hồ Chí Minh',N'DiThien00@gmail.com','6/5/2022','6/11/2022','0')
insert into DOCGIA (Hoten,MaLoaiDocGia,NgSinh,DChi,Email,NgLapThe,NgHetHan,TongNo) values (N'Hoàng Ngọc Bảo Tiên','MLDG002','1/2/1991',N'Hồ Chí Minh',N'TienTien@gmail.com','10/5/2022','10/11/2022','0')
---------------------------------------------------------
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG001','11/1/2022','15/1/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG002','15/3/2022','19/3/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG003','15/4/2022','19/4/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG004','20/4/2022','24/4/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG005','25/4/2022','29/4/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG006','30/4/2022','4/5/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG007','16/5/2022','20/5/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG008','20/5/2022','24/5/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG009','22/5/2022','26/5/2022')
insert into PHIEUMUON (MaDocgia,NgMuon,HanTra) values ('DG010','28/5/2022','2/6/2022')
---------------------------------------------------------                        
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS001','MCS001','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS002','MCS002','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS003','MCS003','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS004','MCS004','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS005','MCS005','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS006','MCS006','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS007','MCS007','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS008','MCS008','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS009','MCS009','1')
insert into CTPHIEUMUON (MaPhieuMuonSach,MaCuonSach,TinhTrangPM) values ('MPMS010','MCS010','1')
---------------------------------------------------------
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG001','12/1/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG002','16/3/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG003','16/4/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG004','21/4/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG005','26/4/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG006','1/5/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG007','17/5/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG008','21/5/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG009','23/5/2022','0')
insert into PHIEUTRASACH (MaDocgia,NgTra,TienPhatKyNay) values ('DG010','29/5/2022','0')
---------------------------------------------------------                          
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS001','MCS001','MPMS001','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS002','MCS002','MPMS002','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS003','MCS003','MPMS003','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS004','MCS004','MPMS004','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS005','MCS005','MPMS005','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS006','MCS006','MPMS006','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values 
('MPTS007','MCS007','MPMS007','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS008','MCS008','MPMS008','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values ('MPTS009','MCS009','MPMS009','1','0')
insert into CTPT (MaPhieuTraSach,MaCuonSach,MaPhieuMuonSach,SoNgayMuon,TienPhat) values 
('MPTS010','MCS010','MPMS010','1','0')
---------------------------------------------------------
insert into PHIEUNHAPSACH (NgLap,TongTien) values ('1/1/2020','1295000')
---------------------------------------------------------
insert into CTPHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia,ThanhTien) values ('MPNS001','MS001','1','100000','100000')
insert into CTPHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia,ThanhTien) values ('MPNS001','MS002','1','100000','100000')
insert into CTPHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia,ThanhTien) values ('MPNS001','MS003','1','200000','200000')
insert into CTPHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia,ThanhTien) values ('MPNS001','MS004','1','150000','150000')
insert into CTPHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia,ThanhTien) values ('MPNS001','MS005','1','100000','100000')
insert into CTPHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia,ThanhTien) values ('MPNS001','MS006','1','105000','105000')
insert into CTPHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia,ThanhTien) values ('MPNS001','MS007','1','100000','100000')
insert into CTPHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia,ThanhTien) values ('MPNS001','MS008','1','120000','120000')
insert into CTPHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia,ThanhTien) values ('MPNS001','MS009','1','170000','170000')
insert into CTPHIEUNHAP (MaPhieuNhapSach,MaSach,SoLuong,DonGia,ThanhTien) values ('MPNS001','MS010','1','150000','150000')
---------------------------------------------------------

insert into BAOCAOMUONSACH ( ThangNam,TongSoLuotMuon) values ('3/1/2022','1')
insert into BAOCAOMUONSACH ( ThangNam,TongSoLuotMuon) values ('3/3/2022','1')
insert into BAOCAOMUONSACH ( ThangNam,TongSoLuotMuon) values ('30/4/2022','3')
insert into BAOCAOMUONSACH ( ThangNam,TongSoLuotMuon) values ('3/5/2022','5')
---------------------------------------------------------
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS001','MTL001','1','0.1')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS002','MTL002','1','0.1')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS003','MTL003','1','0.1')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS003','MTL002','2','0.2')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS004','MTL001','2','0.2')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS004','MTL002','2','0.2')
insert into CTBCMS (MaBaoCaoMuonSach,MaTheLoai,SoLuotMuon,TiLe) values ('MBCMS004','MTL003','1','0.1')
---------------------------------------------------------
insert into THAMSO values ('6','18','55','8','4','5','1000')
---------------------------------------------------------

---------------------------------------------------------



