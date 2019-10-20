namespace CafeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CapNhatNhanVien : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanViens", "ChucVu", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhanViens", "ChucVu");
        }
    }
}
