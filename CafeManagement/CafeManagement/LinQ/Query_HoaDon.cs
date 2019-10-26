using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
namespace CafeManagement.LinQ
{
   public class Query_HoaDon
    {
        CaPheContext caPheContext = new CaPheContext();
        public int LayHoaDonChuaThanhToan(int BanID)
        {
            var query = (from item in caPheContext.HoaDons
                         where item.BanID.Equals(BanID) && item.TinhTrang == 0
                         select item.BanID).SingleOrDefault();
            return query;
        }
    }
}
