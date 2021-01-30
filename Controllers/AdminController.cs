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
        public ActionResult Index()
        {
            return View(_context.Users.ToList());
        }
        public ActionResult StaffAccountView()
        {
            var staffaccount = _context.Users.Where(t => t.Roles.Any(y => y.RoleId == "2")).ToList();

            return View(staffaccount);
        }
        public ActionResult TrainerAccountView()
        {
            var traineraccount = _context.Users.Where(t => t.Roles.Any(y => y.RoleId == "3")).ToList();

            if(traineraccount == null)
            {
                return HttpNotFound();
            }
            return View(traineraccount); 
        }
        
        public ActionResult DeleteStaffAccount(string id)
        {
            var staffaccount = _context.Users
                .SingleOrDefault(t => t.Id == id);

            _context.Users.Remove(staffaccount);

            _context.SaveChanges();

            return RedirectToAction("StaffAccountView");
        }
        public ActionResult DeleteTrainerAccount(string id)
        {
            var traineraccount = _context.Users
                .SingleOrDefault(t => t.Id == id);

            _context.Users.Remove(traineraccount);

            _context.SaveChanges();
            return RedirectToAction("TrainerAccountView");
        }
        
        /// <summary>
        /// Get elements of IdentityUser that sastifies the specific id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult EditStaffAccount(string id)
        {
            var staffaccount = _context.Users
                .SingleOrDefault(t => t.Id == id);
            if (staffaccount == null)
            {
                return HttpNotFound();
            }

            var registermodel = new RegisterViewModel()
            {
                Email = staffaccount.Email,
                Password = staffaccount.PasswordHash,
                ConfirmPassword = staffaccount.PasswordHash,
                Role = staffaccount.Roles.FirstOrDefault(t => t.RoleId == "2").ToString(),
            };
            var list = new List<string>() { "admin", "staff", "trainer", "trainee" };
            ViewBag.list = list;
            return View(registermodel);
        }
        /// <summary>
        /// Change detail of element of IndentyUser that sastify with a specific id and RegisterViewModel object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="registerViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult EditStaffAccount(string id, RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var edit_infor = _context.Users.SingleOrDefault(t => t.Id == id);
            edit_infor.Email = registerViewModel.Email;
            edit_infor.PasswordHash = registerViewModel.Password;
            edit_infor.Role = registerViewModel.Role;
            _userManager.RemoveFromRole(edit_infor.Id, _userManager.GetRoles(edit_infor.Id)[0]);
            _context.SaveChanges();

            return RedirectToAction("StaffAccountView");
        }
        /// <summary>
        /// Get elements of IdentityUser that sastifies the specific id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult EditTrainerAccount(string id)
        {
            var traineraccount = _context.Users
                .SingleOrDefault(t => t.Id == id);
            if (traineraccount == null)
            {
                return HttpNotFound();
            }

            var registermodel = new RegisterViewModel()
            {
                Email = traineraccount.Email,
                Password = traineraccount.PasswordHash,
                ConfirmPassword = traineraccount.PasswordHash,
                Role = traineraccount.Roles.FirstOrDefault(t => t.RoleId == "3").ToString(),
            };
            var list = new List<string>() { "admin", "staff", "trainer", "trainee" };
            ViewBag.list = list;
            return View(registermodel);
        }
        /// <summary>
        /// Change detail of element of IndentyUser that sastify with a specific id and RegisterViewModel object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="registerViewModel"></param>
        [HttpPost]
        public ActionResult EditTrainerfAccount(string id, RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var edit_infor = _context.Users.SingleOrDefault(t =>t.Id == id);
            edit_infor.Email = registerViewModel.Email;
            edit_infor.PasswordHash = registerViewModel.Password;
            edit_infor.Role = registerViewModel.Role;
            _userManager.RemoveFromRole(edit_infor.Id, _userManager.GetRoles(edit_infor.Id)[0]);
            _context.SaveChanges();

            return RedirectToAction("TrainerAccountView");
        }
    }
}