﻿using System;
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

            if (Convert.ToInt32(has) > 0)
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
            if (KiemTraDanhMuc(TenDanhMuc))
            {
                var danhmuc = new LoaiSanPham() { LoaiSanPhamId = GetIdDanhMuc(TenDanhMuc, caPheContext) };
                List<SanPham> sanphams = GetAllSanPham(danhmuc.LoaiSanPhamId);
                foreach (var sp in sanphams)
                {
                    var s = new SanPham() { SanPhamId = sp.SanPhamId };
                    caPheContext.Entry(sp).State = EntityState.Deleted;
                    caPheContext.SaveChanges();
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

        public int GetIdDanhMuc(string TenDanhMuc, CaPheContext caPheContext)
        {
            var sp = (from item in caPheContext.LoaiSanPhams
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
    }
}
