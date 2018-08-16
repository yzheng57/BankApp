namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xfgh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "accounttype1", c => c.String());
            DropColumn("dbo.Accounts", "AccountTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "AccountTypeId", c => c.String());
            DropColumn("dbo.Accounts", "accounttype1");
        }
    }
}
