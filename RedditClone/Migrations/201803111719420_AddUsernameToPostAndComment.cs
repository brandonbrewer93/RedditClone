namespace RedditClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsernameToPostAndComment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "OwnerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Posts", "OwnerId", "dbo.AspNetUsers");
            DropIndex("dbo.Comments", new[] { "OwnerId" });
            DropIndex("dbo.Posts", new[] { "OwnerId" });
            AddColumn("dbo.Comments", "OwnerUserName", c => c.String());
            AddColumn("dbo.Posts", "OwnerUserName", c => c.String());
            AlterColumn("dbo.Comments", "OwnerId", c => c.String());
            AlterColumn("dbo.Posts", "OwnerId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "OwnerId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Comments", "OwnerId", c => c.String(maxLength: 128));
            DropColumn("dbo.Posts", "OwnerUserName");
            DropColumn("dbo.Comments", "OwnerUserName");
            CreateIndex("dbo.Posts", "OwnerId");
            CreateIndex("dbo.Comments", "OwnerId");
            AddForeignKey("dbo.Posts", "OwnerId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Comments", "OwnerId", "dbo.AspNetUsers", "Id");
        }
    }
}
