namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hdsjk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TermDeposits",
                c => new
                    {
                        DepositId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DepositId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TermDeposits");
        }
    }
}
