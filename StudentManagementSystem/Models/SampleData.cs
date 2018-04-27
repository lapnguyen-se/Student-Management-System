using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<ManagementSystemEntities>
    {
        protected override void Seed(ManagementSystemEntities context)
        {
           
            var units = new List<Unit>
            {
                new Unit { UnitCode="SIT771", Name="Object-Oriented Development",TotalCredit=1, UnitChair="Andrew Cain" },
                new Unit { UnitCode="SIT725 ", Name="Advanced Software Engineering", TotalCredit=1, UnitChair="Shamsul Huda" },
                new Unit { UnitCode="SIT705 ", Name="Research Methods for IT", TotalCredit=1, UnitChair="Sasan Adibi" },
                new Unit { UnitCode="SIT791  ", Name="Professional Practice", TotalCredit=4, UnitChair="Seng Loke" },
                new Unit { UnitCode="SIT782 ", Name="Practical Project", TotalCredit=4, UnitChair="Honghua Dai" },
            };
            foreach (var temp in units)
            {
                context.Units.Add(temp);
            }
            context.SaveChanges();


            var courses = new List<Course>
            {
                new Course { CourseCode ="S779", Name="Master of Information Technology (Professional)", TotalCredit=16 },
                new Course { CourseCode ="S778", Name="Master of Information Technology", TotalCredit=12 },
                new Course { CourseCode ="A743", Name="Master of Communication", TotalCredit=16 }
            };
            foreach (var temp in courses)
            {
                context.Courses.Add(temp);
            }
            context.SaveChanges();



            var students = new List<Student>
            {
                new Student { FirstName = "Lap", LastName="Nguyen", StudentCode ="216352709", PhoneNumber="0414389384", Address = "3 Barry Road, Burwood East, VIC 3151", CourseId=1 },
                new Student { FirstName = "Mitchell", LastName="Maria", StudentCode ="216352710", PhoneNumber="0491570156", Address = "7 Bart Rise Port Chadrick, TAS 2631", CourseId=1 },
                new Student { FirstName = "Curie", LastName="Marie", StudentCode ="216352711", PhoneNumber="0491570157", Address = "32B Prince Tarn Binsbury, NSW 2089", CourseId=2},
                new Student { FirstName = "Born", LastName="Max", StudentCode ="216352712", PhoneNumber="0491570158", Address = "99D Howell Freeway South Estellatown, SA 2652", CourseId=2 },
                new Student { FirstName = "Planck", LastName="Max", StudentCode ="216352713", PhoneNumber="0491570159", Address = "28C Freddy Alleyway Port Orrintown, NSW 2859", CourseId=3},
                new Student { FirstName = "Franklin", LastName="Melissa", StudentCode ="216352714", PhoneNumber="0491570110", Address = "23 Jeffery Quadrant New Lisa, VIC 5066", CourseId=3 },
                new Student { FirstName = "Faraday", LastName="Michael", StudentCode ="216352715", PhoneNumber="0491670110", Address = "9C Gaetano Villas East Lisaview, VIC 2920", CourseId=2},
                new Student { FirstName = "Bohr", LastName="Niels", StudentCode ="216352716", PhoneNumber="0491579910", Address = "547C Boehm Cross Hilpertshire, NSW 7616", CourseId=1 },
                new Student { FirstName = "Boysen", LastName="Sarah", StudentCode ="216352717", PhoneNumber="0495679910", Address = "893 Rudy Causeway Murraytown, SA 6697", CourseId=3},
                new Student { FirstName = "Pascal", LastName="Blaise", StudentCode ="216352718", PhoneNumber="0494560110", Address = "Flat 61 20 Melyssa Corner Aprilshire, SA 2948", CourseId=1 },
                new Student { FirstName = "Herschel", LastName="Caroline", StudentCode ="216352719", PhoneNumber="0494789110", Address = "39B Bayer Amble Kerlukeshire, VIC 2239", CourseId=2},
                new Student { FirstName = "Hodgkin", LastName="Dorothy", StudentCode ="216352720", PhoneNumber="0494560000", Address = "146 / 7 Kulas Point Rathland, TAS 2696", CourseId=1 },
                new Student { FirstName = "Halley", LastName="Edmond", StudentCode ="216352721", PhoneNumber="0494560001", Address = "415 / 889 Mante Loop Kaitlyntown, VIC 2963", CourseId=2},
                new Student { FirstName = "McKean", LastName="Ali", StudentCode ="216352722", PhoneNumber="0494504000", Address = "8 Bayview Road KARCULTABY SA 5654", CourseId=3 },
                new Student { FirstName = "Tyson", LastName="Isabelle", StudentCode ="216352723", PhoneNumber="0494563501", Address = "70 Anderson Street CHERMSIDE BC QLD 4032", CourseId=2},
            };
            foreach (var temp in students)
            {
                context.Students.Add(temp);
            }
            context.SaveChanges();

            var records = new List<Record>
            {
                new Record{ Result= 99, UnitId = 1, StudentId = 1 },
                new Record{ Result= 85, UnitId = 2, StudentId = 1 },
                new Record{ Result= 87, UnitId = 3, StudentId = 1 },
                new Record{ Result= 91, UnitId = 4, StudentId = 1 },

                new Record{ Result= 100, UnitId = 1, StudentId = 2 },
                new Record{ Result= 79, UnitId = 2, StudentId = 2 },
                new Record{ Result= 49, UnitId = 3, StudentId = 2 },
                new Record{ Result= 70, UnitId = 4, StudentId = 2 },


                new Record{ Result= 10, UnitId = 2, StudentId = 3 },
                new Record{ Result= 9, UnitId = 1, StudentId = 3 },

            };
            foreach (var temp in records)
            {
                context.Records.Add(temp);
            }
            context.SaveChanges();
        }
     
    }
}