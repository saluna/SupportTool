namespace SupportTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeColumnTypesClientDetails : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClientDetails", "prod", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClientDetails", "prod", c => c.Byte(nullable: false));
        }
    }
}
