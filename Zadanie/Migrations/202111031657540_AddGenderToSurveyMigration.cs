namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderToSurveyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "Gender_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Surveys", "Gender_Id");
            AddForeignKey("dbo.Surveys", "Gender_Id", "dbo.Genders", "Id", cascadeDelete: true);
            DropColumn("dbo.Surveys", "Sex");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Surveys", "Sex", c => c.String(nullable: false));
            DropForeignKey("dbo.Surveys", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Surveys", new[] { "Gender_Id" });
            DropColumn("dbo.Surveys", "Gender_Id");
        }
    }
}
