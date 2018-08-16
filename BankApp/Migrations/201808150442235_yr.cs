namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "AccountTypeId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "AccountTypeId", c => c.String(nullable: false));
        }
    }
}
