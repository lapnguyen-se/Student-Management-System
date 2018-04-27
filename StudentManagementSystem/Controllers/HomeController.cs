using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentManagementSystem.Models;


namespace StudentManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        ManagementSystemEntities db = new ManagementSystemEntities();
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: New/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List <Record> records = db.Records.Where(g => g.StudentId == id).ToList();
            if (records == null)
            {
                return HttpNotFound();
            }

            Student student= db.Students.Single(g => g.StudentId == id);
            ViewBag.StudentId = id;
            ViewBag.StudentFirstName = student.FirstName;
            ViewBag.StudentLastName = student.LastName;
            ViewBag.StudentCode = student.StudentCode;
            ViewBag.PhoneNumber = student.PhoneNumber;
            ViewBag.Address = student.Address;
            ViewBag.CourseName = student.Course.Name;
            ViewBag.CourseId = student.Course.CourseCode;
            ViewBag.TotalCredit = student.Course.TotalCredit;
            return View(records);
        }

        // GET: New/Create
        public ActionResult Create()
        {
            List<Course> courses = db.Courses.ToList();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (Course item in courses)
            {
                items.Add(new SelectListItem { Text = item.Name, Value = item.CourseId.ToString() });
            }

            ViewBag.CourseId = items;
            return View();
        }


        // POST: New/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,FirstName,LastName,StudentCode,PhoneNumber,Address,CourseId")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }  
            return View(student);
        }

        // GET: New/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            List<Course> courses = db.Courses.ToList();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (Course item in courses)
            {
                items.Add(new SelectListItem { Text = item.Name, Value = item.CourseId.ToString() });
            }

            ViewBag.CourseId = items;
            return View(student);
        }

        // POST: New/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,FirstName,LastName,StudentCode,PhoneNumber,Address,CourseId")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: New/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: New/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}