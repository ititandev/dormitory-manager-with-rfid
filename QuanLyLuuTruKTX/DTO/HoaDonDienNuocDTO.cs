using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HoaDonDienNuocDTO
    {
        public int MaSo { get; set; }
        public string IDPhong { get; set; }
        public int ChiSoDienDau { get; set; }
        public int ChiSoDienCuoi { get; set; }
        public int ChiSoNuocDau { get; set; }
        public int ChiSoNuocCuoi { get; set; }
        public bool DaThanhToan { get; set; }
        public int MaDot { get; set; }
        public int GiaTien { get; set; }
        public string chuThich { get; set; }
    }
}
