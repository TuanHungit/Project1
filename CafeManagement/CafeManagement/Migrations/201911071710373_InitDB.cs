namespace CafeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanViens", "QueQuan", c => c.String());
            AddColumn("dbo.NhanViens", "Picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhanViens", "Picture");
            DropColumn("dbo.NhanViens", "QueQuan");
        }
    }
}
