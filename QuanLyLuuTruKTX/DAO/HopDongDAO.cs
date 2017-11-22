using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    /// <summary>
    /// Class truy xuất dữ liệu liên quan tới hợp đồng
    /// </summary>
    public class HopDongDAO
    {
        /// <summary>
        /// Load tất cả hợp đồng trong cơ sở dữ liệu kèm kiểm tra thời hạn
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadHopDong()
        {
            return Data.ExecuteQuery(@"SELECT MaSo ,HopDong.MSSV ,NhanVien.HoTen,NgayLap ,NgayBatDau ,NgayKetThuc,
                                    case dbo.KiemTraThoiHan(HopDong.MSSV)
	                                    WHEN 0 THEN N'Chưa tới thời hạn'
	                                    WHEN 1 THEN N'Trong thời hạn'
	                                    WHEN 2 THEN N'Hết thời hạn'
	                                END AS ThoiHan, IDPhong, GiaTienTongCong, GiaTienDaNop, RFID
                                    FROM dbo.HopDong LEFT JOIN NhanVien ON 
                                    HopDong.MaNhanVien = NhanVien.MaNhanVien
                                    LEFT JOIN SinhVien ON HopDong.MSSV = SinhVien.MSSV");
        }
        /// <summary>
        /// Get thông tin hợp đồng (HopDongDTO) theo Mã số hợp đồng
        /// </summary>
        /// <param name="MaSo"></param>
        /// <returns></returns>
        public static HopDongDTO GetHopDongDTO(string MaSo)
        {
            SqlDataReader reader = Data.ExecuteReader("SELECT *, dbo.KiemTraThoiHan(MSSV) AS TinhTrang FROM HopDong WHERE MaSo = @MaSo", new string[] { MaSo });
            if (reader.Read())
            {
                HopDongDTO hopDongDTO = new HopDongDTO();

                hopDongDTO.MaSo = Convert.ToInt32(reader["MaSo"]);
                hopDongDTO.MSSV = Convert.ToString(reader["MSSV"]);
                hopDongDTO.MaNhanVien = Convert.ToString(reader["MaNhanVien"]);
                hopDongDTO.NgayLap = Convert.ToDateTime(reader["NgayLap"]);
                hopDongDTO.NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]);
                hopDongDTO.NgayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]);
                hopDongDTO.IDPhong = Convert.ToString(reader["IDPhong"]);
                hopDongDTO.GiaTienTongCong = Convert.ToInt32(reader["GiaTienTongCong"]);
                hopDongDTO.GiaTienDaNop = Convert.ToInt32(reader["GiaTienDaNop"]);
                if (reader["ChuThich"] == null)
                    hopDongDTO.ChuThich = String.Empty;
                else
                    hopDongDTO.ChuThich = Convert.ToString(reader["ChuThich"]);
                return hopDongDTO;
            }
            else
                return null;
        }
        /// <summary>
        /// Thêm hợp đồng mới vào cơ sở dữ liệu theo HopDongDTO
        /// </summary>
        /// <param name="hopDongDTO"></param>
        /// <returns></returns>
        public static bool ThemHopDongDTO(HopDongDTO hopDongDTO)
        {
            string[] param = new string[] { "@MSSV", "@MaNhanVien", "@NgayLap", "@NgayBatDau", "@NgayKetThuc", "@IDPhong", "@GiaTienTongCong", "@GiaTienDaNop", "@ChuThich" };
            object[] value = new object[] { hopDongDTO.MSSV, hopDongDTO.MaNhanVien, hopDongDTO.NgayLap.ToString("yyyy-MM-dd"),
                hopDongDTO.NgayBatDau.ToString("yyyy-MM-dd"), hopDongDTO.NgayKetThuc.ToString("yyyy-MM-dd"),
                hopDongDTO.IDPhong, hopDongDTO.GiaTienTongCong, hopDongDTO.GiaTienDaNop, hopDongDTO.ChuThich };
            SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO [dbo].[HopDong]
                                                   ([MSSV], [MaNhanVien], [NgayLap], [NgayBatDau], [NgayKetThuc], [IDPhong]
                                                   , [GiaTienTongCong], [GiaTienDaNop], [ChuThich]) 
                                                    VALUES
                                                    ( @MSSV , @MaNhanVien , @NgayLap , @NgayBatDau , @NgayKetThuc, 
                                                    @IDPhong , @GiaTienTongCong , @GiaTienDaNop , @ChuThich )");
            sqlCommand.Parameters.Add("@MSSV", SqlDbType.NVarChar).Value = hopDongDTO.MSSV;
            sqlCommand.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar).Value = hopDongDTO.MaNhanVien;
            sqlCommand.Parameters.Add("@NgayLap", SqlDbType.Date).Value = hopDongDTO.NgayLap;
            sqlCommand.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = hopDongDTO.NgayBatDau;
            sqlCommand.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = hopDongDTO.NgayKetThuc;
            sqlCommand.Parameters.Add("@IDPhong", SqlDbType.NVarChar).Value = hopDongDTO.IDPhong;
            sqlCommand.Parameters.Add("@GiaTienTongCong", SqlDbType.Int).Value = hopDongDTO.GiaTienTongCong;
            sqlCommand.Parameters.Add("@GiaTienDaNop", SqlDbType.Int).Value = hopDongDTO.GiaTienDaNop;
            sqlCommand.Parameters.Add("@ChuThich", SqlDbType.NVarChar).Value = hopDongDTO.ChuThich;
            int result = Data.ExecuteNonQueryParam(sqlCommand);
            if (result > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Xóa hợp đồng trong cơ sở dữ liệu theo Mã số hợp đồng
        /// </summary>
        /// <param name="maSo"></param>
        /// <returns></returns>
        public static int XoaHopDong(string maSo)
        {
            return Data.ExecuteNonQuery("DELETE FROM HopDong WHERE MaSo = '" + maSo + "'");
        }
        /// <summary>
        /// Kiểm tra sinh viên có hợp đồng trong thời hạn hay không
        /// </summary>
        /// <param name="MSSV"></param>
        /// <returns></returns>
        public static int KiemTraThoiHan(string MSSV)
        {
            string query = $"SELECT COUNT(*) FROM HopDong WHERE MSSV = '{MSSV}' AND dbo.KiemTraThoiHan(MSSV) = 1";
            SqlDataReader reader =  Data.ExecuteReader(query);
            if (reader.Read())
                return Convert.ToInt32(reader[0]);
            else
                return 0;
        }
    }
}
