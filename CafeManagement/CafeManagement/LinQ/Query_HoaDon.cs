using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return (from item in caPheContext.HoaDons
                    where item.BanID.Equals(BanID) && item.TinhTrang.Equals(0)
                    select item.HoaDonId).SingleOrDefault();

        } 
        public List<ChiTietHoaDon> LayDanhSachChiTietHoaDon(int HoaDonID)
        {
            var query = (from item in caPheContext.ChiTietHoaDons
                         where item.HoaDonID.Equals(HoaDonID)
                         select item).ToList();
            return query;
        }
        public bool AddHoaDon(int BanID)
        {
            if (BanID != null)
            {
                HoaDon hoaDon = new HoaDon()
                {
                    NhanVienId = Global.NhanVienID,
                    NgayLap = DateTime.Now,
                    BanID = BanID,
                    TinhTrang = 0
                };
                caPheContext.HoaDons.Add(hoaDon);
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public void AddChiTietHoaDon(int HoaDonID, int SanphamID, int SoLuong)
        {
            int TempSoLuong = 0;
            if (!KiemTraBillTonTai(HoaDonID, SanphamID, SoLuong) &&SoLuong>0)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon()
                {
                    HoaDonID = HoaDonID,
                    SanPhamID = SanphamID,
                    SoLuong = SoLuong
                };

                caPheContext.ChiTietHoaDons.Add(chiTietHoaDon);
                caPheContext.SaveChanges();
            }
            else
            {
                var query = (from item in caPheContext.ChiTietHoaDons
                             where item.HoaDonID.Equals(HoaDonID) && item.SanPhamID.Equals(SanphamID)
                             select item).ToList();
                foreach (var item in query)
                {
                    item.SoLuong = item.SoLuong + SoLuong;
                }
                caPheContext.SaveChanges();

                XoaChiTietHoaDon(HoaDonID, SanphamID, 0);
            }
            


        }
        public int GetMaxBill()
        {
            try
            {
                List<int> listID = (from item in caPheContext.HoaDons
                                    select item.HoaDonId).ToList();
                return listID.Max();
            }
            catch
            {
                return 1;
            }

        }
        public bool KiemTraBillTonTai(int HoadonID, int SanphamID, int Soluong)
        {
            var query = (from item in caPheContext.ChiTietHoaDons
                         where item.HoaDonID.Equals(HoadonID) && item.SanPhamID.Equals(SanphamID)
                         select item).Count();
            if (query > 0)
                return true;
            return false;
        }
        public void XoaChiTietHoaDon(int BillID, int SanPhamID, int SoLuong)
        {
            var query = (from item in caPheContext.ChiTietHoaDons
                         where item.SoLuong <=SoLuong && item.SanPhamID.Equals(SanPhamID)&&item.HoaDonID.Equals(BillID)
                         select item).ToList();
            foreach (var item in query)
                caPheContext.ChiTietHoaDons.Remove(item);
            caPheContext.SaveChanges();
            
        }
         public void CapNhatTrangThaiHoaDon(int ID_HoaDon , CaPheContext context, double tongtien)
        {
            var hd = (from hoadon in context.HoaDons
                      where hoadon.HoaDonId == ID_HoaDon
                      select hoadon).ToList();
         
            foreach(var hoadon in hd)
            {
                
                hoadon.TongGia = tongtien;
                hoadon.TinhTrang = 1;
                context.Entry(hoadon).State = EntityState.Modified;
                context.SaveChanges();
            }
           
        }
        public void XoaHoaDon(int HoaDonID)
        {
            HoaDon hoadon = new HoaDon() { HoaDonId = HoaDonID };
            caPheContext.Entry(hoadon).State = EntityState.Deleted;
            caPheContext.SaveChanges();
            
        }
        public void CapNhatChiTietHoaDon(int HoaDonID1,int HoaDonID2)
        {
            var query = (from item in caPheContext.ChiTietHoaDons
                         where item.HoaDonID.Equals(HoaDonID2)
                         select item).ToList();
            foreach (var item in query) {
                item.HoaDonID = HoaDonID1;
                caPheContext.Entry(item).State = EntityState.Modified;
                caPheContext.SaveChanges();
            }
        }
    }
}