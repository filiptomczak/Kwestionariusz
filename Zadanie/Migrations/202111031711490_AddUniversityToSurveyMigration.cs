namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniversityToSurveyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "GraduatedUni", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Surveys", "GraduatedUni");
        }
    }
}
