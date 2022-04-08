namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeGraduatedUniMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "GraduatedUni_Id", c => c.Int());
            CreateIndex("dbo.Surveys", "GraduatedUni_Id");
            AddForeignKey("dbo.Surveys", "GraduatedUni_Id", "dbo.Universities", "Id");
            DropColumn("dbo.Surveys", "GraduatedUni");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Surveys", "GraduatedUni", c => c.String());
            DropForeignKey("dbo.Surveys", "GraduatedUni_Id", "dbo.Universities");
            DropIndex("dbo.Surveys", new[] { "GraduatedUni_Id" });
            DropColumn("dbo.Surveys", "GraduatedUni_Id");
        }
    }
}
