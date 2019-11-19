using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
namespace CafeManagement.LinQ
{
    class Query_HangHoa
    {
        CaPheContext caPheContext = new CaPheContext();
        HangHoa hangHoa = new HangHoa();
        Query_PhieuNhap phieuNhap = new Query_PhieuNhap();
        Query_PhieuXuat phieuXuat = new Query_PhieuXuat();
        public bool KiemTraHangHoa(string TenHangHoa)
        {
            var query = (from item in caPheContext.HangHoas
                         where item.TenHangHoa.Contains(TenHangHoa)
                         select item).Count();
            if (query > 0)
                return false;
            return true;
        }
        public bool ThemHangHoa(string TenHangHoa, string DonViTinh, float DonGia, int SoluongTon)
        {
            if (KiemTraHangHoa(TenHangHoa))
            {
                HangHoa hangHoa = new HangHoa()
                {
                    TenHangHoa = TenHangHoa,
                    DonViTinh = DonViTinh,
                    DonGia = DonGia,
                    SoLuongTon = SoluongTon,
                    TinhTrang ="Đang hoạt động"
                };
                caPheContext.HangHoas.Add(hangHoa);
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public int LayHangHoaIDTheoTenHangHoa(string TenHangHoa)
        {
            var query = (from item in caPheContext.HangHoas
                         where item.TenHangHoa.Contains(TenHangHoa)
                         select item.HangHoaId).SingleOrDefault();
            return query;
        }
        public bool XoaHangHoa(int HangHoaId)
        {
            if (HangHoaId != 0)
            {
                var query = (from item in caPheContext.HangHoas
                             where item.HangHoaId.Equals(HangHoaId)
                             select item).ToList();
                foreach (var item in query)
                {
                    item.TinhTrang = "Ngưng hoạt động";
                }
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool CapNhatHangHoa(int HangHoaId, int SoLuong,DateTime NgayLap)
        {
            if (phieuNhap.KiemTraHangHoaTheoNgay(HangHoaId, NgayLap))
            {
                HangHoa hangHoa = (from item in caPheContext.HangHoas
                                   where item.HangHoaId.Equals(HangHoaId)
                                   select item).FirstOrDefault();

                hangHoa.SoLuongTon = hangHoa.SoLuongTon + SoLuong;
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool CapNhatSoLuongHangHoaKhiXuat(int HangHoaId, int SoLuong, DateTime NgayLap)
        {
            if (phieuXuat.KiemTraHangHoaTheoNgay(HangHoaId, NgayLap,caPheContext))
            {
                HangHoa hangHoa= (from item in caPheContext.HangHoas
                               where item.HangHoaId.Equals(HangHoaId)
                               select item).FirstOrDefault();
                hangHoa.SoLuongTon = hangHoa.SoLuongTon - SoLuong;
                caPheContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
