using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Management_app.Models.Main_data
{
    public class Account_types
    {
        public int ID { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "This field cannot be empty")]
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "This field cannot be empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Authorize")]
        [Required(ErrorMessage = "Choose your authorize")]
        public string Type { get; set; }
    }
}