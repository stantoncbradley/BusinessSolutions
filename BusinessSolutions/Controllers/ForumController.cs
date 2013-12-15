using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessSolutions.Models;

namespace BusinessSolutions.Controllers
{
    public class ForumController : Controller
    {
        //
        // GET: /Forum/
        public ActionResult Index()
        {
            IndexModel model = new IndexModel();
            model.Threads = GetAllThreads();
            model.LoggedIn = Session["logged_in"] == null ? false : (bool)Session["logged_in"];
            model.Name = model.LoggedIn ? (string)Session["name"] : "";
            return View(model);
        }

        public ActionResult Threads(int threadId)
        {
            ThreadModel model = new ThreadModel();

            model.Title = getTitle(threadId);
            model.CommentSection = new CommentSectionModel();
            model.CommentSection.Comments = new List<CommentModel>();
            
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.CommentForm = new CommentFormModel();
            return View(model);
        }

        private List<ThreadModel> GetAllThreads()
        {
            List<ThreadModel> threads = new List<ThreadModel>();
            ThreadModel model1 = GetThread(1);
            threads.Add(model1);
            ThreadModel model2 = GetThread(2);
            threads.Add(model2);
            return threads;
        }

        private ThreadModel GetThread(int threadId)
        {
            ThreadModel model = new ThreadModel();
            model.Title = getTitle(threadId);
            model.Id = threadId;
            model.CommentSection = new CommentSectionModel();
            model.CommentSection.Comments = new List<CommentModel>();
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.CommentForm = new CommentFormModel();
            return model;
        }

        private CommentModel GetCommentModel()
        {
            return new CommentModel()
            {
                Comment = "Nice products!!!",
                Name = "Harry Smith"
            };
        }

        public string getTitle(int threadId)
        {
            if (threadId == 1)
                return "Reviews";
            else
                return "Suggestions";
        }
	}
}