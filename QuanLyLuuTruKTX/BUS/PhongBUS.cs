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
    public class PhongBUS
    {
        PhongDAO phongDAO = new PhongDAO();
        public static DataTable LoadPhong()
        {
            return PhongDAO.LoadPhong();
        }

        public static bool ThemPhongDTO(PhongDTO phongDTO)
        {
            if (PhongDAO.ThemPhong(phongDTO) == 1)
                return true;
            else
                return false;
        }

        public static bool SuaPhongDTO(PhongDTO phongDTO)
        {
            if (PhongDAO.SuaPhongDTO(phongDTO) == 1)
                return true;
            else
                return false;
        }

        public static bool KiemTraPhong(string IDPhong)
        {
            return PhongDAO.KiemTraPhong(IDPhong);
        }

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

        public static void TimKiem()
        {
            throw new NotImplementedException();
        }

        public static DataTable LoadSinhVien()
        {
            return PhongDAO.LoadSinhVien();
        }

        public static string GetIDPhongFromRFID(string RFID)
        {
            SqlDataReader reader = PhongDAO.GetIDPhongFromRFID(RFID);
            if (reader.Read())
                return Convert.ToString(reader["IDPhong"]);
            else
                return String.Empty;
        }
    }
}
