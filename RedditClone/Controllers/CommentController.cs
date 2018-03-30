using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using RedditClone.Models;

namespace RedditClone.Controllers
{
    public class CommentController : Controller
    {
        [HttpPost]
        [Authorize]
        public ActionResult AddComment(Comment newComment)
        {
            // Get the PostId that the comment will be attached to in order
            // to redirect back to the correct post.
            var postId = newComment.PostId;
            
            using (var redditCloneContext = new RedditCloneContext())
            {
                // Build a new comment to store in the database
                var comment = new Comment
                {
                    CommentBody = newComment.CommentBody,
                    PostId = newComment.PostId,
                    OwnerId = User.Identity.GetUserId(),
                    OwnerUserName = User.Identity.GetUserName(),
                    Date = DateTime.Now
                };

                // Add the comment to the database and save the changes.
                redditCloneContext.Comments.Add(comment);
                redditCloneContext.SaveChanges();

                return RedirectToAction("Detail", "Post", new { id = postId });
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult EditComment(Comment currentComment)
        {
            using (var redditCloneContext = new RedditCloneContext())
            {
                var postId = currentComment.PostId;

                // Retrieve the existing comment from the database.
                var comment = redditCloneContext.Comments.SingleOrDefault(c => c.CommentId == currentComment.CommentId);

                // Ensure that the user owns the comment, apply the changes and save the database
                if (comment != null && User.Identity.GetUserId() == comment.OwnerId)
                {
                    comment.CommentBody = currentComment.CommentBody;
                    redditCloneContext.SaveChanges();

                    return RedirectToAction("Detail", "Post", new { id = postId });
                }

                return new HttpNotFoundResult();
            }
        }
    }
}