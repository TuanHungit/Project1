using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management.Data
{
    public class Ban
    {
        public Ban()
        {
            HoaDons = new HashSet<HoaDon>();
        }
        public int BanId { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
