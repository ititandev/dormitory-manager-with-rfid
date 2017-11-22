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
    /// Class xử lý nghiệp vụ của form Hợp dồng
    /// </summary>
    public class HopDongBUS
    {
        /// <summary>
        /// Load tất cả hợp đồng từ cơ sở dữ liệu
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadHopDong()
        {
            DataTable dataTable = HopDongDAO.LoadHopDong();
            dataTable.Columns[0].ColumnName = "Mã số";
            dataTable.Columns[1].ColumnName = "MSSV";
            dataTable.Columns[2].ColumnName = "Người lập";
            dataTable.Columns[3].ColumnName = "Ngày lập";
            dataTable.Columns[4].ColumnName = "Ngày bắt đầu";
            dataTable.Columns[5].ColumnName = "Ngày kết thúc";
            dataTable.Columns[6].ColumnName = "Thời hạn";
            dataTable.Columns[7].ColumnName = "ID Phòng";
            dataTable.Columns[8].ColumnName = "Đã nộp";
            dataTable.Columns[9].ColumnName = "Tổng cộng";
            return dataTable;
        }
        /// <summary>
        /// Lấy HopDongDTO từ cơ sở dữ liệu theo mã số hợp đồng
        /// </summary>
        /// <param name="MaSo"></param>
        /// <returns></returns>
        public static HopDongDTO GetHopDongDTO(string MaSo)
        {
            HopDongDTO hopDongDTO = HopDongDAO.GetHopDongDTO(MaSo);
            return hopDongDTO;
        }
        /// <summary>
        /// Thêm hợp đồng vào cơ sở dữ liệu bằng HopDongDTO
        /// </summary>
        /// <param name="hopDongDTO"></param>
        public static void ThemHopDongDTO(HopDongDTO hopDongDTO)
        {
            if (Data.KiemTraRong(hopDongDTO.MSSV, hopDongDTO.MaNhanVien, hopDongDTO.IDPhong))
            {
                MessageBox.Show("Nhập thiếu thông tin hợp đồng, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hopDongDTO.GiaTienTongCong <= 0 || hopDongDTO.GiaTienDaNop > hopDongDTO.GiaTienTongCong)
            {
                MessageBox.Show("Nhập sai thông tin giá tiền, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            bool result = HopDongDAO.ThemHopDongDTO(hopDongDTO);
            if (result)
                MessageBox.Show("Thêm thành công Hợp đồng");
            else
                MessageBox.Show("Thêm thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Tìm kiếm nâng cao từ các control trên form
        /// </summary>
        /// <param name="chxTheoTinhTrang"></param>
        /// <param name="cboTinhTrang"></param>
        /// <param name="chxTheoThoiHan"></param>
        /// <param name="dtpNgayBatDauTimKiem"></param>
        /// <param name="dtpNgayKetThucTimKiem"></param>
        /// <param name="cboTimKiemTheo"></param>
        /// <param name="txtTimKiem"></param>
        /// <returns></returns>
        public static string TimKiem(RadioButton chxTheoTinhTrang, ComboBox cboTinhTrang, RadioButton chxTheoThoiHan,
                                    DateTimePicker dtpNgayBatDauTimKiem, DateTimePicker dtpNgayKetThucTimKiem, ComboBox cboTimKiemTheo, TextBox txtTimKiem)
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
                filter = "([Ngày bắt đầu] >= '"
                        + dtpNgayBatDauTimKiem.Value.ToString("d/M/yyyy")
                        + "' AND [Ngày kết thúc] <= '"
                        + dtpNgayKetThucTimKiem.Value.ToString("d/M/yyyy")
                        + "' )";

            if (filter != String.Empty)
                filter += "AND ";
            filter += " ( ";
            if (cboTimKiemTheo.Text != String.Empty && cboTimKiemTheo.Text != "Tất cả")
            {
                if (cboTimKiemTheo.Text == "Mã số")
                {
                    if (txtTimKiem.Text != String.Empty)
                        filter += $"[Mã số] = {txtTimKiem.Text} ";
                }
                else
                    filter += $" [{cboTimKiemTheo.Text}] LIKE '%{txtTimKiem.Text}%' ";
            }
            else
            {
                filter += $"[MSSV] LIKE '%{txtTimKiem.Text}%' " +
                        $"OR [Người lập] LIKE '%{txtTimKiem.Text}%' " +
                        $"OR [ID Phòng] LIKE '%{txtTimKiem.Text}%' ";
                if (txtTimKiem.Text != String.Empty)
                    filter += $"OR [Mã số] = {txtTimKiem.Text} ";
            }
            filter += " )";
            return filter;
        }
        /// <summary>
        /// Get, set connect string để kết nối cơ sở dữ liệu
        /// </summary>
        public static string ConnectString
        {
            get
            {
                return Data.ConnectString;
            }
            set
            {
                Data.ConnectString = value;
            }
        }
        /// <summary>
        /// Get danh sách hợp đồng dùng để in hợp đồng
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader GetHopDong()
        {
            string query = "SELECT MaSo, HopDong.MSSV, NgayBatDau, NgayKetThuc, HoTen, NgaySinh, Khoa, CMND, SoDienThoai, Email, QueQuan FROM HopDong, SinhVien WHERE HopDong.MSSV=SinhVien.MSSV";
            var dr = Data.ExecuteReader(query);
            return dr;
        }
        /// <summary>
        /// Xóa hợp đồng theo mã số hợp đồng
        /// </summary>
        /// <param name="MaSo"></param>
        /// <returns></returns>
        public static bool Xoa(string MaSo)
        {
            if (HopDongDAO.XoaHopDong(MaSo) == 1)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Kiểm tra sinh viên có hợp đồng trong thời hạn hay không
        /// </summary>
        /// <param name="MSSV"></param>
        /// <returns></returns>
        public static bool KiemTraThoiHan(string MSSV)
        {
            if (HopDongDAO.KiemTraThoiHan(MSSV) == 1)
                return true;
            else
                return false;
        }
    }
}

