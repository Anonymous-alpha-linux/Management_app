using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Management_app.Models;

namespace Management_app.Controllers
{
    public class HomeController : Controller
    {
        ApplicationUser _applicationUser;
        public HomeController()
        {
            _applicationUser = new ApplicationUser(); 
        }
        public ActionResult Index()
        {
            return View(_applicationUser);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}