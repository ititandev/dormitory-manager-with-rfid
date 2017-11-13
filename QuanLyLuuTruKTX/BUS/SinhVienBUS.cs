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
        public static string RFID = "RFID";

        /// <summary>
        /// Xem tất cả Sinh viên từ cơ sở dữ liệu
        /// </summary>
        /// <returns></returns>
        public static DataTable XemTatCa()
        {
            DataTable dt = Data.ExecuteQuery("SELECT * FROM SinhVien");
            dt.Columns[0].ColumnName = MaSo;
            dt.Columns[1].ColumnName = HoTen;
            dt.Columns[2].ColumnName = NgaySinh;
            dt.Columns[3].ColumnName = GioiTinh;
            dt.Columns[4].ColumnName = CMND;
            dt.Columns[5].ColumnName = Lop;
            dt.Columns[6].ColumnName = DienThoai;
            dt.Columns[7].ColumnName = Khoa;
            dt.Columns[8].ColumnName = Que;
            dt.Columns[9].ColumnName = DienUuTien;
            dt.Columns[10].ColumnName = Anh;
            dt.Columns[11].ColumnName = Email;
            dt.Columns[12].ColumnName = RFID;
            return dt;
        }
        public static void CapNhatSinhVien(SinhVienDTO sv)
        {
            string query = ($"UPDATE SinhVien SET HoTen = N\'{sv.HoTen}\' , GioiTinh=N\'{sv.GioiTinh}\', MSSV = \'{sv.MSSV}\' , NgaySinh = \'{sv.NgaySinh}\' , CMND = \'{sv.CMND}\' , SoDienThoai = \'{sv.SoDienThoai}\' , Lop = \'{sv.Lop}\' , Khoa = \'{sv.Khoa}\' , QueQuan = N\'{sv.QueQuan}\' , DienUuTien = N\'{sv.DienUuTien}\' , Anh = \'{sv.Anh}\' , Email = \'{sv.Email}\' WHERE MSSV={sv.MSSV}");
            Data.ExecuteNonQuery(query);
        }
        public static void XoaSinhVien(string key)
        {
            string query = ($"DELETE FROM SinhVien WHERE MSSV={key}");
            Data.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Thêm sinh viên theo SinhVienDTO truyền vào
        /// </summary>
        /// <param name="sv"></param>
        public static void ThemSinhVien(SinhVienDTO sv)
        {
            if (SinhVienDAO.ThemSinhVien(sv) == 0)
                MessageBox.Show("Thêm sinh viên '" + sv.HoTen + "' (" + sv.MSSV + ") thành công");
            else
                MessageBox.Show("Thêm sinh viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Kiểm tra hợp đồng sinh viên theo MSSV có hợp lệ hay không
        /// </summary>
        /// <param name="MSSV"></param>
        /// <returns></returns>
        public static bool KiemTraHopDongSV(string MSSV)
        {
            if (SinhVienDAO.KiemTraSV(MSSV) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Lấy SinhVienDTO theo MSSV
        /// </summary>
        /// <param name="MSSV"></param>
        /// <returns></returns>
        public static SinhVienDTO GetSinhVienDTO(string MSSV)
        {
            return SinhVienDAO.GetSinhVienDTO(MSSV);
        }
    }
}
