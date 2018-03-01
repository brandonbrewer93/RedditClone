using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedditClone.Models;

namespace RedditClone.Controllers
{
    public class SubredditController : Controller
    {
        // GET: Subreddit
        public ActionResult Index()
        {
            using (var subredditContext = new RedditCloneContext())
            {
                var subredditList = new SubredditListViewModel
                {
                    Subreddits = subredditContext.Subreddits.Select(s => new SubredditViewModel
                    {
                        SubredditId = s.SubredditId,
                        SubredditName = s.SubredditName,
                        Posts = s.Posts
                    }).ToList()
                };
                return View(subredditList);
            }
        }

        public ActionResult Detail(int id)
        {
            using (var redditCloneContext = new RedditCloneContext())
            {
                var subreddit = redditCloneContext.Subreddits.Select(s => new SubredditViewModel
                {
                    SubredditId = s.SubredditId,
                    SubredditName = s.SubredditName,
                    Posts = s.Posts
                }).SingleOrDefault(s => s.SubredditId == id);

                if (subreddit == null)
                {
                    return new HttpNotFoundResult();
                }

                return View(subreddit);
            }
        }

        [HttpPost]
        public ActionResult AddSubreddit(SubredditViewModel subredditViewModel)
        {
            using (var redditCloneContext = new RedditCloneContext())
            {
                var subreddit = new Subreddit
                {
                    SubredditName = subredditViewModel.SubredditName
                };

                redditCloneContext.Subreddits.Add(subreddit);
                redditCloneContext.SaveChanges();

                return RedirectToAction("Detail", new { id = subreddit.SubredditId });
            }
        }

        [HttpPost]
        public ActionResult DeleteSubreddit(SubredditViewModel subredditViewModel)
        {
            using (var redditCloneContext = new RedditCloneContext())
            {
                var subreddit = redditCloneContext.Subreddits.SingleOrDefault(s => s.SubredditId == subredditViewModel.SubredditId);

                if (subreddit != null)
                {
                    redditCloneContext.Subreddits.Remove(subreddit);
                    redditCloneContext.SaveChanges();

                    return RedirectToAction("Index");
                }

                return new HttpNotFoundResult();
            }
        }
    }
}