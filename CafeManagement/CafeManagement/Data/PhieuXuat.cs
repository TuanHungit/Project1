using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
    public class PhieuXuat
    {
     
        public int PhieuXuatId { get; set; }
        public DateTime NgayLap { get; set; }
        public int NhanVienId { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public ICollection<ChiTietPhieuXuat> chiTietPhieuXuats { get; set; }
    }
}
