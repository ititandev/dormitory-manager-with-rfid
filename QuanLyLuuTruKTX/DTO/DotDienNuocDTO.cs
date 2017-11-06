using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DotDienNuocDTO
    {
        public int MaDot { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int DonGiaDien { get; set; }
        public int DonGiaNuoc { get; set; }
    }
}
