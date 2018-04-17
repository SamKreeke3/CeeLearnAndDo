namespace CeeLearnAndDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Answertekst : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Answer", c => c.String());
            DropColumn("dbo.Questions", "Awnser");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "Awnser", c => c.String());
            DropColumn("dbo.Questions", "Answer");
        }
    }
}
