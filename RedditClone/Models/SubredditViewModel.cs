using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.Models
{
    public class SubredditViewModel
    {
        public SubredditViewModel()
        {
            Posts = new List<Post>();
        }

        public int? SubredditId { get; set; }
        public string SubredditName { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}