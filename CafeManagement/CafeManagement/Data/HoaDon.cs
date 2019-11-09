using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
    public class HoaDon
    {
        public int HoaDonId { get; set; }
        public DateTime NgayLap { get; set; }
        public int NhanVienId { get; set; }
        public int BanID { get; set; }
        public double TongGia { get; set; }
        public int TinhTrang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual Ban Ban { get; set; }
        public ICollection<ChiTietHoaDon> chiTietHoaDons { get; set; }
    }
}
