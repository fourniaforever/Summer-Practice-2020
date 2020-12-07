using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SummerPracticeProject.BLL.Interfaces;
using System.Web.Mvc;

namespace SummerPracticeProject.MVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopsLogic shopLogic;

        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Search(int rate)
        {
            ViewData["searchpattern"] = rate;
            var tmp = shopLogic.SelectShopsByRate(rate);
            return View(tmp);
        }
    }
}