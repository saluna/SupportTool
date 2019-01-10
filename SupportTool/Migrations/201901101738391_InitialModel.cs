namespace SupportTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnvTitle = c.String(nullable: false),
                        EnvDetails = c.String(nullable: false),
                        envUsername = c.String(),
                        envPassword = c.String(),
                        ClientID = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientID)
                .Index(t => t.ClientID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientID = c.String(nullable: false, maxLength: 4),
                        ClientName = c.String(nullable: false),
                        ClientAcronym = c.String(),
                        Hosted = c.Byte(nullable: false),
                        PGo = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ClientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientDetails", "ClientID", "dbo.Clients");
            DropIndex("dbo.ClientDetails", new[] { "ClientID" });
            DropTable("dbo.Clients");
            DropTable("dbo.ClientDetails");
        }
    }
}
