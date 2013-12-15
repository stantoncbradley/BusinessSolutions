using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessSolutions.Models;

namespace BusinessSolutions.Controllers
{
    public class CommentController : Controller
    {
        //
        // GET: /Comment/
        [HttpPost]
        public ActionResult AddComment(CommentModel model)
        {
            return View();
        }
	}
}