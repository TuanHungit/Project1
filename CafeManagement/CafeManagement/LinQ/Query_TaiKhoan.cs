using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
namespace CafeManagement.LinQ
{
    public class Query_TaiKhoan
    {
        CaPheContext context = new CaPheContext();
        public bool Delete_TaiKhoan(int id)
        {
            if (KiemTraTaiKhoan(id))
            {

                var query = (from item in context.TaiKhoans
                             where item.NhanVienID.Equals(id)
                             select item).ToList();
                foreach (var item in query)
                    context.TaiKhoans.Remove(item);
                context.SaveChanges();
                return true;
            }
            return false;
        }                              
        public bool KiemTraTaiKhoan(int id)
        {
            var query = (from item in context.TaiKhoans
                         where item.NhanVienID.Equals(id)
                         select item).ToList();
            if (query.Count == 0)
                return false;
            return true;
        }

        public bool ThemTaiKhoan(int NhanvienID,string Username,string Password,string LoaiTaiKhoan)
        {
            if (!KiemTraTaiKhoan(NhanvienID) && !KiemTraUser(Username))
            {
                var taikhoan = new TaiKhoan()
                {
                    NhanVienID = NhanvienID,
                    username = Username,
                    password = Password,
                    LoaiTaiKhoan = LoaiTaiKhoan
                };
                context.TaiKhoans.Add(taikhoan);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool SuaTaiKhoan(int NhanvienID, string Username, string Password, string LoaiTaiKhoan)
        {
            if (KiemTraTaiKhoan(NhanvienID) && KiemTraUser(Username))
            {
                var nhanviens = (from nv in context.TaiKhoans
                                 where nv.NhanVienID == NhanvienID
                                 select nv).FirstOrDefault();

                nhanviens.username = Username;
                nhanviens.password = Password;
                nhanviens.LoaiTaiKhoan = LoaiTaiKhoan;
                context.Entry(nhanviens).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public List<TaiKhoan> GetTaiKhoan(int NhanVienID)
        {
            return (from item in context.TaiKhoans
                    where item.NhanVienID.Equals(NhanVienID)
                    select item).ToList();
        }
        public bool KiemTraUser(string Username)
        {
            var query = (from item in context.TaiKhoans
                         where item.username.Equals(Username)
                         select item).ToList();
            if (query.Count == 0)
                return false;
            return true;
        }
    }
}
