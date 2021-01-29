using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using Management_app.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Management_app.ViewModels;
using Management_app.ViewModels.AdminViewModels;
using System.Web.Security;
using System.Data.Entity;
using System;

namespace Management_app.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        ApplicationDbContext _context;
        ApplicationUser _user;
        UserManager<ApplicationUser> _userManager;
        ApplicationUserManager _applicationUserManger;

        public AdminController()
        { 
            _context = new ApplicationDbContext();
            _user = new ApplicationUser();
            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }
        // GET: Admin
        public ActionResult StaffAccountView()
        {
            var staffaccount = _context.Users.Where(t => t.Roles.Any(y => y.RoleId == "2")).ToList();
            return View(staffaccount);
        }
        public ActionResult TrainerAccountView()
        {
            var traineraccount = _context.Users.Where(t => t.Roles.Any(y => y.RoleId == "3")).ToList();
            return View(traineraccount); 
        }
    }
}