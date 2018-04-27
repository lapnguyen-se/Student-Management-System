using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models
{
    public class Record
    {
        public int RecordId { get; set; }
        public int Result { get; set; }

        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}