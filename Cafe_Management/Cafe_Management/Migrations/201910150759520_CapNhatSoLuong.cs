namespace Cafe_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CapNhatSoLuong : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SanPhamHoaDons", "SoLuong", c => c.Int(nullable: false));
            AddColumn("dbo.HangHoaPhieuNhaps", "SoLuong", c => c.Int(nullable: false));
            AddColumn("dbo.HangHoaPhieuNhaps", "DonGia", c => c.Double(nullable: false));
            AddColumn("dbo.NhaCungCapHangHoas", "SoLuong", c => c.Int(nullable: false));
            AddColumn("dbo.NhaCungCapHangHoas", "DonGia", c => c.Double(nullable: false));

        }

        public override void Down()
        {
            DropColumn("dbo.SanPhamHoaDons", "SoLuong");
            DropColumn("dbo.HangHoaPhieuNhaps", "SoLuong");
            DropColumn("dbo.HangHoaPhieuNhaps", "DonGia");
            DropColumn("dbo.NhaCungCapHangHoas", "SoLuong");
            DropColumn("dbo.NhaCungCapHangHoas", "DonGia");
        }
    }
}
