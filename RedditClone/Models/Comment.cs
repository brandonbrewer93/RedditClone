using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.Models
{
    public class Comment
    {
        public Comment()
        {
            Comments = new List<Comment>();
        }

        public int CommentId { get; set; }
        public string CommentBody { get; set; }
        public DateTime Date { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public ICollection<Comment> Comments;
    }
}