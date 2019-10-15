using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management.Data
{
   public class HangHoa
    {
        public HangHoa()
        {
            NhaCungCaps = new HashSet<NhaCungCap>();
            PhieuNhaps = new HashSet<PhieuNhap>();
        }
        public int HangHoaId { get; set; }
        public string TenHangHoa { get; set; }
        public double DonGia { get; set; }
        public ICollection<NhaCungCap> NhaCungCaps { get; set; }

        public ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
