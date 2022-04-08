namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgeToSurveyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Surveys", "Age");
        }
    }
}
