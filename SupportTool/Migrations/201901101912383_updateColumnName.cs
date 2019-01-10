namespace SupportTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateColumnName : DbMigration
    {
        public override void Up()
        {
            Sql(
                "insert into ClientDetails (clientID, EnvTitle, EnvDetails, envUsername, envPassword) values ('0001','P360 Launcher','P:\\Customer Support\\Universal Launcher','admin','admin123')");
        }
        
        public override void Down()
        {
            Sql("delete from ClientDetails where clientID = '0001'");
        }
    }
}
