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
        // GET: Comment
        [HttpPost]
        [Authorize]
        public ActionResult AddComment(Comment newComment)
        {
            var postId = newComment.PostId;
            
            using (var redditCloneContext = new RedditCloneContext())
            {
                var comment = new Comment
                {
                    CommentBody = newComment.CommentBody,
                    PostId = newComment.PostId,
                    OwnerId = User.Identity.GetUserId(),
                    OwnerUserName = User.Identity.GetUserName(),
                    Date = DateTime.Now
                };

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

                var comment = redditCloneContext.Comments.SingleOrDefault(c => c.CommentId == currentComment.CommentId);

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