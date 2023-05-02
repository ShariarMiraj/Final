namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPO : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "productby", newName: "ProductId");
            RenameIndex(table: "dbo.Orders", name: "IX_productby", newName: "IX_ProductId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Orders", name: "IX_ProductId", newName: "IX_productby");
            RenameColumn(table: "dbo.Orders", name: "ProductId", newName: "productby");
        }
    }
}
