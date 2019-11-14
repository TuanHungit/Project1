using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
  public class ChiTietPhieuXuat
    {
        public int ChiTietPhieuXuatId { get; set; }
        public int PhieuXuatId { get; set; }
        public int HangHoaId { get; set; }
        public int SoLuongXuat { get; set; }
        public virtual PhieuXuat PhieuXuat { get; set; }
        public virtual HangHoa HangHoa { get; set; }
    }
}
