using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
using CafeManagement.LinQ;
namespace CafeManagement.LinQ
{
   public class Query_ChiTietPhieuNhap
    {
        CaPheContext caPheContext = new CaPheContext();
       
        public bool ThemChiTietPhieuNhap(int PhieuNhapId, int HangHoaId, int SoLuongNhap)
        {
            if (PhieuNhapId != 0&&SoLuongNhap!=0 &&HangHoaId!=0)
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap()
                {
                    PhieuNhapId = PhieuNhapId,
                    HangHoaID = HangHoaId,
                    SoLuongDat = SoLuongNhap
                };
                caPheContext.ChiTietPhieuNhaps.Add(chiTietPhieuNhap);
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        //public bool KiemTraSanPhamPhieuNhap(int PhieuNhapID)
        //{
        //    var query = (from phieunhap in caPheContext.PhieuNhaps
        //                 join chitietphieunhap in caPheContext.ChiTietPhieuNhaps on phieunhap.PhieuNhapId equals chitietphieunhap.PhieuNhapId
        //                 select phieunhap).Count();
        //    if (query > 0)
        //        return false;
        //    return true;
        // }
        //public bool XoaChiTietPhieuNhap(int ChiTietPhieuNhapId,int PhieuNhapId)
        //{
        //    if (!KiemTraSanPhamPhieuNhap(PhieuNhapId))
        //    {
        //        var query = (from item in caPheContext.ChiTietPhieuNhaps
        //                     where item.ChiTietPhieuNhapId.Equals(ChiTietPhieuNhapId)
        //                     select item).ToList();
        //        foreach (var item in query)
        //        {
        //            caPheContext.ChiTietPhieuNhaps.Remove(item);
        //        }
        //        caPheContext.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}
        public void CapNhatChiTietPhieuNhap(int HangHoaId, int SoLuong, DateTime NgayLap)
        {
          
                ChiTietPhieuNhap hangHoa = (from item in caPheContext.ChiTietPhieuNhaps
                                            join item1 in caPheContext.PhieuNhaps on item.PhieuNhapId equals item1.PhieuNhapId
                                            where item.HangHoaID.Equals(HangHoaId) && DbFunctions.TruncateTime(item1.NgayDatHang) == NgayLap.Date
                                            select item).FirstOrDefault();

                hangHoa.SoLuongDat = hangHoa.SoLuongDat + SoLuong;
                caPheContext.SaveChanges();
              
        }

    }
}
