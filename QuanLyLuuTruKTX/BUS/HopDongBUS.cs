using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DAO;

namespace BUS
{
    public class HopDongBUS
    {
        HopDongDAO hopDongDAO = new HopDongDAO();
        public static void ViewAll(DataGridView dgv)
        {
            DataTable dt = HopDongDAO.ViewAll();
            dt.Columns[0].ColumnName = "Mã số";
            dt.Columns[1].ColumnName = "MSSV";
            dt.Columns[2].ColumnName = "Mã nhân viên";
            dt.Columns[3].ColumnName = "Ngày lập";
            dt.Columns[4].ColumnName = "Ngày bắt đầu";
            dt.Columns[5].ColumnName = "Ngày kết thúc";
            dgv.DataSource = dt;
        }
    }
}
