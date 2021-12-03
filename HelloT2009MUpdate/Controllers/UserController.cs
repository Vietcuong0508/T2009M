using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloT2009MUpdate.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        
        public ActionResult Processlogin(string username, string password)
        {
            Debug.WriteLine($"{username} - {password}");
            return RedirectToAction("About", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult ProcessRegister()
        {
            return View();
        }
    }
}