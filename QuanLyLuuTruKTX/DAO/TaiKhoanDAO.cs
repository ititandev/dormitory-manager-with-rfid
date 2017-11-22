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
    public class TaiKhoanDAO
    {
        public static DataTable DangNhap(TaiKhoanDTO tk)
        {
            string qry = "SELECT * FROM TaiKhoan WHERE TenDangNhap = '" + tk.TenDangNhap + "'";
            return Data.ExecuteQuery(qry);
        }

        public static SqlDataReader GetMaNhanVien(string text)
        {
            return Data.ExecuteReader("SELECT MaNhanVien FROM TaiKhoan WHERE TenDangNhap = '" + text + "'");
        }

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
