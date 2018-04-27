using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        public string StudentCode { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}