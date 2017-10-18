using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Records.Models;

namespace Records.Controllers
{
    public class Student_RecordsController : Controller
    {
        private RecordsDB db = new RecordsDB();

        // GET: Student_Records
        public ActionResult Index()
        {
            return View(db.Records.ToList());
        }

        // GET: Student_Records/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Records student_Records = db.Records.Find(id);
            if (student_Records == null)
            {
                return HttpNotFound();
            }
            return View(student_Records);
        }

        // GET: Student_Records/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student_Records/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Address")] Student_Records student_Records)
        {
            if (ModelState.IsValid)
            {
                db.Records.Add(student_Records);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student_Records);
        }

        // GET: Student_Records/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Records student_Records = db.Records.Find(id);
            if (student_Records == null)
            {
                return HttpNotFound();
            }
            return View(student_Records);
        }

        // POST: Student_Records/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Address")] Student_Records student_Records)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_Records).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student_Records);
        }

        // GET: Student_Records/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Records student_Records = db.Records.Find(id);
            if (student_Records == null)
            {
                return HttpNotFound();
            }
            return View(student_Records);
        }

        // POST: Student_Records/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student_Records student_Records = db.Records.Find(id);
            db.Records.Remove(student_Records);
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
