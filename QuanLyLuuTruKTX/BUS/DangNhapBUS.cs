using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    /// <summary>
    /// Class xử lý nghiệp vụ của form Đăng nhập
    /// </summary>
    public class DangNhapBUS
    {
        private TaiKhoanDAO tkdao = new TaiKhoanDAO();
        /// <summary>
        /// Kiểm tra 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool KiemTra(TextBox user, TextBox pass)
        {
            if (user.Text != "")
            {
                if (user.Text.Contains("'"))
                {
                    MessageBox.Show("Tên không hợp lệ", "Dang Nhap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    user.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên", "Dang Nhap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user.Focus();
                return false;
            }

            if (pass.Text != "")
            {
                if (pass.Text.Contains("'"))
                {
                    MessageBox.Show("Mật khẩu không hợp lệ", "Dang Nhap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pass.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mật khẩu", "Dang Nhap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pass.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Get mã nhân viên theo tên đăng nhập
        /// </summary>
        /// <param name="txtTaiKhoan"></param>
        /// <returns></returns>
        public static string GetMaNhanVien(TextBox txtTaiKhoan)
        {
            SqlDataReader reader = TaiKhoanDAO.GetMaNhanVien(txtTaiKhoan.Text);
            if (reader.Read())
                return Convert.ToString(reader["MaNhanVien"]);
            else
                return null;
        }
        /// <summary>
        /// Kiểm tra thông tin đăng nhập
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool DangNhap(TextBox user, TextBox pass)
        {
            TaiKhoanDTO tkdto = new TaiKhoanDTO();
            tkdto.TenDangNhap = user.Text;
            tkdto.MatKhau = pass.Text;
            DataTable table = TaiKhoanDAO.DangNhap(tkdto);
            if (table.Rows.Count == 1)
            {
                string str = table.Rows[0]["MatKhau"].ToString();
                if (str == tkdto.MatKhau)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        /// <summary>
        /// Get họ tên của nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="maNhanVien"></param>
        /// <returns></returns>
        public static string GetHoTen(string maNhanVien)
        {
            return TaiKhoanDAO.GetHoTen(maNhanVien);
        }
    }
}
