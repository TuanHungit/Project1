namespace CafeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CapNhatCacBang : DbMigration
    {
        public override void Up()
        {

            AddColumn("dbo.HangHoaPhieuNhaps", "SoLuong", c => c.Int(nullable: false));
            AddColumn("dbo.HangHoaPhieuNhaps", "DonGia", c => c.Double(nullable: false));
            AddColumn("dbo.SanPhamHoaDons", "SoLuong", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HangHoaPhieuNhaps", "SoLuong");
            DropColumn("dbo.HangHoaPhieuNhaps", "DonGia");
            DropColumn("dbo.SanPhamHoaDons", "SoLuong");
        }
    }
}
