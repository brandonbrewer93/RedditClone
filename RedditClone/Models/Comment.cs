﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditClone.Models
{

    // Comment data model.
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentBody { get; set; }
        public DateTime Date { get; set; }

        public string OwnerId { get; set; }
        public string OwnerUserName { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}