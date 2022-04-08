namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenderMigration : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENDERS (Id, Name) VALUES (1, 'FEMALE')");
            Sql("INSERT INTO GENDERS (Id, Name) VALUES (2, 'MALE')");
        }
        
        public override void Down()
        {
        }
    }
}
