namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFacultyToSurveyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "Faculty_Id", c => c.Int());
            CreateIndex("dbo.Surveys", "Faculty_Id");
            AddForeignKey("dbo.Surveys", "Faculty_Id", "dbo.Faculties", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Surveys", "Faculty_Id", "dbo.Faculties");
            DropIndex("dbo.Surveys", new[] { "Faculty_Id" });
            DropColumn("dbo.Surveys", "Faculty_Id");
        }
    }
}
