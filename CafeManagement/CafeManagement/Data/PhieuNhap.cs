using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
   public class PhieuNhap
    {
        public int PhieuNhapId { get; set; }
        public int NhaCungCapId { get; set; }
        public int NhanVienId { get; set; }
        public DateTime NgayDatHang { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps{ get; set; }
    }
}
