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
        CaPheContext caPheContext = Global.context;
        public bool KiemTraMon(string tenMon)
        {
            var sp = (from sanpham in caPheContext.SanPhams
                      where sanpham.TenSanPham.ToUpper().Contains(tenMon.ToUpper())
                      select sanpham).Count();
            if (sp == 0)
                return true;
            return false;
        }
        public bool Add_Mon(string tenMon, double dongia, int idDM)
        {
            if(KiemTraMon(tenMon))
            {
    
                var sanpham = new SanPham() { TenSanPham = tenMon,TinhTrang="Đang hoạt động",DonGia= dongia,LoaiSanPhamId=idDM};
                caPheContext.SanPhams.Add(sanpham);
               
                caPheContext.SaveChanges();
               
                return true;
            }
            return false;
        }
        public bool Delete_Mon(string tenMon, int MonId)
        {
            if (!KiemTraMon(tenMon))
            {

                var sanpham = (from item in caPheContext.SanPhams
                              where item.SanPhamId.Equals(MonId)
                              select item).FirstOrDefault();
                caPheContext.SanPhams.Remove(sanpham);
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public int LayIdSanPham(string tenMon)
        {
            var sp = (from sanpham in caPheContext.SanPhams
                      where sanpham.TenSanPham.ToUpper().Trim().Contains(tenMon.ToUpper())
                      select sanpham.SanPhamId).SingleOrDefault();
            return sp;
        }
        public bool Update_Mon(int SanPhamId,string tenMon, double dongia,int loaisanphamId)
        {
            if (SanPhamId!=0)
            {
                var query = (from item in caPheContext.SanPhams
                             where item.SanPhamId.Equals(SanPhamId)
                             select item).ToList();
                foreach (var item in query)
                {
                    item.TenSanPham = tenMon;
                    item.DonGia = dongia;
                    item.LoaiSanPhamId = loaisanphamId;
                }
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public int LayIdDanhMuc(string tenMon)
        {
            int sp = (from sanpham in caPheContext.SanPhams
                      where sanpham.TenSanPham.ToUpper().Trim().Contains(tenMon.ToUpper())
                      select sanpham.LoaiSanPhamId).SingleOrDefault();
            return sp;
        }
        public double LayGiaSanPham(int idsp)
        {
            return (from sp in caPheContext.SanPhams
                    where sp.SanPhamId == idsp
                    select sp.DonGia).SingleOrDefault();
        }
        public List<SanPham> TimSanPham(string Ten)
        {
            return (from item in caPheContext.SanPhams
                    where item.TenSanPham.StartsWith(Ten)
                    select item).ToList();

        }
       
    }
}
