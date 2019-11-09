using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
using System.Data.Entity;
using System.IO;

namespace CafeManagement.LinQ
{
   public class Query_NhanVien
    {
        public bool Add_NV( CaPheContext context, string hoten, string quequan,string chucvu, string cmnd, string sdt,DateTime ngaysinh, DateTime ngayvaolam , byte[] image)
        {
            
            if (KiemTra(context, cmnd) == 0)
            {
                var nhanvien = new NhanVien()
                {
                    HoTenNV = hoten,
                    QueQuan = quequan,
                    ChucVu = chucvu,
                    SDT_NV = sdt,
                    CMND = cmnd,
                    NgaySinh = ngaysinh,
                    NgayVaoLam = ngayvaolam,
                    Picture = image
                };
                context.NhanViens.Add(nhanvien);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public int KiemTra(CaPheContext context, string cmnd)
        {
            var sp = (from nv in context.NhanViens
                        where nv.CMND.Contains(cmnd)
                        select nv.NhanVienId).SingleOrDefault();
            return sp;
        }
        public bool Delete_NV(CaPheContext context,string cmnd)
        {
          
            int id = KiemTra(context, cmnd);
            Query_TaiKhoan taiKhoan = new Query_TaiKhoan(); 
            if (id!=0)
            {
                taiKhoan.Delete_TaiKhoan(id);
                var nhanvien = new NhanVien()
                {
                    NhanVienId=id                              
                };
                context.Entry(nhanvien).State = EntityState.Deleted;
                context.SaveChanges();
                return true;
            } 
            return false;
        }
        public bool Update_NV(CaPheContext context, string hoten, string quequan,string chucvu, string cmnd, string sdt, DateTime ngaysinh, DateTime ngayvaolam,byte[] image)
        {
            int id = KiemTra(context, cmnd);
            if (id != 0)
            {
                var nhanvien = new NhanVien()
                {
                    NhanVienId = id,
                    QueQuan = quequan,
                    HoTenNV = hoten,
                    ChucVu = chucvu,
                    SDT_NV = sdt,
                    CMND = cmnd,
                    NgaySinh = ngaysinh,
                    NgayVaoLam = ngayvaolam,
                    Picture = image
                };
                context.Entry(nhanvien).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public int LayNhanVienIDbyCMND(CaPheContext caPheContext,string CMND)
        { 
            return  (from item in caPheContext.NhanViens
                         where item.CMND.Equals(CMND)
                     select item.NhanVienId).SingleOrDefault();
        }
   
        
    }
}
