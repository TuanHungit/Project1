using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
using System.Data.Entity;
namespace CafeManagement.LinQ
{
    public class Query_DanhMuc
    {
        CaPheContext caPheContext = new CaPheContext();
        public bool KiemTraDanhMuc(string TenDanhMuc)
        {

            var has = (from item in caPheContext.LoaiSanPhams
                       where item.TenLoaiSanPham.Contains(TenDanhMuc)
                        select item).Count();

            if (Convert.ToInt32(has)>0)
                return true;
            return false;
        }
        public bool AddDanhMuc(string Ten)
        {
            if (!KiemTraDanhMuc(Ten))
            {
                LoaiSanPham loaiSanPham = new LoaiSanPham()
                {
                  
                    TenLoaiSanPham = Ten
                };
                caPheContext.LoaiSanPhams.Add(loaiSanPham);
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteDanhMuc(string TenDanhMuc)
        {
            int DanhmucID = GetIdDanhMuc(TenDanhMuc, caPheContext);
            if (KiemTraDanhMuc(TenDanhMuc))
            {
                var danhmuc = new LoaiSanPham() { LoaiSanPhamId = DanhmucID };
                if (KiemTraSanPhamTrongDanhMuc(DanhmucID))
                {
                 
                    List<SanPham> sanphams = GetAllSanPham(danhmuc.LoaiSanPhamId);
                    foreach (var sp in sanphams)
                    {
                        caPheContext.SanPhams.Remove(sp);
                    }
                }
                caPheContext.Entry(danhmuc).State = EntityState.Deleted;
                caPheContext.SaveChanges();
                return true;
            }
            return false;
        }
        public List<LoaiSanPham> FindDanhMuc(string Ten)
        {

            return (from item in caPheContext.LoaiSanPhams
                    where item.TenLoaiSanPham.StartsWith(Ten)
                    select item).ToList();
        }
        public List<LoaiSanPham> LayIdDanhMuc(string TenDanhMuc)
        {
            var sp = (from item in caPheContext.LoaiSanPhams
                      where item.TenLoaiSanPham.ToUpper().Trim().Contains(TenDanhMuc.ToUpper())
                      select item).ToList();
            return sp;
        }

        public int GetIdDanhMuc(string TenDanhMuc ,CaPheContext caPheContext)
        {
            int sp = (from item in caPheContext.LoaiSanPhams
                      where item.TenLoaiSanPham.ToUpper().Trim().Contains(TenDanhMuc.ToUpper())
                      select item.LoaiSanPhamId).SingleOrDefault();
            return sp;
        }
        public List<SanPham> GetAllSanPham(int danhmucid)
        {
            var sanphams = (from Sanpham in caPheContext.SanPhams
                            where Sanpham.LoaiSanPhamId == danhmucid
                            select Sanpham).ToList();
            return sanphams;
        }
        public bool KiemTraSanPhamTrongDanhMuc(int DanhMucID)
        {
            if (GetAllSanPham(DanhMucID).Count > 0)
                return true;
            return false;
        }
        public string LayTenDanhMucTheoId(int SanPhamId)
        {
            return (from item in caPheContext.LoaiSanPhams
                    where item.LoaiSanPhamId.Equals(SanPhamId)
                    select item.TenLoaiSanPham).SingleOrDefault();
        }
    }
}
