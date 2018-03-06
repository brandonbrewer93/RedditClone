namespace RedditClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOwnerToPostAndCommentEntities : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "OwnerId", c => c.String(maxLength: 128));
            AddColumn("dbo.Posts", "OwnerId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Comments", "OwnerId");
            CreateIndex("dbo.Posts", "OwnerId");
            AddForeignKey("dbo.Comments", "OwnerId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Posts", "OwnerId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "OwnerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "OwnerId", "dbo.AspNetUsers");
            DropIndex("dbo.Posts", new[] { "OwnerId" });
            DropIndex("dbo.Comments", new[] { "OwnerId" });
            DropColumn("dbo.Posts", "OwnerId");
            DropColumn("dbo.Comments", "OwnerId");
        }
    }
}
