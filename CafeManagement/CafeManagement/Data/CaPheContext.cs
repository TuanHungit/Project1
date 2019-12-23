using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;
using CafeManagement.GUI;

namespace CafeManagement.Data
{
    public class CaPheContext : DbContext
    {
        public CaPheContext(string connect) : base("connectionString")
        {
            ConnectToSqlServer();
        }
        public CaPheContext() : base()
        {

        }
        //public CaPheContext()
        //: base(ConnectToSqlServer())
        //{
           
        //}

        public static string ConnectToSqlServer()
        {
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder
            {
                DataSource = Global.connect,
                InitialCatalog = "CafeManagement",
                IntegratedSecurity = true,
            };
            Global.connectionstring = sqlBuilder.ConnectionString;

            return sqlBuilder.ConnectionString;
        }
       
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons {get;set;}
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>()
                 .Property(nv => nv.CMND)
                 .IsRequired();

        }
        
    }
}
