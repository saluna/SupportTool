namespace SupportTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editClientDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientDetails", "prod", c => c.Byte(nullable: false));
            AddColumn("dbo.ClientDetails", "envType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClientDetails", "envType");
            DropColumn("dbo.ClientDetails", "prod");
        }
    }
}
