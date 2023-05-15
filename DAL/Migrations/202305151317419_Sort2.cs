namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sort2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.OrderDetails", name: "SellerId", newName: "SelleBy");
            RenameIndex(table: "dbo.OrderDetails", name: "IX_SellerId", newName: "IX_SelleBy");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.OrderDetails", name: "IX_SelleBy", newName: "IX_SellerId");
            RenameColumn(table: "dbo.OrderDetails", name: "SelleBy", newName: "SellerId");
        }
    }
}
