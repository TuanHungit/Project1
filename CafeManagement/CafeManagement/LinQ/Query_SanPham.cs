using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CafeManagement.Data;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace CafeManagement.LinQ
{
    public  class Query_SanPham
    {
        public bool KiemTraMon(string tenMon, CaPheContext context)
        {
            var sp = (from sanpham in context.SanPhams
                      where sanpham.TenSanPham.ToUpper().Contains(tenMon.ToUpper())
                      select sanpham).Count();
            if (sp == 0)
                return true;
            return false;
        }
        public bool Add_Mon(string tenMon, CaPheContext context, double dongia, int idDM)
        {
            if(KiemTraMon(tenMon, context))
            {
    
                var sanpham = new SanPham() { TenSanPham = tenMon,TinhTrang="Đang hoạt động",DonGia= dongia,LoaiSanPhamId=idDM};
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

                var sanpham = new SanPham() { SanPhamId = LayIdSanPham(tenMon, context)};
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
        public bool Update_Mon(int SanPhamId,string tenMon, CaPheContext context, double dongia,int loaisanphamId)
        {
            if (SanPhamId!=0)
            {
                var query = (from item in context.SanPhams
                             where item.SanPhamId.Equals(SanPhamId)
                             select item).ToList();
                foreach (var item in query)
                {
                    item.TenSanPham = tenMon;
                    item.DonGia = dongia;
                    item.LoaiSanPhamId = loaisanphamId;
                }
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public int LayIdDanhMuc(string tenMon, CaPheContext context)
        {
            int sp = (from sanpham in context.SanPhams
                      where sanpham.TenSanPham.ToUpper().Trim().Contains(tenMon.ToUpper())
                      select sanpham.LoaiSanPhamId).SingleOrDefault();
            return sp;
        }
        public double LayGiaSanPham(int idsp, CaPheContext context)
        {
            return (from sp in context.SanPhams
                    where sp.SanPhamId == idsp
                    select sp.DonGia).SingleOrDefault();
        }
        public List<SanPham> TimSanPham(string Ten,CaPheContext caPheContext)
        {
            return (from item in caPheContext.SanPhams
                    where item.TenSanPham.StartsWith(Ten)
                    select item).ToList();

        }
    }
}
