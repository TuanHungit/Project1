using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management.Data
{
    public class SanPham
    {
        public SanPham()
        {
            HoaDons = new HashSet<HoaDon>();
        }
        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; }
        public double DonGia { get; set; }
        public int LoaiSanPhamId { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
