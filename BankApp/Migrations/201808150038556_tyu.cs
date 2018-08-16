namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tyu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "AccountId", c => c.Int(nullable: false));
            AlterColumn("dbo.Transactions", "CreatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "CreatedOn", c => c.DateTime());
            DropColumn("dbo.Transactions", "AccountId");
        }
    }
}
