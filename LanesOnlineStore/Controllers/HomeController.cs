using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanesOnlineStore.Models;

namespace LanesOnlineStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClothingFootwearJewelry()
        {
            return View();
        }

        public ActionResult MoviesMusicGames()
        {
            return View();
        }

        public ActionResult ElectronicsComputerOffice()
        {
            return View();
        }

        public ActionResult HomeGarden()
        {
            return View();
        }

        public ActionResult Toys()
        {
            return View();
        }

        public ActionResult BeautyHealth()
        {
            return View();
        }

        public ActionResult SportsOutdoors()
        {
            return View();
        }
    }
}