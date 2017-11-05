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
            string str = "INSERT into NhanVien values(N'"
                        + nvDTO.HoTen + "',N'"
                        + nvDTO.MaNhanVien + "','"
                        + nvDTO.NgaySinh + "','N"
                        + nvDTO.GioiTinh + "',N'"
                        + nvDTO.DiaChi + "',N'"
                        + nvDTO.QueQuan + "',N'"
                        + nvDTO.SoDienThoai + "',N'"
                        + nvDTO.Email + "',N'"
                        + nvDTO.ChucVu + "')";

            Data.ExecuteNonQuery(str);
        }

        public void Sua(NhanVienDTO nvDTO)
        {
            string str = "Update NhanVien set HoTen = N'" + nvDTO.HoTen
                                           + "',NgaySinh = '" + nvDTO.NgaySinh
                                           + "',GioiTinh = N'" + nvDTO.GioiTinh
                                           + "',DiaChi = N'" + nvDTO.DiaChi
                                           + "',QueQuan = N'" + nvDTO.QueQuan
                                           + "',SoDienThoai = N'" + nvDTO.SoDienThoai
                                           + "',Email = N'" + nvDTO.Email
                                           + "',ChucVu = N'" + nvDTO.ChucVu
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

            s1 = (nvDTO.HoTen != "") ? ("HoTen like N'%" + nvDTO.HoTen + "%' and ") : ("");
            s2 = (nvDTO.MaNhanVien != "") ? ("MaNhanVien like '%" + nvDTO.MaNhanVien + "%' and ") : ("");
            s3 = (nvDTO.NgaySinh != "") ? ("NgaySinh like '%" + nvDTO.NgaySinh + "%' and ") : ("");
            s4 = (nvDTO.GioiTinh != "") ? ("GioiTinh = N'" + nvDTO.GioiTinh + "' and ") : ("");
            s5 = (nvDTO.DiaChi != "") ? ("DiaChi like N'%" + nvDTO.DiaChi + "%' and ") : ("");
            s6 = (nvDTO.QueQuan != "") ? ("QueQuan like N'%" + nvDTO.QueQuan + "%' and ") : ("");
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
