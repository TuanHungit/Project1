namespace Cafe_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCMNDNhanVien : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NhanViens", "CMND", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NhanViens", "CMND", c => c.String());
        }
    }
}
