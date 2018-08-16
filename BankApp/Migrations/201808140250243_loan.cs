namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class loan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        LoanId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        CreatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.LoanId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Loans");
        }
    }
}
