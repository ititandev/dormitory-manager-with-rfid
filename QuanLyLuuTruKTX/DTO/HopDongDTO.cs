using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTO
{
    /// <summary>
    /// Class chứa thông tin đối tượng Hợp đồng
    /// </summary>
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
        
    }
}
