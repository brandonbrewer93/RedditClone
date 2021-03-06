﻿using System;
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
                // Retrieve the correct Post from the database and build a post view model with the data
                var post = redditCloneContext.Posts.Select(p => new PostViewModel
                {
                    PostId = p.PostId,
                    Title = p.Title,
                    Body = p.Body,
                    ImageLink = p.ImageLink,
                    Comments = p.Comments,
                    Date = p.Date,
                    OwnerId = p.OwnerId,
                    OwnerUserName = p.OwnerUserName,
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
            using (var redditCloneContext = new RedditCloneContext())
            {
                // Build a new post
                var post = new Post
                {
                    Title = postViewModel.Title,
                    Body = postViewModel.Body,
                    ImageLink = postViewModel.ImageLink,
                    Date = DateTime.Now,
                    OwnerId = User.Identity.GetUserId(),
                    OwnerUserName = User.Identity.GetUserName(),
                    SubredditId = postViewModel.SubredditId
                };

                // Add the post to the database and save the changes.
                redditCloneContext.Posts.Add(post);
                redditCloneContext.SaveChanges();

                return RedirectToAction("Detail", new { id = post.PostId });
            }
        }

        public ActionResult PostEdit(int id)
        {
            using (var redditCloneContext = new RedditCloneContext())
            {
                // Retrieve existing post from the database
                var post = redditCloneContext.Posts.SingleOrDefault(p => p.PostId == id);
                if (post != null)
                {
                    // Build a PostViewModel to populate the Edit form.
                    var postViewModel = new PostViewModel
                    {
                        PostId = post.PostId,
                        Title = post.Title,
                        ImageLink = post.ImageLink,
                        Body = post.Body,
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
            
            using (var redditCloneContext = new RedditCloneContext())
            {
                // Retrieve the correct post from the database.
                var post = redditCloneContext.Posts.SingleOrDefault(p => p.PostId == postViewModel.PostId);
                
                // Ensure that the user owns the post, make the appropriate changes and save the DB.
                if (post != null && User.Identity.GetUserId() == post.OwnerId)
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

        [HttpPost]
        [Authorize]
        public ActionResult DeletePost(PostViewModel postViewModel)
        {
            int subredditId = postViewModel.SubredditId;
            
            using (var redditCloneContext = new RedditCloneContext())
            {
                var post = redditCloneContext.Posts.SingleOrDefault(p => p.PostId == postViewModel.PostId);

                //Ensure that the user owns the post, and delete post from the DB.
                if (post != null && User.Identity.GetUserId() == post.OwnerId)
                {
                    redditCloneContext.Posts.Remove(post);
                    redditCloneContext.SaveChanges();

                    return RedirectToAction("Detail", "Subreddit", new { id = subredditId });
                }

                return new HttpNotFoundResult();
            }
           
        }
    }
}