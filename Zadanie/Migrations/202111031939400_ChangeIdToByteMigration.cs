namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIdToByteMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Surveys", "Faculty_Id1", "dbo.Faculties");
            DropForeignKey("dbo.Surveys", "GraduatedUni_Id1", "dbo.Universities");
            DropIndex("dbo.Surveys", new[] { "Faculty_Id1" });
            DropIndex("dbo.Surveys", new[] { "GraduatedUni_Id1" });
            DropColumn("dbo.Surveys", "Faculty_Id");
            DropColumn("dbo.Surveys", "GraduatedUni_Id");
            RenameColumn(table: "dbo.Surveys", name: "Faculty_Id1", newName: "Faculty_Id");
            RenameColumn(table: "dbo.Surveys", name: "GraduatedUni_Id1", newName: "GraduatedUni_Id");
            DropPrimaryKey("dbo.Faculties");
            DropPrimaryKey("dbo.Universities");
            AlterColumn("dbo.Faculties", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Surveys", "Faculty_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Surveys", "GraduatedUni_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Universities", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Faculties", "Id");
            AddPrimaryKey("dbo.Universities", "Id");
            CreateIndex("dbo.Surveys", "GraduatedUni_Id");
            CreateIndex("dbo.Surveys", "Faculty_Id");
            AddForeignKey("dbo.Surveys", "Faculty_Id", "dbo.Faculties", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Surveys", "GraduatedUni_Id", "dbo.Universities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Surveys", "GraduatedUni_Id", "dbo.Universities");
            DropForeignKey("dbo.Surveys", "Faculty_Id", "dbo.Faculties");
            DropIndex("dbo.Surveys", new[] { "Faculty_Id" });
            DropIndex("dbo.Surveys", new[] { "GraduatedUni_Id" });
            DropPrimaryKey("dbo.Universities");
            DropPrimaryKey("dbo.Faculties");
            AlterColumn("dbo.Universities", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Surveys", "GraduatedUni_Id", c => c.Int());
            AlterColumn("dbo.Surveys", "Faculty_Id", c => c.Int());
            AlterColumn("dbo.Faculties", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Universities", "Id");
            AddPrimaryKey("dbo.Faculties", "Id");
            RenameColumn(table: "dbo.Surveys", name: "GraduatedUni_Id", newName: "GraduatedUni_Id1");
            RenameColumn(table: "dbo.Surveys", name: "Faculty_Id", newName: "Faculty_Id1");
            AddColumn("dbo.Surveys", "GraduatedUni_Id", c => c.Byte(nullable: false));
            AddColumn("dbo.Surveys", "Faculty_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Surveys", "GraduatedUni_Id1");
            CreateIndex("dbo.Surveys", "Faculty_Id1");
            AddForeignKey("dbo.Surveys", "GraduatedUni_Id1", "dbo.Universities", "Id");
            AddForeignKey("dbo.Surveys", "Faculty_Id1", "dbo.Faculties", "Id");
        }
    }
}
