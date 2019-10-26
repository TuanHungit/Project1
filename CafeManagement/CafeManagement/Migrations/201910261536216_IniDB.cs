namespace CafeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IniDB : DbMigration
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
                        HoaDonID = c.Int(nullable: false),
                        SanPhamID = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.HoaDonID, t.SanPhamID })
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
                        ChucVu = c.String(),
                        SDT_NV = c.String(),
                        CMND = c.Int(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        NgayVaoLam = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NhanVienId);
            
            CreateTable(
                "dbo.PhieuNhaps",
                c => new
                    {
                        PhieuNhapId = c.Int(nullable: false, identity: true),
                        NgayLap = c.DateTime(nullable: false),
                        NhanVienId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhieuNhapId)
                .ForeignKey("dbo.NhanViens", t => t.NhanVienId, cascadeDelete: true)
                .Index(t => t.NhanVienId);
            
            CreateTable(
                "dbo.HangHoas",
                c => new
                    {
                        HangHoaId = c.Int(nullable: false, identity: true),
                        TenHangHoa = c.String(),
                        DonGia = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.HangHoaId);
            
            CreateTable(
                "dbo.NhaCungCaps",
                c => new
                    {
                        NhaCungCapId = c.Int(nullable: false, identity: true),
                        TenNhaCungCap = c.String(),
                        SDT = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.NhaCungCapId);
            
            CreateTable(
                "dbo.NhaCungCapHangHoas",
                c => new
                    {
                        NhaCungCap_NhaCungCapId = c.Int(nullable: false),
                        HangHoa_HangHoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.NhaCungCap_NhaCungCapId, t.HangHoa_HangHoaId })
                .ForeignKey("dbo.NhaCungCaps", t => t.NhaCungCap_NhaCungCapId, cascadeDelete: true)
                .ForeignKey("dbo.HangHoas", t => t.HangHoa_HangHoaId, cascadeDelete: true)
                .Index(t => t.NhaCungCap_NhaCungCapId)
                .Index(t => t.HangHoa_HangHoaId);
            
            CreateTable(
                "dbo.HangHoaPhieuNhaps",
                c => new
                    {
                        HangHoa_HangHoaId = c.Int(nullable: false),
                        PhieuNhap_PhieuNhapId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.HangHoa_HangHoaId, t.PhieuNhap_PhieuNhapId })
                .ForeignKey("dbo.HangHoas", t => t.HangHoa_HangHoaId, cascadeDelete: true)
                .ForeignKey("dbo.PhieuNhaps", t => t.PhieuNhap_PhieuNhapId, cascadeDelete: true)
                .Index(t => t.HangHoa_HangHoaId)
                .Index(t => t.PhieuNhap_PhieuNhapId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhieuNhaps", "NhanVienId", "dbo.NhanViens");
            DropForeignKey("dbo.HangHoaPhieuNhaps", "PhieuNhap_PhieuNhapId", "dbo.PhieuNhaps");
            DropForeignKey("dbo.HangHoaPhieuNhaps", "HangHoa_HangHoaId", "dbo.HangHoas");
            DropForeignKey("dbo.NhaCungCapHangHoas", "HangHoa_HangHoaId", "dbo.HangHoas");
            DropForeignKey("dbo.NhaCungCapHangHoas", "NhaCungCap_NhaCungCapId", "dbo.NhaCungCaps");
            DropForeignKey("dbo.HoaDons", "NhanVienId", "dbo.NhanViens");
            DropForeignKey("dbo.SanPhams", "LoaiSanPhamId", "dbo.LoaiSanPhams");
            DropForeignKey("dbo.ChiTietHoaDons", "SanPhamID", "dbo.SanPhams");
            DropForeignKey("dbo.ChiTietHoaDons", "HoaDonID", "dbo.HoaDons");
            DropForeignKey("dbo.HoaDons", "BanID", "dbo.Bans");
            DropIndex("dbo.HangHoaPhieuNhaps", new[] { "PhieuNhap_PhieuNhapId" });
            DropIndex("dbo.HangHoaPhieuNhaps", new[] { "HangHoa_HangHoaId" });
            DropIndex("dbo.NhaCungCapHangHoas", new[] { "HangHoa_HangHoaId" });
            DropIndex("dbo.NhaCungCapHangHoas", new[] { "NhaCungCap_NhaCungCapId" });
            DropIndex("dbo.PhieuNhaps", new[] { "NhanVienId" });
            DropIndex("dbo.SanPhams", new[] { "LoaiSanPhamId" });
            DropIndex("dbo.ChiTietHoaDons", new[] { "SanPhamID" });
            DropIndex("dbo.ChiTietHoaDons", new[] { "HoaDonID" });
            DropIndex("dbo.HoaDons", new[] { "BanID" });
            DropIndex("dbo.HoaDons", new[] { "NhanVienId" });
            DropTable("dbo.HangHoaPhieuNhaps");
            DropTable("dbo.NhaCungCapHangHoas");
            DropTable("dbo.NhaCungCaps");
            DropTable("dbo.HangHoas");
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
