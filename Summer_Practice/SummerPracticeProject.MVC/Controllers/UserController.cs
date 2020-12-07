using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SummerPracticeProject.Entities;
using SummerPracticeProject.BLL;
using SummerPracticeProject.BLL.Interfaces;

namespace SummerPracticeProject.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersLogic userLogic;


        public UserController()
        {

        }

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
                TempData["Id"] = _user.Id;
                TempData["Name"] = _user.Name;
                TempData["Surname"] = _user.Surname;
                TempData["Login"] = user.Login;
                TempData["Password"] = user.Password;
                TempData["City"] = _user.City;
                return RedirectToAction("GetModels", "");
            }
            else
            {
                return View();
            }
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