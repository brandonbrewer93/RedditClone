namespace RedditClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOwnerToSubredditEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subreddits", "OwnerId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Subreddits", "OwnerId");
            AddForeignKey("dbo.Subreddits", "OwnerId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subreddits", "OwnerId", "dbo.AspNetUsers");
            DropIndex("dbo.Subreddits", new[] { "OwnerId" });
            DropColumn("dbo.Subreddits", "OwnerId");
        }
    }
}
