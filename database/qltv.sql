CREATE DATABASE QLTV
USE QLTV
-----------------------
CREATE FUNCTION [dbo].[AUTO_IDDG]()
RETURNS VARCHAR(50)--
AS
BEGIN
	DECLARE @ID VARCHAR(50)--
	IF (SELECT COUNT(MaDocGia) FROM DOCGIA) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaDocGia, 29)) FROM DocGia--
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
RETURNS VARCHAR(50)--
AS
BEGIN
	DECLARE @ID VARCHAR(50)--
	IF (SELECT COUNT(MaLoaiDocGia) FROM LOAIDOCGIA) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaLoaiDocGia, 31)) FROM LOAIDOCGIA--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaSach) FROM SACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaSach, 29)) FROM Sach--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaCuonSach) FROM CuonSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCuonSach, 30)) FROM CuonSach--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaTheLoai) FROM TheLOAI) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaTheLoai, 30)) FROM TheLoai--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaDauSach) FROM DAUSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaDauSach, 30)) FROM DAUSACH--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaTacGia) FROM TACGIA) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaTacGia, 30)) FROM TacGia--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaPhieuMuonSach) FROM PHIEUMUON) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuMuonSach, 31)) FROM PHIEUMUON--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaChiTietPhieuMuon) FROM CTPHIEUMUON) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaChiTietPhieuMuon, 32)) FROM CTPHIEUMUON--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaPhieuTraSach) FROM PHIEUTraSach) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuTraSach, 31)) FROM PhieuTraSach--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaChiTietPhieuTra) FROM CTPT) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaChiTietPhieuTra, 32)) FROM CTPT--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaPhieuNhapSach) FROM PHIEUNHAPSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuNhapSach, 31)) FROM PHIEUNHAPSACH--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaCTPN) FROM CTPHIEUNHAP) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCTPN, 32)) FROM CTPHIEUNHAP--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaPhieuThu) FROM PHIEUTHUTIEN) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuThu, 30)) FROM PHIEUTHUTIEN--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaBaoCaoMuonSach) FROM BAOCAOMUONSACH) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaBaoCaoMuonSach, 32)) FROM BAOCAOMUONSACH--
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
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(MaCTBCMS) FROM CTBCMS) = 0--
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCTBCMS, 34)) FROM CTBCMS--
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