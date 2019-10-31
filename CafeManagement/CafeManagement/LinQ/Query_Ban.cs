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
        public bool Add_Ban(int soBan, CaPheContext context)
        {
            if (!KiemTraBan(soBan, context))
            {
                var ban = new Ban() { BanId = Convert.ToInt32(soBan) , TinhTrang = "Trống"};
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
            foreach( var b in ban)
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

        public void GopBan(int BanID1, int BanID2)
        {
            Query_HoaDon hoaDon = new Query_HoaDon();
            CaPheContext caPheContext = new CaPheContext();
            int BillID1, BillID2;
            BillID1 = hoaDon.LayHoaDonChuaThanhToan(BanID1);
            BillID2 = hoaDon.LayHoaDonChuaThanhToan(BanID2);
            if (BillID1 != 0 && BillID2 != 0)
            {
                foreach (var item in caPheContext.ChiTietHoaDons)
                {
                    if (item.HoaDonID == BillID2)
                    {
                        item.HoaDonID = BillID1;
                     
                    
                        hoaDon.XoaHoaDon(BillID2);
                        Update_Ban1(caPheContext, BanID2);
                    }
                    caPheContext.SaveChanges();
                }
            }
        
        }
    }
}
