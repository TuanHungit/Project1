namespace CafeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bans",
                c => new
                    {
                        BanId = c.Int(nullable: false),
                        TinhTrang = c.String(),
                    })
                .PrimaryKey(t => t.BanId);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        HoaDonId = c.Int(nullable: false, identity: true),
                        NgayLap = c.DateTime(nullable: false),
                        NhanVienId = c.Int(nullable: false),
                        BanID = c.Int(nullable: false),
                        TongGia = c.Double(nullable: false),
                        TinhTrang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HoaDonId)
                .ForeignKey("dbo.Bans", t => t.BanID, cascadeDelete: true)
                .ForeignKey("dbo.NhanViens", t => t.NhanVienId, cascadeDelete: true)
                .Index(t => t.NhanVienId)
                .Index(t => t.BanID);
            
            CreateTable(
                "dbo.ChiTietHoaDons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HoaDonID = c.Int(nullable: false),
                        SanPhamID = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HoaDons", t => t.HoaDonID, cascadeDelete: true)
                .ForeignKey("dbo.SanPhams", t => t.SanPhamID, cascadeDelete: true)
                .Index(t => t.HoaDonID)
                .Index(t => t.SanPhamID);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        SanPhamId = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(),
                        DonGia = c.Double(nullable: false),
                        LoaiSanPhamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SanPhamId)
                .ForeignKey("dbo.LoaiSanPhams", t => t.LoaiSanPhamId, cascadeDelete: true)
                .Index(t => t.LoaiSanPhamId);
            
            CreateTable(
                "dbo.LoaiSanPhams",
                c => new
                    {
                        LoaiSanPhamId = c.Int(nullable: false, identity: true),
                        TenLoaiSanPham = c.String(),
                    })
                .PrimaryKey(t => t.LoaiSanPhamId);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        NhanVienId = c.Int(nullable: false, identity: true),
                        HoTenNV = c.String(),
                        QueQuan = c.String(),
                        ChucVu = c.String(),
                        SDT_NV = c.String(),
                        CMND = c.String(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        NgayVaoLam = c.DateTime(nullable: false),
                        Picture = c.Binary(),
                    })
                .PrimaryKey(t => t.NhanVienId);
            
            CreateTable(
                "dbo.PhieuNhaps",
                c => new
                    {
                        PhieuNhapId = c.Int(nullable: false, identity: true),
                        NhaCungCapId = c.Int(nullable: false),
                        NhanVienId = c.Int(nullable: false),
                        NgayDatHang = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PhieuNhapId)
                .ForeignKey("dbo.NhaCungCaps", t => t.NhaCungCapId, cascadeDelete: true)
                .ForeignKey("dbo.NhanViens", t => t.NhanVienId, cascadeDelete: true)
                .Index(t => t.NhaCungCapId)
                .Index(t => t.NhanVienId);
            
            CreateTable(
                "dbo.ChiTietPhieuNhaps",
                c => new
                    {
                        ChiTietPhieuNhapId = c.Int(nullable: false, identity: true),
                        PhieuNhapId = c.Int(nullable: false),
                        HangHoaID = c.Int(nullable: false),
                        SoLuongDat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChiTietPhieuNhapId)
                .ForeignKey("dbo.HangHoas", t => t.HangHoaID, cascadeDelete: true)
                .ForeignKey("dbo.PhieuNhaps", t => t.PhieuNhapId, cascadeDelete: true)
                .Index(t => t.PhieuNhapId)
                .Index(t => t.HangHoaID);
            
            CreateTable(
                "dbo.HangHoas",
                c => new
                    {
                        HangHoaId = c.Int(nullable: false, identity: true),
                        TenHangHoa = c.String(),
                        DonViTinh = c.String(),
                        DonGia = c.Double(nullable: false),
                        SoLuongTon = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HangHoaId);
            
            CreateTable(
                "dbo.ChiTietPhieuXuats",
                c => new
                    {
                        ChiTietPhieuXuatId = c.Int(nullable: false, identity: true),
                        PhieuXuatId = c.Int(nullable: false),
                        HangHoaId = c.Int(nullable: false),
                        SoLuongXuat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChiTietPhieuXuatId)
                .ForeignKey("dbo.HangHoas", t => t.HangHoaId, cascadeDelete: true)
                .ForeignKey("dbo.PhieuXuats", t => t.PhieuXuatId, cascadeDelete: true)
                .Index(t => t.PhieuXuatId)
                .Index(t => t.HangHoaId);
            
            CreateTable(
                "dbo.PhieuXuats",
                c => new
                    {
                        PhieuXuatId = c.Int(nullable: false, identity: true),
                        NgayLap = c.DateTime(nullable: false),
                        NhanVienId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhieuXuatId)
                .ForeignKey("dbo.NhanViens", t => t.NhanVienId, cascadeDelete: true)
                .Index(t => t.NhanVienId);
            
            CreateTable(
                "dbo.NhaCungCaps",
                c => new
                    {
                        NhaCungCapId = c.Int(nullable: false, identity: true),
                        TenNhaCungCap = c.String(),
                        Email = c.String(),
                        SDT = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.NhaCungCapId);
            
            CreateTable(
                "dbo.TaiKhoans",
                c => new
                    {
                        NhanVienID = c.Int(nullable: false),
                        username = c.String(),
                        password = c.String(),
                        LoaiTaiKhoan = c.String(),
                    })
                .PrimaryKey(t => t.NhanVienID)
                .ForeignKey("dbo.NhanViens", t => t.NhanVienID)
                .Index(t => t.NhanVienID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaiKhoans", "NhanVienID", "dbo.NhanViens");
            DropForeignKey("dbo.PhieuNhaps", "NhanVienId", "dbo.NhanViens");
            DropForeignKey("dbo.PhieuNhaps", "NhaCungCapId", "dbo.NhaCungCaps");
            DropForeignKey("dbo.ChiTietPhieuNhaps", "PhieuNhapId", "dbo.PhieuNhaps");
            DropForeignKey("dbo.PhieuXuats", "NhanVienId", "dbo.NhanViens");
            DropForeignKey("dbo.ChiTietPhieuXuats", "PhieuXuatId", "dbo.PhieuXuats");
            DropForeignKey("dbo.ChiTietPhieuXuats", "HangHoaId", "dbo.HangHoas");
            DropForeignKey("dbo.ChiTietPhieuNhaps", "HangHoaID", "dbo.HangHoas");
            DropForeignKey("dbo.HoaDons", "NhanVienId", "dbo.NhanViens");
            DropForeignKey("dbo.SanPhams", "LoaiSanPhamId", "dbo.LoaiSanPhams");
            DropForeignKey("dbo.ChiTietHoaDons", "SanPhamID", "dbo.SanPhams");
            DropForeignKey("dbo.ChiTietHoaDons", "HoaDonID", "dbo.HoaDons");
            DropForeignKey("dbo.HoaDons", "BanID", "dbo.Bans");
            DropIndex("dbo.TaiKhoans", new[] { "NhanVienID" });
            DropIndex("dbo.PhieuXuats", new[] { "NhanVienId" });
            DropIndex("dbo.ChiTietPhieuXuats", new[] { "HangHoaId" });
            DropIndex("dbo.ChiTietPhieuXuats", new[] { "PhieuXuatId" });
            DropIndex("dbo.ChiTietPhieuNhaps", new[] { "HangHoaID" });
            DropIndex("dbo.ChiTietPhieuNhaps", new[] { "PhieuNhapId" });
            DropIndex("dbo.PhieuNhaps", new[] { "NhanVienId" });
            DropIndex("dbo.PhieuNhaps", new[] { "NhaCungCapId" });
            DropIndex("dbo.SanPhams", new[] { "LoaiSanPhamId" });
            DropIndex("dbo.ChiTietHoaDons", new[] { "SanPhamID" });
            DropIndex("dbo.ChiTietHoaDons", new[] { "HoaDonID" });
            DropIndex("dbo.HoaDons", new[] { "BanID" });
            DropIndex("dbo.HoaDons", new[] { "NhanVienId" });
            DropTable("dbo.TaiKhoans");
            DropTable("dbo.NhaCungCaps");
            DropTable("dbo.PhieuXuats");
            DropTable("dbo.ChiTietPhieuXuats");
            DropTable("dbo.HangHoas");
            DropTable("dbo.ChiTietPhieuNhaps");
            DropTable("dbo.PhieuNhaps");
            DropTable("dbo.NhanViens");
            DropTable("dbo.LoaiSanPhams");
            DropTable("dbo.SanPhams");
            DropTable("dbo.ChiTietHoaDons");
            DropTable("dbo.HoaDons");
            DropTable("dbo.Bans");
        }
    }
}
