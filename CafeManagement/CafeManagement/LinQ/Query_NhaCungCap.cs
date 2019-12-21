using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
using System.Data.Entity;
namespace CafeManagement.LinQ
{
   public class Query_NhaCungCap
    {
        CaPheContext caPheContext = new CaPheContext();
        public bool KiemTraTonTai(string TenNCC)
        {
            var query = (from item in caPheContext.NhaCungCaps
                         where item.TenNhaCungCap ==(TenNCC)
                         select item).ToList();
            if (query.Count > 0)
                return false;
            return true;
        }
        public bool ThemNhaCungCap(string TenNCC, string SDT, string DiaChi, string email)
        {
            if (KiemTraTonTai(TenNCC))
            {
                NhaCungCap nhaCungCap = new NhaCungCap()
                {
                    TenNhaCungCap = TenNCC,
                    SDT = SDT,
                    DiaChi = DiaChi,
                    Email = email
                };
                caPheContext.NhaCungCaps.Add(nhaCungCap);
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool XoaNhaCungCap(string TenNCC)
        {
            int NccID = LayIDByTenNhaCungCap(TenNCC);
            if (NccID!=0)
            {
                var query = (from item in caPheContext.NhaCungCaps
                             where item.NhaCungCapId.Equals(NccID)
                             select item).ToList();
                foreach(var item in query)
                {
                    caPheContext.NhaCungCaps.Remove(item);
                }
             
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool SuaNhaCungCap(int NccID,string TenNCC,string SDT,string DiaChi,string Email)
        {
            if (NccID != 0)
            {
                var nhacungcap = (from item in caPheContext.NhaCungCaps
                                  where item.NhaCungCapId.Equals(NccID)
                                  select item).FirstOrDefault();
                nhacungcap.TenNhaCungCap = TenNCC;
                nhacungcap.SDT = SDT;
                nhacungcap.DiaChi = DiaChi;
                nhacungcap.Email = Email;
                caPheContext.SaveChanges();
                return true;
            }
            return false;

        }
        public int LayIDByTenNhaCungCap(string TenNhaCungCap)
        {
            var query = (from item in caPheContext.NhaCungCaps
                         where item.TenNhaCungCap.Contains(TenNhaCungCap)
                         select item.NhaCungCapId).FirstOrDefault();
            return query;
        }
    }
}
