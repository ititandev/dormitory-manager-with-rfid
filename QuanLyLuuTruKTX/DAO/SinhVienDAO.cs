using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public static class SinhVienDAO
    {
        public static int KiemTraSV(string MSSV)
        {
            SqlDataReader reader = Data.ExecuteReader("SELECT COUNT(*) FROM SinhVien WHERE MSSV = '" + MSSV + "'");
            reader.Read();
            return Convert.ToInt32(reader[0]);
        }

        public static SinhVienDTO GetSinhVienDTO(string MSSV)
        {
            try
            {
                SqlDataReader reader = Data.ExecuteReader("SELECT * FROM SinhVien WHERE MSSV = '" + MSSV + "'");
                if (reader.Read())
                {
                    SinhVienDTO sinhVienDTO = new SinhVienDTO();
                    sinhVienDTO.HoTen = Convert.ToString(reader["HoTen"]);
                    sinhVienDTO.MSSV = MSSV;
                    sinhVienDTO.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                    sinhVienDTO.GioiTinh = Convert.ToString(reader["GioiTinh"]);
                    sinhVienDTO.CMND = Convert.ToString(reader["CMND"]);
                    sinhVienDTO.Lop = Convert.ToString(reader["Lop"]);
                    sinhVienDTO.SoDienThoai = Convert.ToString(reader["SoDienThoai"]);
                    sinhVienDTO.Khoa = Convert.ToString(reader["Khoa"]);
                    sinhVienDTO.QueQuan = Convert.ToString(reader["QueQuan"]);
                    sinhVienDTO.DienUuTien = Convert.ToString(reader["DienUuTien"]);
                    sinhVienDTO.Anh = Convert.ToString(reader["Anh"]);
                    sinhVienDTO.Email = Convert.ToString(reader["Email"]);
                    sinhVienDTO.RFID = Convert.ToString(reader["RFID"]);
                    return sinhVienDTO;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
            
        }
    }
}
