using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Class chứa thông tin đối tượng Sinh viên
    /// </summary>
    public class SinhVienDTO
    {
        public string HoTen { get; set; }
        public string MSSV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string Lop { get; set; }
        public string SoDienThoai { get; set; }
        public string Khoa { get; set; }
        public string QueQuan { get; set; }
        public string DienUuTien { get; set; }
        public string Anh { get; set; }
        public string Email { get; set; }
        public string RFID { get; set; }
    }
}

