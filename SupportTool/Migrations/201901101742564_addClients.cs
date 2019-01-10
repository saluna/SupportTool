namespace SupportTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addClients : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Clients ( ClientID, ClientName, Hosted, PGo ) values ('0001', 'GI731', 1, 0)");
            Sql("INSERT INTO Clients ( ClientID, ClientName, Hosted, PGo ) values ('0002', 'GI740', 1, 0)");
            Sql("INSERT INTO Clients ( ClientID, ClientName, Hosted, PGo ) values ('0003', 'GI741', 1, 0)");
            Sql("INSERT INTO Clients ( ClientID, ClientName, Hosted, PGo ) values ('0004', 'GI742', 1, 0)");
            Sql("INSERT INTO Clients ( ClientID, ClientName, Hosted, PGo ) values ('0005', 'GI750', 1, 0)");
            Sql("INSERT INTO Clients ( ClientID, ClientName, Hosted, PGo ) values ('0006', 'GI751', 1, 0)");
            Sql("INSERT INTO Clients ( ClientID, ClientName, Hosted, PGo ) values ('0007', 'GI752', 1, 0)");
            Sql("INSERT INTO Clients ( ClientID, ClientName, Hosted, PGo ) values ('0008', 'GI760', 1, 0)");
            Sql("INSERT INTO Clients ( ClientID, ClientName, Hosted, PGo ) values ('0009', 'GI761', 1, 0)");
            Sql("INSERT INTO Clients ( ClientID, ClientName, Hosted, PGo ) values ('0010', 'GI762', 1, 0)");
        }

        public override void Down()
        {
            Sql("DELETE FROM Client WHERE ClientID in ('0001','0002','0003','0004','0005','0006','0007','0008','0009','00010')");
        }
    }
}
