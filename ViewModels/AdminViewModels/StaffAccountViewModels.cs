using Management_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Management_app.ViewModels.AdminViewModels
{
    public class StaffAccountViewModels
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}