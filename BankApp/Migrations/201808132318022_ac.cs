namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ac : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "CustomerId", c => c.Int(nullable: false));
            DropColumn("dbo.Accounts", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "UserName", c => c.String(nullable: false, maxLength: 256));
            DropColumn("dbo.Accounts", "CustomerId");
        }
    }
}
