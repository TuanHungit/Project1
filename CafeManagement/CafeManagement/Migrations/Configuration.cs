namespace CafeManagement.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CafeManagement.LinQ;
    using CafeManagement.Data;
    internal sealed class Configuration : DbMigrationsConfiguration<CafeManagement.Data.CaPheContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        Query_NhanVien query_NhanVien = new Query_NhanVien();
        protected override void Seed(CafeManagement.Data.CaPheContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            NhanVien nhanVien = new NhanVien()
            {
                HoTenNV = "Nguyễn Tuấn Hùng",
                ChucVu = "Quản lý",
                QueQuan = "Tiền Giang",
                CMND = "312378546",
                SDT_NV = "0355243283",
                NgayVaoLam = Convert.ToDateTime("04/04/2019"),
                NgaySinh = Convert.ToDateTime("04/04/1999"),
            };
            context.NhanViens.Add(nhanVien);
            context.SaveChanges();
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                LoaiTaiKhoan = "Quản lý",
                password = "admin",
                username = "admin",
                NhanVienID = query_NhanVien.LayNhanVienIDbyCMND(context, "312378546")
            };
            context.TaiKhoans.Add(taiKhoan);
            context.SaveChanges();
        }
    }
}
