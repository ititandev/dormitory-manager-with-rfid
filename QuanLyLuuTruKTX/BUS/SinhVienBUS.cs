using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public static class SinhVienBUS
    {
        public static string HoTen = "Họ và tên";
        public static string MaSo = "Mã số";
        public static string NgaySinh = "Ngày sinh";
        public static string GioiTinh = "Giới tính";
        public static string CMND = "CMND";
        public static string DienThoai = "Điện thoại";
        public static string Lop = "Lớp";
        public static string Khoa = "Khoa";
        public static string Que = "Quê";
        public static string DienUuTien = "Diện ưu tiên";
        public static string Anh = "Ảnh";
        public static string Email = "Email";
        public static string TongDiem = "Tổng điểm";
        public static DataTable viewAllStudent()
        {
            DataTable dt = Data.ExecuteQuery("SELECT SinhVien.*, DiemRenLuyen.TongDiem FROM SinhVien INNER JOIN DiemRenLuyen ON SinhVien.MSSV=DiemRenLuyen.MSSV");
            dt.Columns[0].ColumnName = HoTen;
            dt.Columns[1].ColumnName = MaSo;
            dt.Columns[2].ColumnName = NgaySinh;
            dt.Columns[3].ColumnName = GioiTinh;
            dt.Columns[4].ColumnName = CMND;
            dt.Columns[5].ColumnName = DienThoai;
            dt.Columns[6].ColumnName = Lop;
            dt.Columns[7].ColumnName = Khoa;
            dt.Columns[8].ColumnName = Que;
            dt.Columns[9].ColumnName = DienUuTien;
            dt.Columns[10].ColumnName = Anh;
            dt.Columns[11].ColumnName = Email;
            dt.Columns[12].ColumnName = TongDiem;
            return dt;
        }
        public static void updateSinhVien(SinhVienDTO sv)
        {
            string query = ($"UPDATE SinhVien SET HoTen = N\'{sv.HoTen}\' , GioiTinh=N\'{sv.GioiTinh}\', MSSV = \'{sv.MSSV}\' , NgaySinh = \'{sv.NgaySinh}\' , CMND = \'{sv.CMND}\' , SoDienThoai = \'{sv.SoDienThoai}\' , Lop = \'{sv.Lop}\' , Khoa = \'{sv.Khoa}\' , QueQuan = N\'{sv.QueQuan}\' , DienUuTien = N\'{sv.DienUuTien}\' , Anh = \'{sv.Anh}\' , Email = \'{sv.Email}\' WHERE MSSV={sv.MSSV}");
            Data.ExecuteNonQuery(query);
        }
        public static void deleteSinhVien(string key)
        {
            string query = ($"DELETE FROM SinhVien WHERE MSSV={key}");
            Data.ExecuteNonQuery(query);
            query = ($"DELETE FROM DiemRenLuyen WHERE MSSV={key}");
            Data.ExecuteNonQuery(query);
        }
        public static void addSinhVien(SinhVienDTO sv)
        {
            string query = $"INSERT INTO SinhVien(MSSV,HoTen,NgaySinh,GioiTinh,CMND,SoDienThoai,Lop,Khoa,QueQuan,DienUuTien,Anh,Email) VALUES('{sv.MSSV}',N'{sv.HoTen}','{sv.NgaySinh}',N'{sv.GioiTinh}','{sv.CMND}','{sv.SoDienThoai}','{sv.Lop}','{sv.Khoa}',N'{sv.QueQuan}',N'{sv.DienUuTien}','{sv.Anh}','{sv.Email}')";
            Data.ExecuteNonQuery(query);
            query = $"INSERT INTO DiemRenLuyen(MSSV,YThucCaNhan,KiemTraPhong,SinhHoat,ThamGiaKhac,CTXH,DiemThuongPhat,TongDiem) VALUES({sv.MSSV},0,0,0,0,0,0,0)";
            Data.ExecuteNonQuery(query);
        }

        public static bool KiemTraSV(string MSSV)
        {
            if (SinhVienDAO.KiemTraSV(MSSV) > 0)
                return true;
            else
                return false;
        }

        public static SinhVienDTO GetSinhVienDTO(string MSSV)
        {
            return SinhVienDAO.GetSinhVienDTO(MSSV);
        }
    }
}
