namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class account3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Status", c => c.Boolean(nullable: false));
        }
    }
}
