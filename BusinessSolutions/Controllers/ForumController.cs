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
           /* IndexModel model = new IndexModel();
            model.Items = GetAllItems();
            return View(model);
           */
            return View();
        }
	}
}