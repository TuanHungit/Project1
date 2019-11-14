using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
    public class HangHoa
    {
        public int HangHoaId { get; set; }
        public string TenHangHoa { get; set; }
        public string DonViTinh { get; set; }
        public double DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
    }
}
