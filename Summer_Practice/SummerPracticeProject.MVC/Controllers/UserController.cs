using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SummerPracticeProject.BLL.Interfaces;

namespace SummerPracticeProject.MVC.Controllers
{
    public class UserController : Controller
    {
        private IUsersLogic userLogic;
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public UserController(IUsersLogic user)
        {
            userLogic = user;
        }

        public ViewResult Users()
        {

        }
    }
}