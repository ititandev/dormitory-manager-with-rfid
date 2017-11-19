using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DAO;
namespace BUS
{
    public class HoaDonDienNuocBUS
    {
        public const int giaDien = 2000;
        public const int giaNuoc = 3000;
        public static string IDPhong = "ID";
        public static string ChiSoDienDau = "Chỉ số điện đầu";
        public static string ChiSoDienCuoi = "Chỉ số điện cuối";
        public static string ChiSoNuocDau = "Chỉ số nước đầu";
        public static string ChiSoNuocCuoi = "Chỉ số nước cuối";
        public static string DaThanhToan = "Đã thanh toán";
        public static string MaDot = "Mã đợt";
        public static string NgayBatDau = "Ngày bắt đầu";
        public static string NgayKetThuc = "Ngày kết thúc";
        public static string ChuThich = "Chú thích";
        public static string TongTien = "Tổng tiền";
        public static DataTable viewAllHoaDon()
        {
            DataTable dt = new DataTable();
            string query = "SELECT HoaDonDienNuoc.IDPhong,HoaDonDienNuoc.ChiSoDienDau,HoaDonDienNuoc.ChiSoDienCuoi,HoaDonDienNuoc.ChiSoNuocDau,HoaDonDienNuoc.ChiSoNuocCuoi,HoaDonDienNuoc.DaThanhToan,HoaDonDienNuoc.MaDot, DotDienNuoc.NgayBatDau,DotDienNuoc.NgayKetThuc, HoaDonDienNuoc.ChuThich FROM HoaDonDienNuoc INNER JOIN DotDienNuoc ON HoaDonDienNuoc.MaDot=DotDienNuoc.MaDot";
            dt = Data.ExecuteQuery(query);
            dt.Columns[0].ColumnName = IDPhong;
            dt.Columns[1].ColumnName = ChiSoDienDau;
            dt.Columns[2].ColumnName = ChiSoDienCuoi;
            dt.Columns[3].ColumnName = ChiSoNuocDau;
            dt.Columns[4].ColumnName = ChiSoNuocCuoi;
            dt.Columns[5].ColumnName = DaThanhToan;
            dt.Columns[6].ColumnName = MaDot;
            dt.Columns[7].ColumnName = NgayBatDau;
            dt.Columns[8].ColumnName = NgayKetThuc;
            dt.Columns[9].ColumnName = ChuThich;
            return dt;
        }
        public static DataTable tinhTongTien(DataTable dt)
        {
            dt.Columns.Add("Tổng tiền");
            int sum = 0;
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                if (!bool.Parse(dt.Rows[i][DaThanhToan].ToString()))
                {
                    DateTime start = DateTime.Parse(dt.Rows[i][NgayBatDau].ToString());
                    DateTime end = DateTime.Parse(dt.Rows[i][NgayKetThuc].ToString());
                    int number = (int)(end - start).TotalDays;
                    int sodien = int.Parse(dt.Rows[i][ChiSoDienCuoi].ToString()) - int.Parse(dt.Rows[i][ChiSoDienDau].ToString());
                    int sonuoc = int.Parse(dt.Rows[i][ChiSoNuocCuoi].ToString()) - int.Parse(dt.Rows[i][ChiSoNuocDau].ToString());
                    sum = (giaDien * sodien + giaNuoc * sonuoc);
                    dt.Rows[i][TongTien] = sum;
                }
            }
            return dt;
        }
        public static SqlDataReader getHoaDonDS()
        {
            string query = "SELECT MaSo, DotDienNuoc.MaDot, Phong.IDPhong, KhuNha, ChiSoDienDau, ChiSoDienCuoi, ChiSoNuocDau, ChiSoNuocCuoi, DonGiaDien, DonGiaNuoc, NgayBatDau, NgayKetThuc FROM DotDienNuoc, HoaDonDienNuoc, Phong WHERE DotDienNuoc.MaDot=HoaDonDienNuoc.MaDot AND HoaDonDienNuoc.IDPhong=Phong.IDPhong";
            SqlDataReader dr = Data.ExecuteReader(query);
            return dr;
        }
        
    }
}
