using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Management_app.Controllers
{
    public class TrainerController : Controller
    {
        // GET: Trainer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UpdateDetails()
        {
            return View();
        }
        public ActionResult AssignedCourses()
        {
            return View();
        }
    }
}