namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class accoun : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "UserName", c => c.String(nullable: false, maxLength: 256));
            DropColumn("dbo.Accounts", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "CustomerId", c => c.String(nullable: false));
            DropColumn("dbo.Accounts", "UserName");
        }
    }
}
