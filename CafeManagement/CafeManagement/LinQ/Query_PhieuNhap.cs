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
                Global.context.PhieuNhaps.Add(phieuNhap);
                Global.context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool XoaPhieuNhap(int PhieuNhapId)
        {
            if (PhieuNhapId != 0)
            {
                var query = (from item in Global.context.PhieuNhaps
                             where item.PhieuNhapId.Equals(PhieuNhapId)
                             select item).ToList();
                foreach (var item in query)
                {
                    Global.context.PhieuNhaps.Remove(item);

                }
                Global.context.SaveChanges();
                return true;
            }
            return false;
        }
        public int LayPhieuNhapIdTheoNgayNhap(DateTime NgayLap)
        {
            var query = (from item in Global.context.PhieuNhaps
                         where DbFunctions.TruncateTime(item.NgayDatHang) == NgayLap.Date
                         select item.PhieuNhapId).SingleOrDefault();
            return query;
        }
        public bool KiemTraHangHoaTheoNgay(int HangHoaID, DateTime NgayLap)
        {
            var query = (from phieunhap in Global.context.PhieuNhaps
                         join chitietphieunhap in Global.context.ChiTietPhieuNhaps on phieunhap.PhieuNhapId equals chitietphieunhap.PhieuNhapId
                         where chitietphieunhap.HangHoaID.Equals(HangHoaID) && DbFunctions.TruncateTime(phieunhap.NgayDatHang) == NgayLap.Date
                         select phieunhap).Count();
            if (query > 0)
                return true;
            return false;
        }
    }
}
