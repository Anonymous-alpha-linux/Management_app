using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.ViewModels.TrainerViewModel
{
    public class TrainerViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string ExorInType { get; set; }
        [Required]
        public string Education { get; set; }
        [Required]
        public string Address { get; set; }
        public string Email { get; set; }
        [Required(string.IsNullOrEmpty)]
        public string Phone { get; set; }
    }
}