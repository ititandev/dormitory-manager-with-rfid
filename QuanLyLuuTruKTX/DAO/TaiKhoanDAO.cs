using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    /// <summary>
    /// Class truy xuất dữ liệu liên quan đến tài khoản
    /// </summary>
    public class TaiKhoanDAO
    {
        /// <summary>
        /// Lấy thông tin đăng nhập của các tài khoản trong cơ sở dữ liệu
        /// </summary>
        /// <param name="tk"></param>
        /// <returns></returns>
        public static DataTable DangNhap(TaiKhoanDTO tk)
        {
            string qry = "SELECT * FROM TaiKhoan WHERE TenDangNhap = '" + tk.TenDangNhap + "'";
            return Data.ExecuteQuery(qry);
        }
        /// <summary>
        /// Lấy mã nhân viên của tài khoản theo tên đăng nhập
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static SqlDataReader GetMaNhanVien(string text)
        {
            return Data.ExecuteReader("SELECT MaNhanVien FROM TaiKhoan WHERE TenDangNhap = '" + text + "'");
        }
        /// <summary>
        /// Lấy họ tên của nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="maNhanVien"></param>
        /// <returns></returns>
        public static string GetHoTen(string maNhanVien)
        {
            SqlDataReader reader = Data.ExecuteReader("SELECT HoTen FROM NhanVien WHERE MaNhanVien = '" + maNhanVien + "'");
            if (reader.Read())
                return Convert.ToString(reader[0]);
            else
                return String.Empty;
        }
    }
}
