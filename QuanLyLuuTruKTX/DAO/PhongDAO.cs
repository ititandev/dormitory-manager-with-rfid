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
        public static DataTable ViewAll()
        {
            return Data.ExecuteQuery("SELECT * FROM Phong");
        }

        public int Them(PhongDTO phongDTO)
        {
            string str = "INSERT into Phong values('"
                        + phongDTO.SoPhong + "','"
                        + phongDTO.KhuNha + "','"
                        + phongDTO.MaNhanVien + "','"
                        + phongDTO.SoLuongChoPhep + "','"
                        + phongDTO.TinhTrang + "','"
                        + phongDTO.IDPhong + "','"
                        + phongDTO.SoLuongHienTai + "')";

            return Data.ExecuteNonQuery(str);
        }

        public void Sua(PhongDTO phongDTO)
        {
            string str = "Update Phong set SoPhong = '" + phongDTO.SoPhong
                                           + "',KhuNha = '" + phongDTO.KhuNha
                                           + "',MaNhanVien = '" + phongDTO.MaNhanVien
                                           + "',SoLuongChoPhep = '" + phongDTO.SoLuongChoPhep
                                           + "',TinhTrang = '" + phongDTO.TinhTrang
                                           + "',SoLuongHienTai = '" + phongDTO.SoLuongHienTai
                                + "' where IDPhong = '" + phongDTO.IDPhong + "'";
            Data.ExecuteNonQuery(str);
        }

        public DataTable TimKiem(string searchText)
        {
            string SoPhong = " SoPhong LIKE '%" + searchText + "%' ";
            string KhuNha = " KhuNha LIKE '%" + searchText + "%' ";
            string MaNhanVien = " MaNhanVien LIKE '%" + searchText + "%' ";
            string SoLuongChoPhep = " SoLuongChoPhep LIKE '%" + searchText + "%' ";
            string TinhTrang = " TinhTrang LIKE '%" + searchText + "%' ";
            string SoLuongHienTai = " SoLuongHienTai LIKE '%" + searchText + "%' ";
            string IDPhong = " IDPhong LIKE '%" + searchText + "%' ";

            string str = "SELECT * from Phong where " +
                SoPhong + "OR" + KhuNha + "OR" +
                MaNhanVien + "OR" + SoLuongChoPhep + "OR" +
                TinhTrang + "OR" + SoLuongHienTai + "OR" + IDPhong;

            return Data.ExecuteQuery(str);
        }

        public static SqlDataReader GetPhongDTO(string IDPhong)
        {
            SqlDataReader reader = Data.ExecuteReader($"SELECT * FROM Phong WHERE IDPhong = '{IDPhong}'");
            if (reader.Read())
                return reader;
            else
                return null;
        }

        public DataTable TimKiem(PhongDTO obj)
        {
            string SoPhong = obj.SoPhong != "" ? " SoPhong LIKE '%" + obj.SoPhong + "%' AND" : "";
            string KhuNha = obj.KhuNha != "" ? " KhuNha LIKE '%" + obj.KhuNha + "%' AND" : "";
            string MaNhanVien = obj.MaNhanVien != "" ? " MaNhanVien LIKE '%" + obj.MaNhanVien + "%' AND" : "";
            string SoLuongChoPhep = obj.SoLuongChoPhep != -1 ? " SoLuongChoPhep LIKE '%" + obj.SoLuongChoPhep + "%' AND" : "";
            string TinhTrang = obj.TinhTrang != "" ? " TinhTrang LIKE '%" + obj.TinhTrang + "%' AND" : "";
            string SoLuongHienTai = obj.SoLuongHienTai != -1 ? " SoLuongHienTai LIKE '%" + obj.SoLuongHienTai + "%' " : "";

            string str = "SELECT * from Phong where " +
                SoPhong + KhuNha + MaNhanVien + SoLuongChoPhep + TinhTrang + SoLuongHienTai;

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
