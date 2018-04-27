using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models
{
    public class Unit
    {
        public int UnitId { get; set; }
        public string UnitCode { get; set; }
        public string Name { get; set; }
        public int TotalCredit { get; set; }
        public string UnitChair { get; set; }
        
    }
}