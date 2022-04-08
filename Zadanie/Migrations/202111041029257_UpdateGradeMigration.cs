namespace Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGradeMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Surveys", "Grade", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Surveys", "Grade", c => c.Double(nullable: false));
        }
    }
}
