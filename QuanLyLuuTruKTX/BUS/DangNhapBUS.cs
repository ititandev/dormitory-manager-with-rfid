using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class DangNhapBUS
    {
        private TaiKhoanDAO tkdao = new TaiKhoanDAO();

        public bool KiemTra(TextBox user, TextBox pass)
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

        public bool DangNhap(TextBox user, TextBox pass)
        {
            TaiKhoanDTO tkdto = new TaiKhoanDTO();
            tkdto.TenDangNhap = user.Text;
            tkdto.MatKhau = pass.Text;
            DataTable table = tkdao.DangNhap(tkdto);
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
    }
}
