namespace CeeLearnAndDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Questions", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Questions", "Date", c => c.DateTime(nullable: false));
        }
    }
}
