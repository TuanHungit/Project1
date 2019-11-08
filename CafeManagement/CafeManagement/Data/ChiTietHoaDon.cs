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
        public int Id { get; set; }
        public int HoaDonID { get; set; }
       
        public int SanPhamID { get; set; }
        public int SoLuong { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham {get;set;}
    }
}
