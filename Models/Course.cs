using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Management_app.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
    }
    public class CourseCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
    public class CourseandCategory
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}