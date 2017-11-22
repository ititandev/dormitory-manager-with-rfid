using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DAO;
using DTO;
using System.Data.SqlClient;

namespace BUS
{
    /// <summary>
    /// Class xử lý nghiệp vụ của form phòng
    /// </summary>
    public class PhongBUS
    {
        /// <summary>
        /// Load thông tin phòng trong cơ sở dữ liệu
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadPhong()
        {
            return PhongDAO.LoadPhong();
        }
        /// <summary>
        /// Load thông tin sinh viên theo mã số phòng
        /// </summary>
        /// <param name="maphong"></param>
        /// <returns></returns>
        public static DataTable LoadSinhVien(string maphong)
        {
            return PhongDAO.LoadSinhVien(maphong);
        }
        /// <summary>
        /// Thêm phòng mới vào cơ sở dữ liệu
        /// </summary>
        /// <param name="phongDTO"></param>
        /// <returns></returns>
        public static bool ThemPhongDTO(PhongDTO phongDTO)
        {
            if (Data.KiemTraRong(phongDTO.IDPhong, phongDTO.KhuNha, phongDTO.SoPhong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PhongDAO.ThemPhong(phongDTO) == 1)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Sửa thông tin phòng trong cơ sở dữ liệu
        /// </summary>
        /// <param name="phongDTO"></param>
        /// <returns></returns>
        public static bool SuaPhongDTO(PhongDTO phongDTO)
        {
            if (Data.KiemTraRong(phongDTO.IDPhong, phongDTO.KhuNha, phongDTO.SoPhong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PhongDAO.SuaPhongDTO(phongDTO) == 1)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Kiểm tra một phòng trống hay không
        /// </summary>
        /// <param name="IDPhong"></param>
        /// <returns></returns>
        public static bool KiemTraPhong(string IDPhong)
        {
            return PhongDAO.KiemTraPhong(IDPhong);
        }
        /// <summary>
        /// Lấy thông tin chi tiết về một phòng
        /// </summary>
        /// <param name="IDPhong"></param>
        /// <returns></returns>
        public static PhongDTO GetPhongDTO(string IDPhong)
        {
            SqlDataReader reader = PhongDAO.GetPhongDTO(IDPhong);
            if (reader == null)
                return null;
            else
            {
                PhongDTO phongDTO = new PhongDTO();
                phongDTO.SoPhong = Convert.ToString(reader["SoPhong"]);
                phongDTO.KhuNha = Convert.ToString(reader["KhuNha"]);
                phongDTO.SoLuongToiDa = Convert.ToInt32(reader["SoLuongToiDa"]);
                phongDTO.TinhTrang = Convert.ToString(reader["TinhTrang"]);
                phongDTO.IDPhong = Convert.ToString(reader["IDPhong"]);
                phongDTO.SoLuongHienTai = Convert.ToInt32(reader["SoLuongHienTai"]);
                return phongDTO;
            }
        }
        /// <summary>
        /// Load thông tin sinh viên theo phòng
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadSinhVien()
        {
            return PhongDAO.LoadSinhVien();
        }
        /// <summary>
        /// Get Mã phòng của sinh viên có mã thẻ RFID truyền vào
        /// </summary>
        /// <param name="RFID"></param>
        /// <returns></returns>
        public static string GetIDPhongFromRFID(string RFID)
        {
            SqlDataReader reader = PhongDAO.GetIDPhongFromRFID(RFID);
            if (reader.Read())
                return Convert.ToString(reader["IDPhong"]);
            else
                return String.Empty;
        }
        /// <summary>
        /// Xóa một phòng
        /// </summary>
        /// <param name="IDPhong"></param>
        public static void XoaPhong(string IDPhong)
        {
            if (PhongDAO.XoaPhong(IDPhong))
                MessageBox.Show("Xóa thành công phòng " + IDPhong);
            else
                MessageBox.Show("Xóa thất bại phòng " + IDPhong, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
