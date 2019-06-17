using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanesOnlineStore.Models;

namespace LanesOnlineStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var category = new List<Category>
            {
                new Category {CategoryID = "0", Name = "Clothing, Footwear, Jewelry", Description="test"},
                new Category {CategoryID = "1", Name = "Movies, Music & Games"},
                new Category {CategoryID = "2", Name = "Electronics, Computer Office"},
                new Category {CategoryID = "3", Name = "Home and Garden"},
                new Category {CategoryID = "4", Name = "Toys"},
                new Category {CategoryID = "5", Name = "Beauty & Health"},
                new Category {CategoryID = "6", Name = "Sports & Outdoors"},

            };
                    return View(category);

        }

        public ActionResult Browse(string category)
        {
            var categoryModel = new Category { Name = category };
            return View(categoryModel);
        }
        public ActionResult Details(int ID)
        {
            var Item = new Item { Title = "Item" + ID };
            return View(Item);
        }
    }
}