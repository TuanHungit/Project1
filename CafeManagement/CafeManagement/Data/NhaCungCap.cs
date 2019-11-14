using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
    public class NhaCungCap
    {
        public int NhaCungCapId { get; set; }
        public string TenNhaCungCap { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }


        public ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
