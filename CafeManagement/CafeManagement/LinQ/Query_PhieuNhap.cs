using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
namespace CafeManagement.LinQ
{
    public class Query_PhieuNhap
    {
        CaPheContext caPheContext = new CaPheContext();
        Query_ChiTietPhieuNhap chiTietPhieuNhap = new Query_ChiTietPhieuNhap();
        public bool ThemPhieuNhap(int NhaCungCapId, int NhanVienId, DateTime NgayLap)
        {
            if (LayPhieuNhapIdTheoNgayNhap(NgayLap)==0)
            {
                PhieuNhap phieuNhap = new PhieuNhap()
                {

                    NhaCungCapId = NhaCungCapId,
                    NhanVienId = NhanVienId,
                    NgayDatHang = NgayLap
                };
                caPheContext.PhieuNhaps.Add(phieuNhap);
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool XoaPhieuNhap(int PhieuNhapId)
        {
            if (PhieuNhapId != 0)
            {
                var query = (from item in caPheContext.PhieuNhaps
                             where item.PhieuNhapId.Equals(PhieuNhapId)
                             select item).ToList();
                foreach (var item in query)
                {
                    caPheContext.PhieuNhaps.Remove(item);

                }
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public int LayPhieuNhapIdTheoNgayNhap(DateTime NgayLap)
        {
            var query = (from item in caPheContext.PhieuNhaps
                         where DbFunctions.TruncateTime(item.NgayDatHang) == NgayLap.Date
                         select item.PhieuNhapId).SingleOrDefault();
            return query;
        }
        public bool KiemTraHangHoaTheoNgay(int HangHoaID, DateTime NgayLap)
        {
            var query = (from phieunhap in caPheContext.PhieuNhaps
                         join chitietphieunhap in caPheContext.ChiTietPhieuNhaps on phieunhap.PhieuNhapId equals chitietphieunhap.PhieuNhapId
                         where chitietphieunhap.HangHoaID.Equals(HangHoaID) && DbFunctions.TruncateTime(phieunhap.NgayDatHang) == NgayLap.Date
                         select phieunhap).Count();
            if (query > 0)
                return true;
            return false;
        }
    }
}
