using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
using System.Data.Entity;

namespace CafeManagement.LinQ
{
   public class Query_NhanVien
    {
        public bool Add_NV( CaPheContext context, string hoten, string chucvu, string cmnd, string sdt,DateTime ngaysinh, DateTime ngayvaolam )
        {
            
            if (KiemTra(context, cmnd) == 0)
            {
                var nhanvien = new NhanVien()
                {
                    HoTenNV = hoten,
                    ChucVu = chucvu,
                    SDT_NV = sdt,
                    CMND = cmnd,
                    NgaySinh = ngaysinh,
                    NgayVaoLam = ngayvaolam
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
        public bool Delete_NV(CaPheContext context, string hoten, string chucvu, string cmnd, string sdt)
        {
            int id = KiemTra(context, cmnd);
            if (id!=0)
            {
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
        public bool Update_NV(CaPheContext context, string hoten, string chucvu, string cmnd, string sdt, DateTime ngaysinh, DateTime ngayvaolam)
        {
            int id = KiemTra(context, cmnd);
            if (id != 0)
            {
                var nhanvien = new NhanVien()
                {
                    NhanVienId = id,
                    HoTenNV = hoten,
                    ChucVu = chucvu,
                    SDT_NV = sdt,
                    CMND = cmnd,
                    NgaySinh = ngaysinh,
                    NgayVaoLam = ngayvaolam
                };
                context.Entry(nhanvien).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
