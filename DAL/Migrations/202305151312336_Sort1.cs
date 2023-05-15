namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sort1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.OrderDetails", "ShopId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderDetails", "ShopId", c => c.Int(nullable: false));
        }
    }
}
