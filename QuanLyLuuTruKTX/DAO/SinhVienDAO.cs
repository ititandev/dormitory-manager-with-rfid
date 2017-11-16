using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

using System.Windows.Forms;
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

        public static int ThemSinhVien(SinhVienDTO sv)
        {
            string query = "INSERT INTO SinhVien(MSSV, HoTen,NgaySinh, GioiTinh, CMND, SoDienThoai, " +
                            "Lop, Khoa, QueQuan, DienUuTien, Anh, Email, RFID) VALUES " +
                            $"('{sv.MSSV}',N'{sv.HoTen}','{sv.NgaySinh.ToString("yyyy-MM-dd")}', N'{sv.GioiTinh}', " +
                            $"'{sv.CMND}', '{sv.SoDienThoai}', '{sv.Lop}', '{sv.Khoa}', N'{sv.QueQuan}', " +
                            $"N'{sv.DienUuTien}', '{sv.Anh}', '{sv.Email}', '{sv.RFID}')";
            return Data.ExecuteNonQuery(query);
        }
        public static int CapNhatSinhVien(SinhVienDTO sv)
        {
            MessageBox.Show($"UPDATE SinhVien SET HoTen = N\'{sv.HoTen}\' , GioiTinh=N\'{sv.GioiTinh}\', NgaySinh = \'{sv.NgaySinh.ToString("yyyy-MM-dd")}\' , CMND = \'{sv.CMND}\' , SoDienThoai = \'{sv.SoDienThoai}\' , Lop = \'{sv.Lop}\' , Khoa = \'{sv.Khoa}\' , QueQuan = N\'{sv.QueQuan}\' , DienUuTien = N\'{sv.DienUuTien}\' , Anh = \'{sv.Anh}\' , Email = \'{sv.Email}\', RFID = \'{sv.RFID}\' WHERE MSSV={sv.MSSV}");
            string query = ($"UPDATE SinhVien SET HoTen = N\'{sv.HoTen}\' , GioiTinh=N\'{sv.GioiTinh}\', NgaySinh = \'{sv.NgaySinh.ToString("yyyy-MM-dd")}\' , CMND = \'{sv.CMND}\' , SoDienThoai = \'{sv.SoDienThoai}\' , Lop = \'{sv.Lop}\' , Khoa = N\'{sv.Khoa}\' , QueQuan = N\'{sv.QueQuan}\' , DienUuTien = N\'{sv.DienUuTien}\' , Anh = \'{sv.Anh}\' , Email = \'{sv.Email}\', RFID = \'{sv.RFID}\' WHERE MSSV=\'{sv.MSSV}\'");
            return Data.ExecuteNonQuery(query);
        }
    }
}
