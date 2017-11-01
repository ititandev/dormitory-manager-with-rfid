using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HopDongDTO
    {
        public int Maso { get; set; }
        public string MSSV { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string TinhTrang { get; set; }
        public string ChuThich { get; set; }
        public string RFID { get; set; }
        public string IDPhong { get; set; }
        public int GiaTienTongCong { get; set; }
        public int GiaTienDaNop { get; set; }
    }
}
