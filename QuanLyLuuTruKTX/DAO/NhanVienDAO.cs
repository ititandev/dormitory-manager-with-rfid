using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        public static DataTable LayDSNhanVien()
        {
            return Data.ExecuteQuery("SELECT * FROM NhanVien");
        }

        public void Them(NhanVienDTO nvDTO)
        {
            string str = "INSERT into NhanVien values('"
                        + nvDTO.HoTen + "','"
                        + nvDTO.MaNhanVien + "','"
                        + nvDTO.NgaySinh + "','"
                        + nvDTO.GioiTinh + "','"
                        + nvDTO.DiaChi + "','"
                        + nvDTO.QueQuan + "','"
                        + nvDTO.SoDienThoai + "','"
                        + nvDTO.Email + "','"
                        + nvDTO.ChucVu + "')";

            Data.ExecuteNonQuery(str);
        }

        public void Sua(NhanVienDTO nvDTO)
        {
            string str = "Update NhanVien set HoTen = '" + nvDTO.HoTen
                                           + "',NgaySinh = '" + nvDTO.NgaySinh
                                           + "',GioiTinh = '" + nvDTO.GioiTinh
                                           + "',DiaChi = '" + nvDTO.DiaChi
                                           + "',QueQuan = '" + nvDTO.QueQuan
                                           + "',SoDienThoai = '" + nvDTO.SoDienThoai
                                           + "',Email = '" + nvDTO.Email
                                           + "',ChucVu = '" + nvDTO.ChucVu
                         + "' where MaNhanVien = '" + nvDTO.MaNhanVien + "'";
            Data.ExecuteNonQuery(str);
        }

        public void Xoa(NhanVienDTO nvDTO)
        {
            string str = "Delete NhanVien where MaNhanVien = '" + nvDTO.MaNhanVien + "'";
            Data.ExecuteNonQuery(str);
        }

        public DataTable TimKiem(NhanVienDTO nvDTO)
        {
            string s1, s2, s3, s4, s5, s6, s7, s8, s9;

            s1 = (nvDTO.HoTen != "") ? ("HoTen like '%" + nvDTO.HoTen + "%' and ") : ("");
            s2 = (nvDTO.MaNhanVien != "") ? ("MaNhanVien like '%" + nvDTO.MaNhanVien + "%' and ") : ("");
            s3 = (nvDTO.NgaySinh != "") ? ("NgaySinh like '%" + nvDTO.NgaySinh + "%' and ") : ("");
            s4 = (nvDTO.GioiTinh != "") ? ("GioiTinh like '%" + nvDTO.GioiTinh + "%' and ") : ("");
            s5 = (nvDTO.DiaChi != "") ? ("DiaChi like '%" + nvDTO.DiaChi + "%' and ") : ("");
            s6 = (nvDTO.QueQuan != "") ? ("QueQuan like '%" + nvDTO.QueQuan + "%' and ") : ("");
            s7 = (nvDTO.SoDienThoai != "") ? ("SoDienThoai like '%" + nvDTO.SoDienThoai + "%' and ") : ("");
            s8 = (nvDTO.Email != "") ? ("Email like '%" + nvDTO.Email + "%' and ") : ("");
            s9 = (nvDTO.ChucVu != "") ? ("ChucVu like '%" + nvDTO.ChucVu + "%'") : ("");

            string str = "select * from NhanVien where " + s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9;
            if (s9 == "")
            {
                str = str.Substring(0, str.Length - 5);
            }

            return Data.ExecuteQuery(str);
        }
    }
}
