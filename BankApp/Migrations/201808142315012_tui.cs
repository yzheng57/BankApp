namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tui : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "TransTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "TransTypeId", c => c.String());
        }
    }
}
