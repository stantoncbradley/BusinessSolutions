using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessSolutions.Models;

namespace BusinessSolutions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Items(int itemId)
        {
            ItemModel model = new ItemModel();

            model.Title = getTitle(itemId);
            model.ItemText = getItemText(itemId);
            return View(model);
        }

        public ActionResult Products()
        {
            ProductModel model = new ProductModel();
            model.Items = GetAllItems();
            return View(model);
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        private List<ItemModel> GetAllItems()
        {
            List<ItemModel> items = new List<ItemModel>();
            ItemModel model1 = GetItem(1);
            items.Add(model1);
            ItemModel model2 = GetItem(2);
            items.Add(model2);
            return items;
        }

        private ItemModel GetItem(int itemId)
        {
            ItemModel model = new ItemModel();
            model.ItemText = getItemText(itemId);
            model.Title = getTitle(itemId);
            model.Id = itemId;
            return model;
        }

        public string getTitle(int itemId)
        {
            if (itemId == 1)
                return "Website Deluxe Package";
            else if (itemId == 2)
                return "Website Basic Package";
            else
                return "Item not found";
        }

        public string getItemText(int itemId)
        {
            if (itemId == 1)
                return "Includes awesome features and support";
            else if (itemId == 2)
                return "Includes basic features";
            else
                return "Article not found";
        }
    }
}
