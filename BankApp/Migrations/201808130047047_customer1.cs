namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Customers");
            AddColumn("dbo.Customers", "CustomerId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "UserName", c => c.String(maxLength: 256));
            AddPrimaryKey("dbo.Customers", "CustomerId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "UserName", c => c.String(nullable: false, maxLength: 256));
            DropColumn("dbo.Customers", "CustomerId");
            AddPrimaryKey("dbo.Customers", "UserName");
        }
    }
}
