namespace CeeLearnAndDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Awnser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "Awnser");
        }
    }
}
