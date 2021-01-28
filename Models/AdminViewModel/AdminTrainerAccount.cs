using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Management_app.Models.AdminViewModel
{
    [Table("AspNetUsers")]
    public class AdminTrainerAccount
    {
        public int ID { get; set; }
        public int TrainerID { get; set; }
        public string TrainerEmail { get; set; }
        public object Password { get; set; }
    }
}