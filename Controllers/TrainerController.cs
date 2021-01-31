using WebApplication.Models;
using WebApplication.ViewModels.TrainerViewModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication;

namespace Management_app.Controllers
{
    public class TrainerController : Controller
    {
        private ApplicationDbContext _context;
        private ApplicationUser _user;
        private UserManager<ApplicationUser> _userManager;
        private ApplicationUserManager _applicationUserManger;

        public TrainerController()
        {
            _context = new ApplicationDbContext();

            _user = new ApplicationUser();

            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }
        // GET: Trainer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UpdateDetails()
        {
            var currrentUser = User.Identity.GetUserId();
            var applicationUser = _context.Users.FirstOrDefault(t => t.Id == currrentUser);
            var trainerViewModel = new TrainerViewModel()
            {
                UserName = applicationUser.UserName,
                Email = applicationUser.Email,
                Address = applicationUser.Address,
                Education = applicationUser.Education,
                ExorInType = applicationUser.ExorInType,
                Phone = applicationUser.PhoneNumber,
            };
            return View(trainerViewModel);
        }
        [HttpPost]
        public ActionResult UpdateDetails(TrainerViewModel trainerViewModel)
        {
            var exorein = new List<string>() { "internal", "external" };
            ViewBag.List = exorein;
            var currentUser = User.Identity.GetUserId();
            var applicationUser = _context.Users.FirstOrDefault(t => t.Id == currentUser);
            applicationUser.UserName = trainerViewModel.UserName;
            applicationUser.Email = trainerViewModel.Email;
            applicationUser.Address = trainerViewModel.Address;
            applicationUser.ExorInType = trainerViewModel.ExorInType;
            applicationUser.Education = trainerViewModel.Education;
            applicationUser.PhoneNumber = trainerViewModel.Phone;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult AssignedCourses(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult AssignedCourses()
        {
            return View();
        }
    }
}