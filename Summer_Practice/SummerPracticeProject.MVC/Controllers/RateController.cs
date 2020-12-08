using SummerPracticeProject.BLL.Interfaces;
using SummerPracticeProject.Entities;
using System.Web.Mvc;

namespace SummerPracticeProject.MVC.Controllers
{
    public class RateController : Controller
    {
        private IRatesLogic _rateLogic;

        public RateController(IRatesLogic ratesLogic)
        {
            _rateLogic = ratesLogic;
        }

        // GET: Rate
        public ActionResult Index()
        {
            return View(_rateLogic.GetAll());
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_rateLogic.GetById(id));
        }

        [HttpPost]
        public ActionResult Delete(Rates rates)
        {
            _rateLogic.Remove(rates.Id);
            return RedirectToAction("Index", "Rate");
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Add(Rates rates)
        {
            _rateLogic.Add(rates);
            return RedirectToAction("Index", "Rate");
        }
    }
}