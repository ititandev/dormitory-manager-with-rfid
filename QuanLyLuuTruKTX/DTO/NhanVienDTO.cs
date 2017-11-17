using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        //public string abc { get; set; }
        public string HoTen { get; set; }
        public string MaNhanVien { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string QueQuan { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string ChucVu { get; set; }

        public HopDongDTO HopDongDTO
        {
            get => default(HopDongDTO);
            set
            {
            }
        }
    }
}
