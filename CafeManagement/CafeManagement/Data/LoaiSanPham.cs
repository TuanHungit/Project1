using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
    public class LoaiSanPham
    {
        public LoaiSanPham()
        {
            SanPhams = new HashSet<SanPham>();

        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoaiSanPhamId { get; set; }
        public string TenLoaiSanPham { get; set; }
        public ICollection<SanPham> SanPhams { get; set; }
    }
}
