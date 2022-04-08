namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGradeToSurveyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "Grade", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Surveys", "Grade");
        }
    }
}
