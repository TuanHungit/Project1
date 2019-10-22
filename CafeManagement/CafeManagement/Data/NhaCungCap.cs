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
        public NhaCungCap()
        {
            HangHoas = new HashSet<HangHoa>();
        }
       
        public int NhaCungCapId { get; set; }
        public string TenNhaCungCap { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public ICollection<HangHoa> HangHoas { get; set; }
    }
}
