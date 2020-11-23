namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "FirstName", c => c.String());
            DropColumn("dbo.Orders", "FirstNme");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "FirstNme", c => c.String());
            DropColumn("dbo.Orders", "FirstName");
        }
    }
}
