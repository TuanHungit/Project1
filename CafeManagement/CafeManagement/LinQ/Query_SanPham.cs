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
    
                var sanpham = new SanPham() { TenSanPham = tenMon,DonGia= dongia,LoaiSanPhamId=idDM};
                context.SanPhams.Add(sanpham);
               
                context.SaveChanges();
               
                return true;
            }
            return false;
        }
        public bool Delete_Mon(string tenMon, CaPheContext context)
        {
            if (!KiemTraMon(tenMon, context))
            {

                var sanpham = new SanPham() { SanPhamId = LayIdSanPham(tenMon, context) };
                context.Entry(sanpham).State = EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public int LayIdSanPham(string tenMon, CaPheContext context)
        {
            var sp = (from sanpham in context.SanPhams
                      where sanpham.TenSanPham.ToUpper().Trim().Contains(tenMon.ToUpper())
                      select sanpham.SanPhamId).SingleOrDefault();
            return sp;
        }
        public bool Update_Mon(string tenMon, CaPheContext context, double dongia)
        {
            if (!KiemTraMon(tenMon, context))
            {
                var sanpham = new SanPham() { SanPhamId = LayIdSanPham(tenMon, context), LoaiSanPhamId = LayIdDanhMuc(tenMon, context), TenSanPham = tenMon, DonGia = dongia };
                context.Entry(sanpham).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public int LayIdDanhMuc(string tenMon, CaPheContext context)
        {
            var sp = (from sanpham in context.SanPhams
                      where sanpham.TenSanPham.ToUpper().Trim().Contains(tenMon.ToUpper())
                      select sanpham.LoaiSanPhamId).SingleOrDefault();
            return sp;
        }
    }
}
