﻿using Management_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Management_app.ViewModels.AdminViewModels
{
    public class StaffAccountViewModels
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="This field cannot be empty")]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Password { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Role { get; set; }
    }
}