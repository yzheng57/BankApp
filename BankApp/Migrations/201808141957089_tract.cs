namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tract : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransTypes",
                c => new
                    {
                        TranstypeId = c.Int(nullable: false, identity: true),
                        TransName = c.String(),
                    })
                .PrimaryKey(t => t.TranstypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TransTypes");
        }
    }
}
