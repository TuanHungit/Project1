using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
    public class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            PhieuNhaps = new HashSet<PhieuNhap>();
        }
     
        public int NhanVienId { get; set; }
        public string HoTenNV { get; set; }
        public string ChucVu { get; set; }
        public string SDT_NV { get; set; }
        public int CMND { get; set; }
      
        public DateTime NgaySinh { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }


        public ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
