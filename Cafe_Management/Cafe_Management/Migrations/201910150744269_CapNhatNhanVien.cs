namespace Cafe_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CapNhatNhanVien : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HangHoas", "PhieuNhap_PhieuNhapId", "dbo.PhieuNhaps");
            DropIndex("dbo.HangHoas", new[] { "PhieuNhap_PhieuNhapId" });
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
            
            AddColumn("dbo.NhanViens", "Tien", c => c.Int(nullable: false));
            DropColumn("dbo.HangHoas", "PhieuNhap_PhieuNhapId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HangHoas", "PhieuNhap_PhieuNhapId", c => c.Int());
            DropForeignKey("dbo.HangHoaPhieuNhaps", "PhieuNhap_PhieuNhapId", "dbo.PhieuNhaps");
            DropForeignKey("dbo.HangHoaPhieuNhaps", "HangHoa_HangHoaId", "dbo.HangHoas");
            DropIndex("dbo.HangHoaPhieuNhaps", new[] { "PhieuNhap_PhieuNhapId" });
            DropIndex("dbo.HangHoaPhieuNhaps", new[] { "HangHoa_HangHoaId" });
            DropColumn("dbo.NhanViens", "Tien");
            DropTable("dbo.HangHoaPhieuNhaps");
            CreateIndex("dbo.HangHoas", "PhieuNhap_PhieuNhapId");
            AddForeignKey("dbo.HangHoas", "PhieuNhap_PhieuNhapId", "dbo.PhieuNhaps", "PhieuNhapId");
        }
    }
}
