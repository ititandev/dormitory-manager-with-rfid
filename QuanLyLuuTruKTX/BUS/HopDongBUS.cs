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

        public static HopDongDTO GetHopDongDTO(string MaSo)
        {
            HopDongDTO hopDongDTO = HopDongDAO.GetHopDongDTO(MaSo);
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
        public static string TimKiem(ComboBox cboThoiHan)
        {
            if (cboThoiHan.Text == "Tất cả")
                return "";
            else
                return $"[Thời hạn] LIKE '%{cboThoiHan.Text}%' ";
        }

        public static string TimKiem(RadioButton chxTheoTinhTrang, ComboBox cboTinhTrang, RadioButton chxTheoThoiHan,
                                    DateTimePicker dtpNgayBatDauTimKiem, DateTimePicker dtpNgayKetThucTimKiem, RadioButton chxChuaDuTien, ComboBox cboTimKiemTheo, TextBox txtTimKiem, DateTimePicker dtpNgayLap)
        {
            string filter = String.Empty;
            if (chxTheoTinhTrang.Checked)
            {
                if (cboTinhTrang.Text == "Tất cả")
                    filter = "";
                else
                    filter = $"[Thời hạn] LIKE '%{cboTinhTrang.Text}%' ";
            }
            else if (chxTheoThoiHan.Checked)
                filter = "[Ngày bắt đầu] >= '"
                        + dtpNgayBatDauTimKiem.Value.ToString("d/M/yyyy")
                        + "' AND [Ngày kết thúc] <= '"
                        + dtpNgayKetThucTimKiem.Value.ToString("d/M/yyyy")
                        + "' ";
            else if (chxChuaDuTien.Checked)
                filter = "[Đã nộp] < [Tổng cộng] ";


            if (cboTimKiemTheo.Text != String.Empty && cboTimKiemTheo.Text != "Tất cả")
            {
                if (filter != String.Empty)
                    filter += "AND ";
                if (cboTimKiemTheo.Text == "Ngày lập")
                    filter += $"[Ngày lập] = #{dtpNgayLap.Value.ToString("yyyy-M-d")}# ";
                else
                    filter += $" [{cboTimKiemTheo.Text}] LIKE '%{txtTimKiem.Text}%' ";
            }
            return filter;
        }
    }
}
    
