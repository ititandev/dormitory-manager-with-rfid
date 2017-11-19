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

        public DataTable TimKiem(string searchText)
        {
            string SoPhong = " SoPhong LIKE '%" + searchText + "%' ";
            string KhuNha = " KhuNha LIKE '%" + searchText + "%' ";
            string SoLuongChoPhep = " SoLuongChoPhep LIKE '%" + searchText + "%' ";
            string TinhTrang = " TinhTrang LIKE '%" + searchText + "%' ";
            string SoLuongHienTai = " SoLuongHienTai LIKE '%" + searchText + "%' ";
            string IDPhong = " IDPhong LIKE '%" + searchText + "%' ";

            string str = "SELECT * from Phong where " +
                SoPhong + "OR" + KhuNha + "OR" + SoLuongChoPhep + "OR" +
                TinhTrang + "OR" + SoLuongHienTai + "OR" + IDPhong;

            return Data.ExecuteQuery(str);
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

        public DataTable TimKiem(PhongDTO obj)
        {
            string SoPhong = obj.SoPhong != "" ? " SoPhong LIKE '%" + obj.SoPhong + "%' AND" : "";
            string KhuNha = obj.KhuNha != "" ? " KhuNha LIKE '%" + obj.KhuNha + "%' AND" : "";
            string SoLuongChoPhep = obj.SoLuongToiDa != -1 ? " SoLuongChoPhep LIKE '%" + obj.SoLuongToiDa + "%' AND" : "";
            string TinhTrang = obj.TinhTrang != "" ? " TinhTrang LIKE '%" + obj.TinhTrang + "%' AND" : "";
            string SoLuongHienTai = obj.SoLuongHienTai != -1 ? " SoLuongHienTai LIKE '%" + obj.SoLuongHienTai + "%' " : "";

            string str = "SELECT * from Phong where " +
                SoPhong + KhuNha + SoLuongChoPhep + TinhTrang + SoLuongHienTai;

            return Data.ExecuteQuery(str);
        }

        public static int KiemTraPhong(string IDPhong)
        {
            SqlDataReader reader = Data.ExecuteReader("SELECT COUNT(*) FROM Phong WHERE SoLuongHienTai < SoLuongChoPhep AND IDPhong = '" + IDPhong + "'");
            if (reader.Read())
                return Convert.ToInt32(reader[0]);
            else
                return 0;
        }
    }
}
