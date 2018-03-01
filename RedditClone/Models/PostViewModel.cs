using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.Models
{
    public class PostViewModel
    {
        public PostViewModel()
        {
            Comments = new List<Comment>();
        }

        public int? PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImageLink { get; set; }
        public DateTime Date { get; set; }

        public int SubredditId { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}