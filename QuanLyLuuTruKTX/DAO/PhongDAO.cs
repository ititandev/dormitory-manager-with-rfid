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
    public class PhongDAO
    {
        public static DataTable LoadPhong()
        {
            return Data.ExecuteQuery(@"SELECT IDPhong, KhuNha, SoPhong, 
                                        (SELECT COUNT(*) FROM HopDong
                                        WHERE Phong.IDPhong = HopDong.IDPhong COLLATE DATABASE_DEFAULT
                                        AND dbo.KiemTraThoiHan(HopDong.MSSV) = 1)
                                        AS SoLuongHienTai, SoLuongToiDa, TinhTrang FROM Phong");
        }

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

        public static int SuaPhongDTO(PhongDTO phongDTO)
        {
            string str = "UPDATE Phong SET SoPhong = '" + phongDTO.SoPhong +
                        "',KhuNha = '" + phongDTO.KhuNha +
                        "',SoLuongToiDa = '" + phongDTO.SoLuongToiDa +
                        "',TinhTrang = N'" + phongDTO.TinhTrang +
                        "' WHERE IDPhong = '" + phongDTO.IDPhong + "'";
            return Data.ExecuteNonQuery(str);
        }
        public static SqlDataReader GetIDPhongFromRFID(string RFID)
        {
            return Data.ExecuteReader(@"SELECT HopDong.IDPhong, RFID FROM HopDong 
                                        LEFT JOIN SinhVien ON HopDong.MSSV = SinhVien.MSSV 
                                        WHERE dbo.KiemTraThoiHan(HopDong.MSSV) = 1 AND RFID ='" + RFID +"'");
        }

        public static DataTable LoadSinhVien()
        {
            return Data.ExecuteQuery(@"SELECT HopDong.IDPhong, HopDong.MSSV, HoTen, RFID FROM HopDong 
                                        LEFT JOIN  SinhVien ON HopDong.MSSV = SinhVien.MSSV 
                                        WHERE dbo.KiemTraThoiHan(HopDong.MSSV) = 1 ");
        }

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

        public static bool XoaPhong(string IDPhong)
        {
            string query = "DELETE FROM Phong WHERE IDPhong = '" + IDPhong + "'";
            if (Data.ExecuteNonQuery(query) == 1)
                return true;
            else
                return false;
        }

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
