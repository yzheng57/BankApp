namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eret : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TermDeposits", "Months", c => c.Int(nullable: false));
            DropColumn("dbo.TermDeposits", "Years");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TermDeposits", "Years", c => c.Int(nullable: false));
            DropColumn("dbo.TermDeposits", "Months");
        }
    }
}
