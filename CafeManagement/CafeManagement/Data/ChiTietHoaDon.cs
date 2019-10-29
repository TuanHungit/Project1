using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
    public class ChiTietHoaDon
    {
        [Key]
        [Column(Order = 1)]
        public int HoaDonID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int SanPhamID { get; set; }
        public int SoLuong { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham {get;set;}
    }
}
