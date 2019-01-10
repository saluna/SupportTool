namespace SupportTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeColumnTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Hosted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Clients", "PGo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "PGo", c => c.Byte(nullable: false));
            AlterColumn("dbo.Clients", "Hosted", c => c.Byte(nullable: false));
        }
    }
}
