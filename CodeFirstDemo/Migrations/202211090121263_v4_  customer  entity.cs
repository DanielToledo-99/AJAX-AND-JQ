namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4_customerentity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        InvoiceDetailID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        SellerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceDetailID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SellerID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.SellerID);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        SellerId = c.Int(nullable: false, identity: true),
                        SellerName = c.String(),
                        LastName = c.String(),
                        SellerContact = c.String(),
                    })
                .PrimaryKey(t => t.SellerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceDetails", "SellerID", "dbo.Sellers");
            DropForeignKey("dbo.InvoiceDetails", "CustomerID", "dbo.Customers");
            DropIndex("dbo.InvoiceDetails", new[] { "SellerID" });
            DropIndex("dbo.InvoiceDetails", new[] { "CustomerID" });
            DropTable("dbo.Sellers");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.Customers");
        }
    }
}
