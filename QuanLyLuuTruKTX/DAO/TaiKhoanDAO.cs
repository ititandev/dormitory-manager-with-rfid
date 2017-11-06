using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public DataTable DangNhap(TaiKhoanDTO tk)
        {
            string qry = "SELECT * from TaiKhoan where TenDangNhap = '" + tk.TenDangNhap + "'";
            return Data.ExecuteQuery(qry);
        }
    }
}
