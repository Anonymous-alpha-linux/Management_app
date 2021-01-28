using Management_app.Models.Main_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using Management_app.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Management_app.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        ApplicationDbContext _context;
        UserManager<ApplicationUser> _userManager;
        public AdminController()
        {
            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            _context = new ApplicationDbContext();
        }
        // GET: Admin
        public ActionResult StaffAccountView(object id)
        {
            var users = _context.Users.ToList();

            var staffs = _userManager.Users;
            return View(users);
        }
        public ActionResult TrainerAccountView()
        {
            var users = _context.Users.ToList();
            return View(users); 
        }
    }
}