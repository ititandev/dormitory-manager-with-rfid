using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    /// <summary>
    /// Class truy xuất dữ liệu liên quan tới Phòng
    /// </summary>
    public class PhongDAO
    {
        /// <summary>
        /// Load dữ liệu các phòng trong cơ sở dữ liệu kèm tính toàn số lượng hiện tại của mỗi phòng tại thời gian thực thi
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadPhong()
        {
            return Data.ExecuteQuery(@"SELECT IDPhong, KhuNha, SoPhong, 
                                        (SELECT COUNT(*) FROM HopDong
                                        WHERE Phong.IDPhong = HopDong.IDPhong COLLATE DATABASE_DEFAULT
                                        AND dbo.KiemTraThoiHan(HopDong.MSSV) = 1)
                                        AS SoLuongHienTai, SoLuongToiDa, TinhTrang FROM Phong");
        }
        /// <summary>
        /// Load dữ liệu các sinh viên theo mã phòng truyền vào
        /// </summary>
        /// <param name="maphong"></param>
        /// <returns></returns>
        public static DataTable LoadSinhVien(string maphong)
        {
            return Data.ExecuteQuery(@"SELECT HopDong.IDPhong, HopDong.MSSV, HoTen, RFID FROM HopDong 
                                        LEFT JOIN  SinhVien ON HopDong.MSSV = SinhVien.MSSV 
                                        WHERE dbo.KiemTraThoiHan(HopDong.MSSV) = 1 AND HopDong.IDPhong='"+maphong+"'");
        }
        /// <summary>
        /// Thêm 1 phòng vào cơ sở dữ liệu bằng PhongDTO
        /// </summary>
        /// <param name="phongDTO"></param>
        /// <returns></returns>
        public static int ThemPhong(PhongDTO phongDTO)
        {
            string str = "INSERT into Phong VALUES('"
                        + phongDTO.IDPhong + "','"
                        + phongDTO.KhuNha + "','"
                        + phongDTO.SoPhong + "','"
                        + phongDTO.SoLuongToiDa + "',N'"
                        + phongDTO.TinhTrang + "')";

            return Data.ExecuteNonQuery(str);
        }
        /// <summary>
        /// Sửa thông tin một phòng bằng PhongDTO
        /// </summary>
        /// <param name="phongDTO"></param>
        /// <returns></returns>
        public static int SuaPhongDTO(PhongDTO phongDTO)
        {
            string str = "UPDATE Phong SET SoPhong = '" + phongDTO.SoPhong +
                        "',KhuNha = '" + phongDTO.KhuNha +
                        "',SoLuongToiDa = '" + phongDTO.SoLuongToiDa +
                        "',TinhTrang = N'" + phongDTO.TinhTrang +
                        "' WHERE IDPhong = '" + phongDTO.IDPhong + "'";
            return Data.ExecuteNonQuery(str);
        }
        /// <summary>
        /// Get Mã phòng của sinh viên có mã thẻ RFID truyền vào
        /// </summary>
        /// <param name="RFID"></param>
        /// <returns></returns>
        public static SqlDataReader GetIDPhongFromRFID(string RFID)
        {
            return Data.ExecuteReader(@"SELECT HopDong.IDPhong, RFID FROM HopDong 
                                        LEFT JOIN SinhVien ON HopDong.MSSV = SinhVien.MSSV 
                                        WHERE dbo.KiemTraThoiHan(HopDong.MSSV) = 1 AND RFID ='" + RFID +"'");
        }
        /// <summary>
        /// Load tất cả sinh viên theo phòng ở tại thời gian thực thi
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadSinhVien()
        {
            return Data.ExecuteQuery(@"SELECT HopDong.IDPhong, HopDong.MSSV, HoTen, RFID FROM HopDong 
                                        LEFT JOIN  SinhVien ON HopDong.MSSV = SinhVien.MSSV 
                                        WHERE dbo.KiemTraThoiHan(HopDong.MSSV) = 1 ");
        }
        /// <summary>
        /// Get thông tin về một phòng (PhongDTO) theo Mã phòng
        /// </summary>
        /// <param name="IDPhong"></param>
        /// <returns></returns>
        public static SqlDataReader GetPhongDTO(string IDPhong)
        {
            SqlDataReader reader = Data.ExecuteReader(@"SELECT Phong.IDPhong, KhuNha, SoPhong, 
                                                    (SELECT COUNT(*) FROM HopDong
                                                    WHERE Phong.IDPhong = HopDong.IDPhong COLLATE DATABASE_DEFAULT
                                                    AND dbo.KiemTraThoiHan(HopDong.MSSV) = 1)
                                                    AS SoLuongHienTai,
                                                    SoLuongToiDa, TinhTrang FROM Phong WHERE IDPhong = '"+IDPhong+"'");
            if (reader.Read())
                return reader;
            else
                return null;
        }
        /// <summary>
        /// Xóa một phòng theo Mã phòng
        /// </summary>
        /// <param name="IDPhong"></param>
        /// <returns></returns>
        public static bool XoaPhong(string IDPhong)
        {
            string query = "DELETE FROM Phong WHERE IDPhong = '" + IDPhong + "'";
            if (Data.ExecuteNonQuery(query) == 1)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Kiểm tra một phòng có còn trống hay không theo Mã phòng
        /// </summary>
        /// <param name="IDPhong"></param>
        /// <returns></returns>
        public static bool KiemTraPhong(string IDPhong)
        {
            int SoLuongToiDa;
            SqlDataReader reader = Data.ExecuteReader($"SELECT SoLuongToiDa FROM Phong WHERE IDPhong = '{IDPhong}'");
            if (reader.Read())
                SoLuongToiDa = Convert.ToInt32(reader[0]);
            else
                return false;
            reader = Data.ExecuteReader(@"SELECT COUNT(*) FROM HopDong
                                        WHERE HopDong.IDPhong = '" + IDPhong + "' AND dbo.KiemTraThoiHan(HopDong.MSSV) = 1");
            if (reader.Read() && Convert.ToInt32(reader[0]) < SoLuongToiDa)
                return true;
            return false;
        }
    }
}
