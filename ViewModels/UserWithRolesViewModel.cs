using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Management_app.ViewModels
{
    public class UserWithRolesViewModel
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string userName { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
    }
}