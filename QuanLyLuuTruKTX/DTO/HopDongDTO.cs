using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTO
{
    public class HopDongDTO
    {
        public int MaSo { get; set; }
        public string MSSV { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string ChuThich { get; set; }
        public string IDPhong { get; set; }
        public int GiaTienTongCong { get; set; }
        public int GiaTienDaNop { get; set; }
        
        public static string[] TinhTrangHopDongString = new string[] { "Chưa tới thời hạn", "Trong thời hạn", "Hết thời hạn" };
    }

    public enum TinhTrangHopDong : byte
    {
        CHUA_TOI_THOI_HAN = 0,
        TRONG_THOI_HAN = 1,
        HET_THOI_HAN = 2
    }
}
