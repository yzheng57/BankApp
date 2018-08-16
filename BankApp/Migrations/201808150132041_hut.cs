namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hut : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loans", "Year", c => c.Int(nullable: false));
            AddColumn("dbo.TermDeposits", "StartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.TermDeposits", "EndDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.TermDeposits", "ModifiedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TermDeposits", "ModifiedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.TermDeposits", "EndDate");
            DropColumn("dbo.TermDeposits", "StartDate");
            DropColumn("dbo.Loans", "Year");
        }
    }
}
