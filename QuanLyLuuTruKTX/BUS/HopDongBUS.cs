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
    public class HopDongBUS
    {
        HopDongDAO hopDongDAO = new HopDongDAO();
        public static DataTable ViewAll(DataGridView dgv)
        {
            return HopDongDAO.ViewAll();
        }

        public static HopDongDTO ViewHopDong(string MaSo, out string tenNhanVien)
        {
            HopDongDTO hopDongDTO = HopDongDAO.GetHopDongDTO(MaSo);
            tenNhanVien = "nhanvien1";
            return hopDongDTO;
        }
        public static void AddHopDong(HopDongDTO hopDongDTO)
        {
            if (hopDongDTO.NgayLap >= hopDongDTO.NgayBatDau)
            {
                MessageBox.Show("Ngày bắt đầu hợp đồng phải sau ngày lập hợp đồng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hopDongDTO.NgayBatDau >= hopDongDTO.NgayKetThuc)
            {
                MessageBox.Show("Ngày kết thúc hợp đồng phải sau ngày bắt đầu hợp đồng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool result = HopDongDAO.AddHopDongDTO(hopDongDTO);
            if (result)
                MessageBox.Show("Thêm thành công Hợp đồng");
            else
                MessageBox.Show("Thêm thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
