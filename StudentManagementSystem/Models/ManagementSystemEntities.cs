using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models
{
    public class ManagementSystemEntities : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Record> Records { get; set; }
        
    }
}