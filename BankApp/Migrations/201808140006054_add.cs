namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "AccountType", c => c.String(nullable: false));
            AlterColumn("dbo.Accounts", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Status", c => c.Int(nullable: false));
            AlterColumn("dbo.Accounts", "AccountType", c => c.Int(nullable: false));
        }
    }
}
