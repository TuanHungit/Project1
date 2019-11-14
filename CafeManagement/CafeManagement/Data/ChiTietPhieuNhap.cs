using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
   public class ChiTietPhieuNhap
    {
        public int ChiTietPhieuNhapId { get; set; }
        public int PhieuNhapId { get; set; }
        public int HangHoaID { get; set; }
        public int SoLuongDat { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }
        public virtual HangHoa HangHoa { get; set; }
    }
}
