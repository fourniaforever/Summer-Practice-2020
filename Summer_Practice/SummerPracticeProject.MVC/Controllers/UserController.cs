using SummerPracticeProject.BLL.Interfaces;
using SummerPracticeProject.Entities;
using System.Web.Mvc;
using System.Web.Security;

namespace SummerPracticeProject.MVC.Controllers
{
    public class UserController : Controller
    {
        private IUsersLogic userLogic;

        public UserController(IUsersLogic user)
        {
            userLogic = user;
        }

        // GET: User
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(Users user)
        {
            if (userLogic.Authentication(user))
            {
                ModelState.AddModelError("Login", "User already existed.");
                ModelState.AddModelError("Password", "User already existed.");
            }
            if (ModelState.IsValid)
            {
                userLogic.Add(user);
                return RedirectToAction("SignIn");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(Users user)
        {
            if (ModelState.IsValidField("Login") && ModelState.IsValidField("Password")
               && !userLogic.Authentication(user))
            {
                ModelState.AddModelError("Login", "User does not exist.");
                ModelState.AddModelError("Password", "User does not exist.");
            }
            if (ModelState.IsValidField("Login") && ModelState.IsValidField("Password"))
            {
                Users _user = userLogic.GetByLogin(user.Login);
                //TempData["Id"] = _user.Id;
                //TempData["Name"] = _user.Name;
                //TempData["Surname"] = _user.Surname;
                //TempData["Login"] = user.Login;
                //TempData["Password"] = user.Password;
                //TempData["City"] = _user.City;
                FormsAuthentication.SetAuthCookie(_user.Name, true);
                return RedirectToAction("Menu", "Menu");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult RegistrationFailed()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RegistrationSuccess()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult Edit()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Edit()
        //{
        //    return View();
        //}
    }
}