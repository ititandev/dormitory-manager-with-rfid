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
    public class NhanVienBUS
    {
        NhanVienDAO nhanVienDAO = new NhanVienDAO();

        public static void LayDS(DataGridView dgv)
        {
            DataTable dt = NhanVienDAO.LayDSNhanVien();
            dgv.DataSource = dt;
        }

        public void Them(NhanVienDTO nvDTO)
        {
            nhanVienDAO.Them(nvDTO);
        }

        public void Sua(NhanVienDTO nvDTO)
        {
            nhanVienDAO.Sua(nvDTO);
        }

        public void Xoa(NhanVienDTO nvDTO)
        {
            nhanVienDAO.Xoa(nvDTO);
        }

        public void TimKiem(DataGridView dgv, NhanVienDTO nvDTO)
        {
            dgv.DataSource = nhanVienDAO.TimKiem(nvDTO);
        }
        public static string GetHoTen(string maNhanVien)
        {
            return NhanVienDAO.GetHoTen(maNhanVien);
        }
    }
}
