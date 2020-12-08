using SummerPracticeProject.BLL.Interfaces;
using SummerPracticeProject.Entities;
using SummerPracticeProject.MVC.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SummerPracticeProject.MVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopsLogic _shopLogic;

        public ShopController(IShopsLogic shopsLogic)
        {
            _shopLogic = shopsLogic;
        }

        // GET: Shop
        [HttpGet]
        public ActionResult Index()
        {
            return View(_shopLogic.GetAll());
        }

        [HttpGet]
        public ActionResult Search(int rate)
        {
            ViewData["searchpattern"] = rate;
            List<ShopVM> shopVMs = new List<ShopVM>();
            foreach (var item in _shopLogic.SelectShopsByRate(rate))
            {
                shopVMs.Add(new ShopVM()
                {
                    ShopName = item
                });
            }
            return View(shopVMs);
        }

        [HttpGet]
        public ActionResult AddShop()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddShop(Shops shop)
        {
            _shopLogic.Add(shop);
            return RedirectToAction("Menu", "Menu");
        }
    }
}