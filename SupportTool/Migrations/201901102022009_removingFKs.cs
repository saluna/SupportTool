namespace SupportTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removingFKs : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ClientDetails", name: "ClientID", newName: "Clients_ClientID");
            RenameIndex(table: "dbo.ClientDetails", name: "IX_ClientID", newName: "IX_Clients_ClientID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ClientDetails", name: "IX_Clients", newName: "IX_ClientID_ClientID");
            RenameColumn(table: "dbo.ClientDetails", name: "Clients", newName: "ClientID_ClientID");
        }
    }
}
