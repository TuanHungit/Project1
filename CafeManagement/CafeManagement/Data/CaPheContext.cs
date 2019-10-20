using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CafeManagement.Data
{
    public class CaPheContext:DbContext
    {
        public CaPheContext() : base("CaPheContext")
        {

        }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<Ban> Bans { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>()
                 .Property(nv => nv.CMND)
                 .IsRequired();
        }
    }
}
