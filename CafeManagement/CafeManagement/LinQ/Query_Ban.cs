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
        CaPheContext context = Global.context;
    
        public  bool Add_Ban(int soBan)
        {
            if (!KiemTraBan(soBan))
            {
                var ban = new Ban() { BanId = Convert.ToInt32(soBan), TinhTrang = "Trống" };
                context.Bans.Add(ban);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public  bool KiemTraBan(int soBan)
        {
            var x = (from ban in context.Bans
                     where ban.BanId == soBan
                     select ban.BanId).SingleOrDefault();
            if (Convert.ToInt32(x) == soBan)
                return true;
            return false;
        }
        public  List<int> load_Ban()
        {

            var listban = (from ban in context.Bans
                           select ban.BanId).ToList();
            return listban;

        }
        public  bool DemSoLuongBan()
        {
            var x = (from ban in context.Bans
                     select ban.BanId).Count();
            if (x == 0)
                return true;
            return false;
        }
        public  bool xoaBan(int soBan)
        {
            if (KiemTraBan(soBan))
            {
                var ban = (from item in context.Bans
                           where item.BanId.Equals(soBan)
                           select item).ToList();
                foreach (var item in ban)
                {
                    context.Bans.Remove(item);
                }
          
                context.SaveChanges();
                return true;
            }
            return false;

        }
        public  void Update_Ban(int id_ban)
        {
            var ban = (from Ban in context.Bans
                       where Ban.BanId == id_ban
                       select Ban).ToList();
            foreach (var b in ban)
            {
                b.TinhTrang = "Có người"; 
            }
            context.SaveChanges();
        }
        public  void Update_Ban1( int id_ban)
        {
            var ban = (from Ban in context.Bans
                       where Ban.BanId == id_ban
                       select Ban).ToList();
            foreach (var b in ban)
            {
                b.TinhTrang = "Trống";
                
            }
            context.SaveChanges();

        }
        public  List<Ban> GetAllTable()
        {
            return (from item in context.Bans
                    select item).ToList();
        }

        public void GopBan(int BanID1, int BanID2)
        {
          
            int BillID1, BillID2;
            BillID1 = hoaDon.LayHoaDonChuaThanhToan(BanID1);
            BillID2 = hoaDon.LayHoaDonChuaThanhToan(BanID2);
            if (BillID1 != 0 && BillID2 != 0)
            {
                hoaDon.CapNhatChiTietHoaDonKhiGopBan(BillID1, BillID2);
                hoaDon.XoaHoaDon(BillID2);
                Update_Ban1(BanID2);

            }
            else if (BillID1 == 0 && BillID2 != 0)
            {
                hoaDon.AddHoaDon(BanID1);
                int BillID = hoaDon.LayHoaDonChuaThanhToan(BanID1);
                hoaDon.CapNhatChiTietHoaDonKhiGopBan(BillID,BillID2);
                hoaDon.XoaHoaDon(BillID2);
                Update_Ban( BanID1);
                Update_Ban1(BanID2);
            }
            else if(BillID1!=0&&BillID2==0)
            {
                hoaDon.AddHoaDon(BanID2);
                int BillID = hoaDon.LayHoaDonChuaThanhToan(BanID2);
                hoaDon.CapNhatChiTietHoaDonKhiGopBan(BillID2,BillID);
                hoaDon.XoaHoaDon(BillID1);
                Update_Ban(BanID2);
                Update_Ban1( BanID1);
            }
           context.SaveChanges();
        }
        public bool KiemTraBanConMonKhong(int BanID)
        {
            var query = (from chitiethoadon in context.ChiTietHoaDons
                         join hoadon in context.HoaDons on chitiethoadon.HoaDonID equals hoadon.HoaDonId
                         where hoadon.BanID ==BanID
                         select chitiethoadon
                        ).Count();
            if (query >0)
                return true;
            return false;
        }
    }
}
