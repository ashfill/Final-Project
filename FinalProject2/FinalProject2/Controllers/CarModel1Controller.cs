using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject2;

namespace FinalProject2.Controllers
{
    public class CarModel1Controller : Controller
    {
        private FinalProject1Entities1 db = new FinalProject1Entities1();

        // GET: CarModel1
        public ActionResult Index()
        {
            return View(db.CarModel1.ToList());
        }

        // GET: CarModel1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModel1 carModel1 = db.CarModel1.Find(id);
            if (carModel1 == null)
            {
                return HttpNotFound();
            }
            return View(carModel1);
        }

        // GET: CarModel1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarModel1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarModelID,CarModelName")] CarModel1 carModel1)
        {
            if (ModelState.IsValid)
            {
                db.CarModel1.Add(carModel1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carModel1);
        }

        // GET: CarModel1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModel1 carModel1 = db.CarModel1.Find(id);
            if (carModel1 == null)
            {
                return HttpNotFound();
            }
            return View(carModel1);
        }

        // POST: CarModel1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarModelID,CarModelName")] CarModel1 carModel1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carModel1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carModel1);
        }

        // GET: CarModel1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModel1 carModel1 = db.CarModel1.Find(id);
            if (carModel1 == null)
            {
                return HttpNotFound();
            }
            return View(carModel1);
        }

        // POST: CarModel1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarModel1 carModel1 = db.CarModel1.Find(id);
            db.CarModel1.Remove(carModel1);
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
