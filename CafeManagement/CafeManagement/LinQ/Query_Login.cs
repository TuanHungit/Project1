using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManagement.Data;
namespace CafeManagement.LinQ
{
    public class Query_Login
    {
        CaPheContext caPheContext = new CaPheContext();
        public bool DanhNhap(string Username, string password)
        {
            var query = (from item in caPheContext.TaiKhoans
                         where item.username.Equals(Username) && item.password.Equals(password)
                         select item).ToList();
            if (query.Count != 0)
            {
                foreach (var item in query)
                {
                    Global.NhanVienID = item.NhanVienID;
                    Global.LoaiTaiKhoan = item.LoaiTaiKhoan;
                }
                return true;
            }
         return false;  
        }

    }
}
