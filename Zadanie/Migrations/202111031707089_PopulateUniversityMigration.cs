namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUniversityMigration : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UNIVERSITIES (Name) VALUES ('Politechnika Poznanska')");
            Sql("INSERT INTO UNIVERSITIES (Name) VALUES ('Uniwersytet Ekonomiczny')");
            Sql("INSERT INTO UNIVERSITIES (Name) VALUES ('Nie ukonczono uczelni wyzszej')");
        }
        
        public override void Down()
        {
        }
    }
}
