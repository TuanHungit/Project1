using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
    public static class Global
    {
        public static CaPheContext context = new CaPheContext();
        public static int NhanVienID;
        public static string LoaiTaiKhoan;
        public static string TenSanPham;
        public static double Gia;
        public static string ThanhTien;
        public static int BanID;
    }
}
