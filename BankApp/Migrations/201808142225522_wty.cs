namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "AccountTypeId1", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "AccountTypeId1");
        }
    }
}
