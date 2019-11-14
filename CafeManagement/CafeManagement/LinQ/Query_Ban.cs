using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CafeManagement.Data;
using System.Data.Entity;
namespace CafeManagement.LinQ
{
    public class Query_Ban
    {
        Query_HoaDon hoaDon = new Query_HoaDon();
        public bool Add_Ban(int soBan, CaPheContext context)
        {
            if (!KiemTraBan(soBan, context))
            {
                var ban = new Ban() { BanId = Convert.ToInt32(soBan), TinhTrang = "Trống" };
                context.Bans.Add(ban);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool KiemTraBan(int soBan, CaPheContext context)
        {
            var x = (from ban in context.Bans
                     where ban.BanId == soBan
                     select ban.BanId).SingleOrDefault();
            if (Convert.ToInt32(x) == soBan)
                return true;
            return false;
        }
        public List<int> load_Ban(CaPheContext context)
        {

            var listban = (from ban in context.Bans
                           select ban.BanId).ToList();

            return listban;

        }
        public bool DemSoLuongBan(CaPheContext context)
        {
            var x = (from ban in context.Bans
                     select ban.BanId).Count();
            if (x == 0)
                return true;
            return false;
        }
        public bool xoaBan(CaPheContext context, int soBan)
        {
            if (KiemTraBan(soBan, context))
            {
                var ban = new Ban() { BanId = soBan };
                context.Entry(ban).State = EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
            return false;

        }
        public void Update_Ban(CaPheContext context, int id_ban)
        {
            var ban = (from Ban in context.Bans
                       where Ban.BanId == id_ban
                       select Ban).ToList();
            foreach (var b in ban)
            {
                b.TinhTrang = "Có người";
                context.Entry(b).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        public void Update_Ban1(CaPheContext context, int id_ban)
        {
            var ban = (from Ban in context.Bans
                       where Ban.BanId == id_ban
                       select Ban).ToList();
            foreach (var b in ban)
            {
                b.TinhTrang = "Trống";
                context.Entry(b).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        public List<Ban> GetAllTable(CaPheContext context)
        {
            return (from item in context.Bans
                    select item).ToList();
        }

        public void GopBan(int BanID1, int BanID2,CaPheContext caPheContext)
        {
          
            int BillID1, BillID2;
            BillID1 = hoaDon.LayHoaDonChuaThanhToan(BanID1);
            BillID2 = hoaDon.LayHoaDonChuaThanhToan(BanID2);
            if (BillID1 != 0 && BillID2 != 0)
            {
                hoaDon.CapNhatChiTietHoaDonKhiGopBan(BillID1, BillID2);
                hoaDon.XoaHoaDon(BillID2);
                Update_Ban1(caPheContext, BanID2);

            }
            else if (BillID1 == 0 && BillID2 != 0)
            {
                hoaDon.AddHoaDon(BanID1);
                int BillID = hoaDon.LayHoaDonChuaThanhToan(BanID1);
                hoaDon.CapNhatChiTietHoaDonKhiGopBan(BillID,BillID2);
                hoaDon.XoaHoaDon(BillID2);
                Update_Ban(caPheContext, BanID1);
                Update_Ban1(caPheContext, BanID2);
            }
            else if(BillID1!=0&&BillID2==0)
            {
                hoaDon.AddHoaDon(BanID2);
                int BillID = hoaDon.LayHoaDonChuaThanhToan(BanID2);
                hoaDon.CapNhatChiTietHoaDonKhiGopBan(BillID2,BillID);
                hoaDon.XoaHoaDon(BillID1);
                Update_Ban(caPheContext, BanID2);
                Update_Ban1(caPheContext, BanID1);
            }
            caPheContext.SaveChanges();
        }
        public bool KiemTraBanConMonKhong(int BanID,CaPheContext caPheContext)
        {
            var query = (from chitiethoadon in caPheContext.ChiTietHoaDons
                         join hoadon in caPheContext.HoaDons on chitiethoadon.HoaDonID equals hoadon.HoaDonId
                         where hoadon.BanID.Equals(BanID)
                         select hoadon
                        ).ToList();
            if (query.Count > 0)
                return true;
            return false;
        }
    }
}
