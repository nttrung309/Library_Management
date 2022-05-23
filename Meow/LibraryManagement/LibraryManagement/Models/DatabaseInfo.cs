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
        public static string bookStockQueryCmd = @"SELECT DISTINCT SACH.MaSach, TenDauSach, TenTheLoai, TenTacGia, CUONSACH.MaCuonSach
            FROM SACH, DAUSACH, CUONSACH, THELOAI, CTTACGIA, TACGIA
            WHERE SACH.MaDauSach = DAUSACH.MaDauSach AND DAUSACH.MaTheLoai = THELOAI.MaTheLoai
            AND DAUSACH.MaDauSach = CTTACGIA.MaDauSach AND CTTACGIA.MaTacGia = TACGIA.MaTacGia
            AND SACH.MaSach = CUONSACH.MaSach AND TinhTrang = 0
			ORDER BY SACH.MaSach";
        public static string parametersQueryCmd = @"SELECT * from THAMSO";
        public static string readersQueryCmd = @"SELECT MaDocGia, HoTen, NgHetHan, Email
            FROM DOCGIA
            WHERE NgHetHan >= GETDATE()";
        public static string getBookSlipCode = @"SELECT TOP (1) MAPHIEUMUONSACH
            FROM phieumuon
            ORDER BY maphieumuonsach DESC";
        public static string GetNumOfBooksBorrowed(string bookCode)
        {
            return $@"SELECT count(*)
                FROM PHIEUMUON, CTPHIEUMUON
                WHERE MaDocGia = '{bookCode}' AND PHIEUMUON.MaPhieuMuonSach = CTPHIEUMUON.MaPhieuMuonSach";
        }
    }
}
