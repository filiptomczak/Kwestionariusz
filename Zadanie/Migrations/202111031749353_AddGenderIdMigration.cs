namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderIdMigration : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Surveys", name: "Gender_Id", newName: "GenderId");
            RenameIndex(table: "dbo.Surveys", name: "IX_Gender_Id", newName: "IX_GenderId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Surveys", name: "IX_GenderId", newName: "IX_Gender_Id");
            RenameColumn(table: "dbo.Surveys", name: "GenderId", newName: "Gender_Id");
        }
    }
}
