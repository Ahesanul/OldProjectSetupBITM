namespace OnlineShopWebApp.MyContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        ProductName = c.String(),
                        ReOrderQuantity = c.Int(),
                        Description = c.String(),
                        CategoryID = c.Int(),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(),
                        OrderDate = c.DateTime(),
                        InvoiceNo = c.String(),
                        SupplierID = c.Int(),
                        ManufacturedDate = c.DateTime(),
                        ExpireDate = c.DateTime(),
                        Quantity = c.Int(),
                        UnitPrice = c.Double(),
                        Remark = c.String(),
                        MRP = c.Int(),
                        CustomerID = c.Int(),
                        Status = c.String(),
                        SalesDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .ForeignKey("dbo.Suppliers", t => t.SupplierID)
                .Index(t => t.ProductID)
                .Index(t => t.SupplierID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.Int(),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        Point = c.Int(),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.Int(),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        ContactPerson = c.String(),
                        Logo = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "SupplierID", "dbo.Suppliers");
            DropForeignKey("dbo.Stocks", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Stocks", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Stocks", new[] { "CustomerID" });
            DropIndex("dbo.Stocks", new[] { "SupplierID" });
            DropIndex("dbo.Stocks", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.Users");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Customers");
            DropTable("dbo.Stocks");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
