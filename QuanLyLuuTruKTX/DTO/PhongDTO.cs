using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Class chứa thông tin về đối tượng Phòng
    /// </summary>
    public class PhongDTO
    {
        public string SoPhong { get; set; }
        public string KhuNha { get; set; }
        public int SoLuongToiDa { get; set; }
        public string TinhTrang { get; set; }
        public string IDPhong { get; set; }
        public int SoLuongHienTai { get; set; }
    }
}
