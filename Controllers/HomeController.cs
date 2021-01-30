using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Management_app.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;

namespace Management_app.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _applicationDbContext;
        public HomeController()
        {
            _applicationDbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
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