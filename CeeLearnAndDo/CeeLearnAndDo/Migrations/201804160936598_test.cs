namespace CeeLearnAndDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Answers", new[] { "User_Id" });
            DropIndex("dbo.Articles", new[] { "User_Id" });
            DropColumn("dbo.Answers", "UserId");
            DropColumn("dbo.Articles", "UserId");
            RenameColumn(table: "dbo.Answers", name: "User_Id", newName: "UserId");
            RenameColumn(table: "dbo.Articles", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Answers", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Answers", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Questions", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Questions", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Articles", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Articles", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Articles", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Answers", "UserId");
            CreateIndex("dbo.Articles", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Articles", new[] { "UserId" });
            DropIndex("dbo.Answers", new[] { "UserId" });
            AlterColumn("dbo.Articles", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Articles", "Content", c => c.String());
            AlterColumn("dbo.Articles", "Title", c => c.String());
            AlterColumn("dbo.Questions", "Content", c => c.String());
            AlterColumn("dbo.Questions", "Title", c => c.String());
            AlterColumn("dbo.Answers", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Answers", "Content", c => c.String());
            RenameColumn(table: "dbo.Articles", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.Answers", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Articles", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Answers", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Articles", "User_Id");
            CreateIndex("dbo.Answers", "User_Id");
        }
    }
}
