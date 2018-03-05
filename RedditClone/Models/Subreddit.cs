using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.Models
{
    public class Subreddit
    {
        public Subreddit()
        {
            Posts = new List<Post>();
        }

        public int SubredditId { get; set; }
        public string SubredditName { get; set; }

        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}