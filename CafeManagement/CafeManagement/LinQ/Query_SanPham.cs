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
    public class Query_SanPham
    {
        public bool KiemTraMon(string tenMon, CaPheContext context)
        {
            var sp = (from sanpham in context.SanPhams
                      where sanpham.TenSanPham.ToUpper().Contains(tenMon.ToUpper())
                      select sanpham).Count();
            if (sp==0)
                return true;
            return false;
        }
        public bool Add_Mon(string tenMon, CaPheContext context, double dongia, int idDM)
        {
            if(KiemTraMon(tenMon, context))
            {
                var i = 1;
                var sanpham = new SanPham() { SanPhamId = i, TenSanPham = tenMon,DonGia= dongia,LoaiSanPhamId=idDM};
                context.SanPhams.Add(sanpham);
               
                context.SaveChanges();
                i = i++;
                return true;
            }
            return false;
        }
    }
}
