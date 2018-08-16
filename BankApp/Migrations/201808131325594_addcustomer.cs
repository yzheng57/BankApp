namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        TransTypeId = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            AddColumn("dbo.Customers", "AccountNumber", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AddColumn("dbo.Customers", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "CustomerId" });
            DropColumn("dbo.Customers", "Balance");
            DropColumn("dbo.Customers", "AccountNumber");
            DropTable("dbo.Transactions");
        }
    }
}
