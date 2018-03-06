using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;
using Microsoft.AspNet.Identity;
using RedditClone.Models;

namespace RedditClone.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Detail(int id)
        {
            using (var redditCloneContext = new RedditCloneContext())
            {
                var post = redditCloneContext.Posts.Select(p => new PostViewModel
                {
                    PostId = p.PostId,
                    Title = p.Title,
                    Body = p.Body,
                    ImageLink = p.ImageLink,
                    Comments = p.Comments,
                    Date = p.Date,
                    OwnerId = p.OwnerId,
                    SubredditId = p.SubredditId
                }).SingleOrDefault(p => p.PostId == id);

                if (post == null)
                {
                    return new HttpNotFoundResult();
                }

                return View(post);
            }
        }

        public ActionResult PostAdd(int id)
        {

            var postViewModel = new PostViewModel
            {
                SubredditId = id
            };

            return View("AddEditPost", postViewModel);
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddPost(PostViewModel postViewModel)
        {
            if (User.Identity.IsAuthenticated)
            {
                using (var redditCloneContext = new RedditCloneContext())
                {
                    var post = new Post
                    {
                        Title = postViewModel.Title,
                        Body = postViewModel.Body,
                        ImageLink = postViewModel.ImageLink,
                        Date = DateTime.Now,
                        OwnerId = User.Identity.GetUserId(),
                        SubredditId = postViewModel.SubredditId
                    };

                    redditCloneContext.Posts.Add(post);
                    redditCloneContext.SaveChanges();

                    return RedirectToAction("Detail", new { id = post.PostId });
                }
            }
            return new HttpUnauthorizedResult();
        }

        public ActionResult PostEdit(int id)
        {
            using (var redditCloneContext = new RedditCloneContext())
            {
                var post = redditCloneContext.Posts.SingleOrDefault(p => p.PostId == id);
                if (post != null)
                {
                    var postViewModel = new PostViewModel
                    {
                        PostId = post.PostId,
                        Title = post.Title,
                        ImageLink = post.ImageLink,
                        Body = post.Body,
                        OwnerId = post.OwnerId,
                        SubredditId = post.SubredditId
                    };

                    return View("AddEditPost", postViewModel);
                }

                return new HttpNotFoundResult();
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult EditPost(PostViewModel postViewModel)
        {
            if (User.Identity.IsAuthenticated && User.Identity.GetUserId() == postViewModel.OwnerId)
            {
                using (var redditCloneContext = new RedditCloneContext())
                {
                    var post = redditCloneContext.Posts.SingleOrDefault(p => p.PostId == postViewModel.PostId);

                    if (post != null)
                    {
                        post.Title = postViewModel.Title;
                        post.Body = postViewModel.Body;
                        post.ImageLink = postViewModel.ImageLink;
                        redditCloneContext.SaveChanges();

                        return RedirectToAction("Detail", new { id = postViewModel.PostId });
                    }

                    return new HttpNotFoundResult();
                }
            }
            
            return new HttpUnauthorizedResult();
        }

        [HttpPost]
        [Authorize]
        public ActionResult DeletePost(PostViewModel postViewModel)
        {
            int subredditId = postViewModel.SubredditId;

            if (User.Identity.IsAuthenticated && User.Identity.GetUserId() == postViewModel.OwnerId)
            {
                using (var redditCloneContext = new RedditCloneContext())
                {
                    var post = redditCloneContext.Posts.SingleOrDefault(p => p.PostId == postViewModel.PostId);

                    if (post != null)
                    {
                        redditCloneContext.Posts.Remove(post);
                        redditCloneContext.SaveChanges();

                        return RedirectToAction("Detail", "Subreddit", new { id = subredditId });
                    }

                    return new HttpNotFoundResult();
                }
            }
            
            return new HttpUnauthorizedResult();
        }
    }
}