namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateFacultyMigration : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Faculties (UniversityId, Name) VALUES (1, 'Automatyka i Robotyka')");
            Sql("INSERT INTO Faculties (UniversityId, Name) VALUES (1, 'Bioinformatyka')");
            Sql("INSERT INTO Faculties (UniversityId, Name) VALUES (1, 'Informatyka')");
            Sql("INSERT INTO Faculties (UniversityId, Name) VALUES (1, 'Fizyka Techhniczna')");
            Sql("INSERT INTO Faculties (UniversityId, Name) VALUES (1, 'Mechatronika')");


            Sql("INSERT INTO Faculties (UniversityId, Name) VALUES (2, 'Ekonomia')");
            Sql("INSERT INTO Faculties (UniversityId, Name) VALUES (2, 'Finanse i Rachunkowosc')");
            Sql("INSERT INTO Faculties (UniversityId, Name) VALUES (2, 'Informatyka i Ekonometria')");
            Sql("INSERT INTO Faculties (UniversityId, Name) VALUES (2, 'Zarzadzanie')");
            Sql("INSERT INTO Faculties (UniversityId, Name) VALUES (2, 'Uniwersytet Ekonomiczny')");

            Sql("INSERT INTO Faculties (UniversityId, Name) VALUES (3, '-')");

        }

        public override void Down()
        {
        }
    }
}
