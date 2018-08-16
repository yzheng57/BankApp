namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fuj : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Accounts", "AccountTypeId1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "AccountTypeId1", c => c.Int(nullable: false));
        }
    }
}
