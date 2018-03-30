using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.Models
{
    // A list of subreddit view models.
    public class SubredditListViewModel
    {
        public List<SubredditViewModel> Subreddits { get; set; }
    }
}