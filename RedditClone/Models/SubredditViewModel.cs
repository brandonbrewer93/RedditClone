using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.Models
{
    // Subreddit view model. Contains necessary data for views.
    public class SubredditViewModel
    {
        public SubredditViewModel()
        {
            Posts = new List<Post>();
        }

        public int? SubredditId { get; set; }
        public string SubredditName { get; set; }

        public string OwnerId { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}