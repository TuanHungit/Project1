using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management.Data
{
    public class HoaDon
    {
        public HoaDon()
        {
            SanPhams = new HashSet<SanPham>();
        }
        public int HoaDonId { get; set; }
        public DateTime NgayLap { get; set; }
        public int NhanVienId { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public ICollection<SanPham> SanPhams { get; set; }


    }
}
