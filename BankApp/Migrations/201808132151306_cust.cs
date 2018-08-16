namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cust : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "CustomerId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "CustomerId", c => c.Int(nullable: false));
        }
    }
}
