namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniIdMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "GraduatedUniId", c => c.Byte(nullable: false));
            AddColumn("dbo.Surveys", "FacultyId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Surveys", "GraduatedUni", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Surveys", "GraduatedUni", c => c.String(nullable: false));
            DropColumn("dbo.Surveys", "FacultyId");
            DropColumn("dbo.Surveys", "GraduatedUniId");
        }
    }
}
