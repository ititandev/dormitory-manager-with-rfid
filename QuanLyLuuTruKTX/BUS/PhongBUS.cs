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
    public class PhongBUS
    {
        PhongDAO phongDAO = new PhongDAO();
        public static void ViewAll(DataGridView dgv)
        {
            DataTable dt = PhongDAO.ViewAll();
            SetTitleColumn(dt);
            dgv.DataSource = dt;
        }

        public static void SetTitleColumn(DataTable dt) {
            dt.Columns[0].ColumnName = "Số phòng";
            dt.Columns[1].ColumnName = "Khu nhà";
            dt.Columns[2].ColumnName = "Mã nhân viên";
            dt.Columns[3].ColumnName = "Số lượng cho phép";
            dt.Columns[4].ColumnName = "Tình trạng";
            dt.Columns[5].ColumnName = "Mã phòng";
            dt.Columns[6].ColumnName = "Số lượng hiện tại";
        }

        public void Them(PhongDTO phongDTO)
        {
            phongDAO.Them(phongDTO);
        }

        public void Sua(PhongDTO phongDTO)
        {
            phongDAO.Sua(phongDTO);
        }

        public void TimKiem(DataGridView dgv, string searchText)
        {
            DataTable dt = phongDAO.TimKiem(searchText);
            SetTitleColumn(dt);
            dgv.DataSource = dt;
        }

        public void TimKiem(DataGridView dgv, PhongDTO obj)
        {
            DataTable dt = phongDAO.TimKiem(obj);
            SetTitleColumn(dt);
            dgv.DataSource = dt;
        }
    }
}
