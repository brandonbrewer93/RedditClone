namespace RedditClone.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RedditClone.Models.RedditCloneContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RedditClone.Models.RedditCloneContext context)
        {
            context.Subreddits.AddOrUpdate(
                s => s.SubredditId,
                new Subreddit { SubredditId = 1, SubredditName = "Music", OwnerId = null},
                new Subreddit { SubredditId = 2, SubredditName = "Art", OwnerId = null },
                new Subreddit { SubredditId = 3, SubredditName = "Gaming", OwnerId = null },
                new Subreddit { SubredditId = 4, SubredditName = "News", OwnerId = null },
                new Subreddit { SubredditId = 5, SubredditName = "Science", OwnerId = null },
                new Subreddit { SubredditId = 6, SubredditName = "Funny", OwnerId = null }
            );

            context.Comments.AddOrUpdate(
                c => c.CommentId,
                new Comment { CommentId = 1, PostId = 1, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser"},
                new Comment { CommentId = 2, PostId = 1, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 3, PostId = 2, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 4, PostId = 2, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 5, PostId = 3, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 6, PostId = 3, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 7, PostId = 4, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 8, PostId = 4, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 9, PostId = 5, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 10, PostId = 5, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 11, PostId = 6, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 12, PostId = 6, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 13, PostId = 7, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 14, PostId = 7, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 15, PostId = 8, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 16, PostId = 8, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 17, PostId = 9, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 18, PostId = 9, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 19, PostId = 10, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 20, PostId = 10, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 21, PostId = 11, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 22, PostId = 11, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 23, PostId = 12, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 24, PostId = 12, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 25, PostId = 13, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 26, PostId = 13, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 27, PostId = 14, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 28, PostId = 14, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 29, PostId = 15, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 30, PostId = 15, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 31, PostId = 16, CommentBody = "Hodor. Hodor HODOR hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, hodor... Hodor hodor hodor. Hodor. Hodor. Hodor hodor, hodor. Hodor hodor. Hodor. Hodor hodor - hodor HODOR hodor, hodor hodor hodor! Hodor, hodor, hodor. Hodor hodor, hodor. Hodor hodor?! Hodor, hodor. Hodor. Hodor, hodor, hodor. Hodor hodor. Hodor. Hodor, hodor... Hodor hodor hodor hodor, hodor, hodor hodor.", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" },
                new Comment { CommentId = 32, PostId = 16, CommentBody = "Hodor hodor HODOR! Hodor hodor, hodor. Hodor hodor? Hodor, hodor hodor? Hodor, hodor. Hodor. Hodor, HODOR hodor, hodor HODOR hodor, hodor hodor? Hodor. Hodor HODOR hodor, hodor hodor hodor... Hodor hodor hodor. Hodor. Hodor hodor HODOR! Hodor hodor hodor hodor hodor hodor, hodor, hodor hodor. Hodor hodor hodor hodor?!", Date = DateTime.Now, OwnerId = null, OwnerUserName = "SeedUser" }
            );

            context.Posts.AddOrUpdate(
                p => p.PostId,
                new Post
                {
                    PostId = 1,
                    SubredditId = 1,
                    Title = "I'm speechless. I have no speech.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media1.giphy.com/media/12UlfHpF05ielO/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 2,
                    SubredditId = 1,
                    Title = "Hello, Jerry.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media2.giphy.com/media/6Q2KA5ly49368/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 3,
                    SubredditId = 1,
                    Title = "These pretzels are making me thirsty.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media2.giphy.com/media/C767ptzM7gdUc/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 4,
                    SubredditId = 1,
                    Title = "Hi, my name is George, I'm unemployed and I live with my parents.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media2.giphy.com/media/LpLd2NGvpaiys/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 5,
                    SubredditId = 2,
                    Title = "Little Jerry Seinfeld. Yeah I named my chicken after you.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media1.giphy.com/media/Av0OHEGtZPLSo/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 6,
                    SubredditId = 2,
                    Title = "You very bad man, Jerry. Very bad man.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media1.giphy.com/media/xT1XGXgtj8PWdvCLFS/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 7,
                    SubredditId = 2,
                    Title = "It became very clear to me sitting out there today that every decision I've made in my entire life has been wrong. ",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media3.giphy.com/media/w5nIdIQUB1A4M/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 8,
                    SubredditId = 2,
                    Title = "Hello, Newman.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media1.giphy.com/media/11vsrRFqhjOcKI/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 9,
                    SubredditId = 3,
                    Title = "You’re through, Soup Nazi. Pack it up. No more soup for you. Next!",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media1.giphy.com/media/12tq3FwypcSSvS/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 10,
                    SubredditId = 3,
                    Title = "I want to make a good entrance. I never make good entrances.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media1.giphy.com/media/9NTfxeLPpgRUI/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 11,
                    SubredditId = 3,
                    Title = "I don't think I've ever been to an appointment in my life where I wanted the other guy to show up.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media2.giphy.com/media/1UBEgUWneaVVu/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 12,
                    SubredditId = 3,
                    Title = "Jerry, just remember, it's not a lie if you believe it.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media1.giphy.com/media/13xHqoOQOdFu5a/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 13,
                    SubredditId = 4,
                    Title = "You know we're living in a society!",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media0.giphy.com/media/3o7TKUM3IgJBX2as9O/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 14,
                    SubredditId = 4,
                    Title = "I gotta focus. I'm shifting into soup mode.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media3.giphy.com/media/14dXclYKbx2ONW/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 15,
                    SubredditId = 4,
                    Title = "Just remember, when you control the mail, you control... information.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media2.giphy.com/media/13Zh9drdSWAeSQ/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 16,
                    SubredditId = 4,
                    Title = "See, this is what the holidays are all about. Three buddies sitting around chewing gum.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media3.giphy.com/media/QWrClN3mlYtHO/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 17,
                    SubredditId = 5,
                    Title = "Are you telling me there’s not one condo available in all of Del Boca Vista?",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media0.giphy.com/media/bYtldoS45Mvfi/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 18,
                    SubredditId = 5,
                    Title = "You know I always wanted to pretend I was an architect.",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media0.giphy.com/media/bP2bOuWDpVM7C/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 19,
                    SubredditId = 5,
                    Title = "Yo Yo Ma",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media1.giphy.com/media/PlyIt4cqmZz56/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                },
                new Post
                {
                    PostId = 20,
                    SubredditId = 5,
                    Title = "You know what they say, ‘You don’t sell the steak, you sell the sizzle.’",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin laoreet purus, congue feugiat dolor finibus eu. Pellentesque gravida est at magna cursus congue. Vestibulum feugiat nulla ut ullamcorper venenatis. Ut molestie sagittis lacus, ut maximus enim maximus eget. Etiam ornare consequat enim, id tempus ligula ultrices eget. Vestibulum sed convallis nisl, vitae interdum nulla. Duis quis ligula nec risus sagittis condimentum vel ac nunc. Donec dui augue, pretium sollicitudin leo quis, molestie iaculis massa. Mauris condimentum orci blandit dui ullamcorper, dictum maximus urna accumsan. Donec porta fringilla mattis. Nullam sed ipsum sollicitudin eros maximus faucibus a ut ligula. Suspendisse potenti. Maecenas sed mattis velit, ut rhoncus nulla. Nulla vitae orci accumsan, dapibus ex sed, ultricies leo. Suspendisse feugiat, eros molestie vulputate rhoncus, arcu ante molestie lectus, ut auctor turpis ex vitae lectus.",
                    ImageLink = "https://media0.giphy.com/media/jFJW3hOGQgTUk/200w.webp",
                    Date = DateTime.Now,
                    OwnerId = null,
                    OwnerUserName = "SeedUser"
                }

            );
        }
    }
}
