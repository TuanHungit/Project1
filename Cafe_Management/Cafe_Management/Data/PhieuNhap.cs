using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management.Data
{
    public class PhieuNhap
    {
        public PhieuNhap()
        {
            HangHoas = new HashSet<HangHoa>();
        }
        public int PhieuNhapId { get; set; }
        public DateTime NgayLap { get; set; }
        public int NhanVienId { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public ICollection<HangHoa> HangHoas { get; set; }

    }
}
