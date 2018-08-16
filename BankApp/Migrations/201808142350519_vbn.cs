namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vbn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransTypes", "TransactionId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TransTypes", "TransactionId");
        }
    }
}
