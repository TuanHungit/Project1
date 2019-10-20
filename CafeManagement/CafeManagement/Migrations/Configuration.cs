namespace CafeManagement.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CafeManagement.Data;
    internal sealed class Configuration : DbMigrationsConfiguration<CafeManagement.Data.CaPheContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CafeManagement.Data.CaPheContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            IList<NhanVien> lists = new List<NhanVien>();
            lists.Add(new NhanVien() { HoTenNV = "Nguyen Tuan Hung", SDT_NV = "0355243283", CMND = 312378546, NgaySinh = Convert.ToDateTime("2019/02/25"), NgayVaoLam = Convert.ToDateTime("2019/02/25") });
            context.NhanViens.AddRange(lists);
           
        }
    }
}
