using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;
namespace BUS
{
    public static class DotDienNuocBUS
    {
        public static string MaDot = "Mã Đợt";
        public static string NgayBatDau = "Ngày bắt đầu";
        public static string NgayKetThuc = "Ngày kết thúc";
        public static string DonGiaDien = "Đơn giá điện";
        public static string DonGiaNuoc = "Đơn giá nước";
        public static DataTable viewDotDienNuoc()
        {
            string query = "SELECT * FROM DotDienNuoc";
            DataTable dt = Data.ExecuteQuery(query);
            dt.Columns[0].ColumnName = MaDot;
            dt.Columns[1].ColumnName = NgayBatDau;
            dt.Columns[2].ColumnName = NgayKetThuc;
            dt.Columns[3].ColumnName = DonGiaDien;
            dt.Columns[4].ColumnName = DonGiaNuoc;
            return dt;
        }
        public static void ThemDotDienNuoc(DotDienNuocDTO dn)
        {
            string query = "INSERT INTO DotDienNuoc( NgayBatDau, NgayKetThuc, DonGiaDien,DonGiaNuoc) VALUES('{dn.NgayBatDau.ToString()}','{dn.NgayKetThuc.ToString()}','{dn.DonGiaDien}','{dn.DonGiaNuoc}')";
            Data.ExecuteNonQuery(query);
        }
        public static void XoaDotDienNuoc(int MaDot)
        {
            string query = "DELETE FROM DotDienNuoc WHERE MaDot={MaDot}";
            Data.ExecuteNonQuery(query);
        }
        public static void CapNhatDotDienNuoc(DotDienNuocDTO dn)
        {
            string query = "UPDATE DotDienNuoc SET MaDot='{dn.MaDot}', NgayBatDau='{dn.NgayBatDau.ToString()}',NgayKetThuc='{dn.NgayKetThuc.ToString()}'";
            Data.ExecuteNonQuery(query);
        }
    }
}
