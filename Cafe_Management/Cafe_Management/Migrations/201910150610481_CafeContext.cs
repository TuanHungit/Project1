﻿namespace Cafe_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CafeContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bans",
                c => new
                    {
                        BanId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.BanId);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        HoaDonId = c.Int(nullable: false, identity: true),
                        NgayLap = c.DateTime(nullable: false),
                        NhanVienId = c.Int(nullable: false),
                        Ban_BanId = c.Int(),
                    })
                .PrimaryKey(t => t.HoaDonId)
                .ForeignKey("dbo.NhanViens", t => t.NhanVienId, cascadeDelete: true)
                .ForeignKey("dbo.Bans", t => t.Ban_BanId)
                .Index(t => t.NhanVienId)
                .Index(t => t.Ban_BanId);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        NhanVienId = c.Int(nullable: false, identity: true),
                        HoTenNV = c.String(),
                        SDT_NV = c.String(),
                        CMND = c.String(),
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
                        PhieuNhap_PhieuNhapId = c.Int(),
                    })
                .PrimaryKey(t => t.HangHoaId)
                .ForeignKey("dbo.PhieuNhaps", t => t.PhieuNhap_PhieuNhapId)
                .Index(t => t.PhieuNhap_PhieuNhapId);
            
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
                "dbo.SanPhamHoaDons",
                c => new
                {
                    SanPham_SanPhamId = c.Int(nullable: false),
                    HoaDon_HoaDonId = c.Int(nullable: false),
                    SoLuong = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.SanPham_SanPhamId, t.HoaDon_HoaDonId })
                .ForeignKey("dbo.SanPhams", t => t.SanPham_SanPhamId, cascadeDelete: true)
                .ForeignKey("dbo.HoaDons", t => t.HoaDon_HoaDonId, cascadeDelete: true)
                .Index(t => t.SanPham_SanPhamId)
                .Index(t => t.HoaDon_HoaDonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "Ban_BanId", "dbo.Bans");
            DropForeignKey("dbo.SanPhams", "LoaiSanPhamId", "dbo.LoaiSanPhams");
            DropForeignKey("dbo.SanPhamHoaDons", "HoaDon_HoaDonId", "dbo.HoaDons");
            DropForeignKey("dbo.SanPhamHoaDons", "SanPham_SanPhamId", "dbo.SanPhams");
            DropForeignKey("dbo.PhieuNhaps", "NhanVienId", "dbo.NhanViens");
            DropForeignKey("dbo.HangHoas", "PhieuNhap_PhieuNhapId", "dbo.PhieuNhaps");
            DropForeignKey("dbo.NhaCungCapHangHoas", "HangHoa_HangHoaId", "dbo.HangHoas");
            DropForeignKey("dbo.NhaCungCapHangHoas", "NhaCungCap_NhaCungCapId", "dbo.NhaCungCaps");
            DropForeignKey("dbo.HoaDons", "NhanVienId", "dbo.NhanViens");
            DropIndex("dbo.SanPhamHoaDons", new[] { "HoaDon_HoaDonId" });
            DropIndex("dbo.SanPhamHoaDons", new[] { "SanPham_SanPhamId" });
            DropIndex("dbo.NhaCungCapHangHoas", new[] { "HangHoa_HangHoaId" });
            DropIndex("dbo.NhaCungCapHangHoas", new[] { "NhaCungCap_NhaCungCapId" });
            DropIndex("dbo.SanPhams", new[] { "LoaiSanPhamId" });
            DropIndex("dbo.HangHoas", new[] { "PhieuNhap_PhieuNhapId" });
            DropIndex("dbo.PhieuNhaps", new[] { "NhanVienId" });
            DropIndex("dbo.HoaDons", new[] { "Ban_BanId" });
            DropIndex("dbo.HoaDons", new[] { "NhanVienId" });
            DropTable("dbo.SanPhamHoaDons");
            DropTable("dbo.NhaCungCapHangHoas");
            DropTable("dbo.LoaiSanPhams");
            DropTable("dbo.SanPhams");
            DropTable("dbo.NhaCungCaps");
            DropTable("dbo.HangHoas");
            DropTable("dbo.PhieuNhaps");
            DropTable("dbo.NhanViens");
            DropTable("dbo.HoaDons");
            DropTable("dbo.Bans");
        }
    }
}
