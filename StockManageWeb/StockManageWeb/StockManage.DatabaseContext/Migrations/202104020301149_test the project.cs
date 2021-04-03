namespace StockManage.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testtheproject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 150),
                        Email = c.String(),
                        Contact = c.String(nullable: false),
                        Loyalty = c.Int(nullable: false),
                        Data = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderRemarks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PurchaseID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Discription = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Purchases", t => t.PurchaseID, cascadeDelete: true)
                .Index(t => t.PurchaseID);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SupplierID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        invoiceNo = c.String(),
                        ProductID = c.Int(nullable: false),
                        manufactureDate = c.DateTime(nullable: false),
                        expireDate = c.DateTime(nullable: false),
                        remarks = c.String(nullable: false),
                        quantity = c.Int(nullable: false),
                        unitPrice = c.Int(nullable: false),
                        totalPrice = c.Int(nullable: false),
                        newMRP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierID, cascadeDelete: true)
                .Index(t => t.SupplierID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 50),
                        ReorderLevel = c.Int(nullable: false),
                        Discription = c.String(nullable: false, maxLength: 50),
                        Data = c.Binary(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 150),
                        Email = c.String(nullable: false, maxLength: 20),
                        Contact = c.String(nullable: false, maxLength: 50),
                        ContactPerson = c.String(nullable: false, maxLength: 50),
                        Data = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        date = c.DateTime(nullable: false),
                        PurchaseID = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                        MRP = c.Int(nullable: false),
                        TotalMRP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Purchases", t => t.PurchaseID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.PurchaseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "PurchaseID", "dbo.Purchases");
            DropForeignKey("dbo.Sales", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.OrderRemarks", "PurchaseID", "dbo.Purchases");
            DropForeignKey("dbo.Purchases", "SupplierID", "dbo.Suppliers");
            DropForeignKey("dbo.Purchases", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Sales", new[] { "PurchaseID" });
            DropIndex("dbo.Sales", new[] { "CustomerID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.Purchases", new[] { "ProductID" });
            DropIndex("dbo.Purchases", new[] { "SupplierID" });
            DropIndex("dbo.OrderRemarks", new[] { "PurchaseID" });
            DropTable("dbo.Sales");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
            DropTable("dbo.Purchases");
            DropTable("dbo.OrderRemarks");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
