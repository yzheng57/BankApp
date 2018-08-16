namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class account2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "AccountType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "AccountType", c => c.String(nullable: false));
        }
    }
}
