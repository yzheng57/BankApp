namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TermDeposits", "Years", c => c.Int(nullable: false));
            AddColumn("dbo.TermDeposits", "rate", c => c.Double(nullable: false));
            AddColumn("dbo.TermDeposits", "interest", c => c.Double(nullable: false));
            AddColumn("dbo.TermDeposits", "total_amt", c => c.Double(nullable: false));
            DropColumn("dbo.TermDeposits", "StartDate");
            DropColumn("dbo.TermDeposits", "EndDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TermDeposits", "EndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.TermDeposits", "StartDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.TermDeposits", "total_amt");
            DropColumn("dbo.TermDeposits", "interest");
            DropColumn("dbo.TermDeposits", "rate");
            DropColumn("dbo.TermDeposits", "Years");
        }
    }
}
