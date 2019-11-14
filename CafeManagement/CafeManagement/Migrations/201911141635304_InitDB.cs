namespace CafeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TonKhoes", "HangHoaID", "dbo.HangHoas");
            DropIndex("dbo.TonKhoes", new[] { "HangHoaID" });
            AddColumn("dbo.HangHoas", "SoLuongTon", c => c.Int(nullable: false));
            DropTable("dbo.TonKhoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TonKhoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HangHoaID = c.Int(nullable: false),
                        SoLuongTon = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.HangHoas", "SoLuongTon");
            CreateIndex("dbo.TonKhoes", "HangHoaID");
            AddForeignKey("dbo.TonKhoes", "HangHoaID", "dbo.HangHoas", "HangHoaId", cascadeDelete: true);
        }
    }
}
