using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class DatabaseInfo
    {
        public static string connectionString = @"Data Source=TRUNGNGUYEN\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        public static string bookStockQueryCmd = @"SELECT DISTINCT CUONSACH.MaSach, TenDauSach, TenTheLoai, TenTacGia, CUONSACH.MaCuonSach
            FROM SACH, DAUSACH, CUONSACH, THELOAI, CTTACGIA, TACGIA
            WHERE SACH.MaDauSach = DAUSACH.MaDauSach AND DAUSACH.MaTheLoai = THELOAI.MaTheLoai
            AND DAUSACH.MaDauSach = CTTACGIA.MaDauSach AND CTTACGIA.MaTacGia = TACGIA.MaTacGia
            AND SACH.MaSach = CUONSACH.MaSach AND TinhTrang = 0
			AND CUONSACH.MaCuonSach = (SELECT MAX(B.MaCuonSach)
				FROM CUONSACH B
				WHERE B.MaSach = CUONSACH.MaSach AND B. TinhTrang = 0)
			ORDER BY CUONSACH.MaSach";
        public static string parametersQueryCmd = @"SELECT * from THAMSO";
        public static string readersQueryCmd = @"SELECT MaDocGia, HoTen, NgHetHan, Email
            FROM DOCGIA
            WHERE NgHetHan >= GETDATE()";
        public static string getBookSlipCode = @"SELECT TOP (1) MAPHIEUMUONSACH
            FROM phieumuon
            ORDER BY maphieumuonsach DESC";
        public static string GetNumOfBooksBorrowed(string readerCode)
        {
            return $@"SELECT count(*)
                FROM PHIEUMUON, CTPHIEUMUON
                WHERE MaDocGia = '{readerCode}' AND PHIEUMUON.MaPhieuMuonSach = CTPHIEUMUON.MaPhieuMuonSach AND TinhTrangPM = 0";
        }
        public static string borrowSlipQuery = @"SELECT DISTINCT PHIEUMUON.MaPhieuMuonSach, PHIEUMUON.MaDocGia, HoTen, HanTra, TongNo, Email
                FROM PHIEUMUON, CTPHIEUMUON, DOCGIA
                WHERE PHIEUMUON.MaPhieuMuonSach = CTPHIEUMUON.MaPhieuMuonSach AND PHIEUMUON.MaDocGia = DOCGIA.MaDocGia
                        AND TinhTrangPM = 0";
        public static string borrowedBooksQuery = @"SELECT CTPHIEUMUON.MaPhieuMuonSach, SACH.MaSach, TenDauSach, NgMuon, CTPHIEUMUON.MaCuonSach, MaChiTietPhieuMuon
            FROM SACH, CUONSACH, PHIEUMUON, CTPHIEUMUON, DAUSACH
            WHERE PHIEUMUON.MaPhieuMuonSach = CTPHIEUMUON.MaPhieuMuonSach AND CTPHIEUMUON.MaCuonSach = CUONSACH.MaCuonSach
		            AND CUONSACH.MaSach = SACH.MaSach AND SACH.MaDauSach = DAUSACH.MaDauSach 
						AND TinhTrangPM = 0";
        public static string getNewReturnSlipCode = @"SELECT TOP (1) MAPHIEUTRASACH
            FROM PHIEUTRASACH
            ORDER BY MAPHIEUTRASACH DESC";
    }
}
