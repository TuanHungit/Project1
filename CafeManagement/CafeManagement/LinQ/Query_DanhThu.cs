using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
using System.Data.Entity;

namespace CafeManagement.LinQ
{
    public class Query_DanhThu
    {
        public double TinhTongDoanhThu(CaPheContext context, double doanhthu, DateTime date1, DateTime date2)
        {
            doanhthu = 0;
            var hoaDons = (from hoadon in context.HoaDons
                           where DbFunctions.TruncateTime(hoadon.NgayLap) >= date1.Date && DbFunctions.TruncateTime(hoadon.NgayLap) <= date2.Date
                                   && hoadon.TinhTrang.Equals(1)
                           select hoadon).ToList();
            foreach (var hd in hoaDons)
            {
                doanhthu += hd.TongGia;
            }
            return doanhthu;
        }

        public bool KiemTraNgay(CaPheContext context, DateTime date)
        {
            var query = (from hoadon in context.HoaDons
                         where DbFunctions.TruncateTime(hoadon.NgayLap)==date
                         select hoadon).ToList();
            if (query.Count > 0)
                return true;
            return false;
        }

    }
}
