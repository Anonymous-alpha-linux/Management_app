using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Management_app.Models.Main_data
{
    public class Administrator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "This field cannot be empty")]
        public int ID { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string Address { get; set; }

        public Administrator(int id, string name,string address)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
        }
        public Administrator()
        {

        }
    }
}