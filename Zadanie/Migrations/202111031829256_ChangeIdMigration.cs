namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIdMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Surveys", "Faculty_Id", "dbo.Faculties");
            DropForeignKey("dbo.Surveys", "GraduatedUni_Id", "dbo.Universities");
            DropIndex("dbo.Surveys", new[] { "Faculty_Id" });
            DropIndex("dbo.Surveys", new[] { "GraduatedUni_Id" });
            AddColumn("dbo.Surveys", "Faculty_Id1", c => c.Int());
            AddColumn("dbo.Surveys", "GraduatedUni_Id1", c => c.Int());
            AlterColumn("dbo.Surveys", "Faculty_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Surveys", "GraduatedUni_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Surveys", "Faculty_Id1");
            CreateIndex("dbo.Surveys", "GraduatedUni_Id1");
            AddForeignKey("dbo.Surveys", "Faculty_Id1", "dbo.Faculties", "Id");
            AddForeignKey("dbo.Surveys", "GraduatedUni_Id1", "dbo.Universities", "Id");
            DropColumn("dbo.Surveys", "GraduatedUniId");
            DropColumn("dbo.Surveys", "FacultyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Surveys", "FacultyId", c => c.Byte(nullable: false));
            AddColumn("dbo.Surveys", "GraduatedUniId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Surveys", "GraduatedUni_Id1", "dbo.Universities");
            DropForeignKey("dbo.Surveys", "Faculty_Id1", "dbo.Faculties");
            DropIndex("dbo.Surveys", new[] { "GraduatedUni_Id1" });
            DropIndex("dbo.Surveys", new[] { "Faculty_Id1" });
            AlterColumn("dbo.Surveys", "GraduatedUni_Id", c => c.Int());
            AlterColumn("dbo.Surveys", "Faculty_Id", c => c.Int());
            DropColumn("dbo.Surveys", "GraduatedUni_Id1");
            DropColumn("dbo.Surveys", "Faculty_Id1");
            CreateIndex("dbo.Surveys", "GraduatedUni_Id");
            CreateIndex("dbo.Surveys", "Faculty_Id");
            AddForeignKey("dbo.Surveys", "GraduatedUni_Id", "dbo.Universities", "Id");
            AddForeignKey("dbo.Surveys", "Faculty_Id", "dbo.Faculties", "Id");
        }
    }
}
