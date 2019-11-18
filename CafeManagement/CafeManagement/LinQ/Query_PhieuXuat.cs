using CafeManagement.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.LinQ
{
    public class Query_PhieuXuat
    {
        CaPheContext caPheContext = new CaPheContext();
        Query_ChiTietPhieuXuat chiTietPhieuXuat = new Query_ChiTietPhieuXuat();
        public bool ThemPhieuXuat( int NhanVienId, DateTime NgayLap)
        {
            if (LayPhieuXuatIdTheoNgayNhap(NgayLap) == 0)
            {
                PhieuXuat phieuXuat = new PhieuXuat()
                {
                    NhanVienId = NhanVienId,
                    NgayLap=NgayLap
                };
                caPheContext.PhieuXuats.Add(phieuXuat);
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool XoaPhieuXuat(int PhieuXuatId)
        {
            if (PhieuXuatId != 0)
            {
                var query = (from item in caPheContext.PhieuXuats
                             where item.PhieuXuatId.Equals(PhieuXuatId)
                             select item).ToList();
                foreach (var item in query)
                {
                    caPheContext.PhieuXuats.Remove(item);

                }
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public int LayPhieuXuatIdTheoNgayNhap(DateTime ngaylap)
        {
            var query = (from item in caPheContext.PhieuXuats
                         where DbFunctions.TruncateTime(item.NgayLap) == ngaylap.Date
                         select item.PhieuXuatId).SingleOrDefault();
            return query;
        }
        public bool KiemTraHangHoaTheoNgay(int HangHoaID, DateTime NgayLap)
        {
            var query = (from phieuxuat in caPheContext.PhieuXuats
                         join chitietphieuxuat in caPheContext.ChiTietPhieuXuats on phieuxuat.PhieuXuatId equals chitietphieuxuat.PhieuXuatId
                         where chitietphieuxuat.HangHoaId.Equals(HangHoaID) && DbFunctions.TruncateTime(phieuxuat.NgayLap) == NgayLap.Date
                         select phieuxuat).Count();
            if (query > 0)
                return true;
            return false;
        }
    }
}
