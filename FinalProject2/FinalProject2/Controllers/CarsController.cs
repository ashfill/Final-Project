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
    public class CarsController : Controller
    {
        private FinalProject1Entities1 db = new FinalProject1Entities1();

        // GET: Cars
        public ActionResult Index()
        {
            var cars = db.Cars.Include(c => c.CarModel1).Include(c => c.Engine).Include(c => c.Make).Include(c => c.Manufacturer).Include(c => c.Transmission).Include(c => c.Turbo);
            return View(cars.ToList());
        }

        // GET: Cars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            ViewBag.CarModelID = new SelectList(db.CarModel1, "CarModelID", "CarModelName");
            ViewBag.EngineID = new SelectList(db.Engines, "EngineID", "EngineName");
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName");
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufacturerID", "ManufacturerName");
            ViewBag.TransmissionID = new SelectList(db.Transmissions, "TransmissionID", "TransmissionName");
            ViewBag.TurboID = new SelectList(db.Turboes, "TurboID", "HPRating");
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarID,ManufacturerID,MakeID,CarModelID,EngineID,TransmissionID,TurboID")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarModelID = new SelectList(db.CarModel1, "CarModelID", "CarModelName", car.CarModelID);
            ViewBag.EngineID = new SelectList(db.Engines, "EngineID", "EngineName", car.EngineID);
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName", car.MakeID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufacturerID", "ManufacturerName", car.ManufacturerID);
            ViewBag.TransmissionID = new SelectList(db.Transmissions, "TransmissionID", "TransmissionName", car.TransmissionID);
            ViewBag.TurboID = new SelectList(db.Turboes, "TurboID", "HPRating", car.TurboID);
            return View(car);
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarModelID = new SelectList(db.CarModel1, "CarModelID", "CarModelName", car.CarModelID);
            ViewBag.EngineID = new SelectList(db.Engines, "EngineID", "EngineName", car.EngineID);
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName", car.MakeID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufacturerID", "ManufacturerName", car.ManufacturerID);
            ViewBag.TransmissionID = new SelectList(db.Transmissions, "TransmissionID", "TransmissionName", car.TransmissionID);
            ViewBag.TurboID = new SelectList(db.Turboes, "TurboID", "HPRating", car.TurboID);
            return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarID,ManufacturerID,MakeID,CarModelID,EngineID,TransmissionID,TurboID")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarModelID = new SelectList(db.CarModel1, "CarModelID", "CarModelName", car.CarModelID);
            ViewBag.EngineID = new SelectList(db.Engines, "EngineID", "EngineName", car.EngineID);
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName", car.MakeID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufacturerID", "ManufacturerName", car.ManufacturerID);
            ViewBag.TransmissionID = new SelectList(db.Transmissions, "TransmissionID", "TransmissionName", car.TransmissionID);
            ViewBag.TurboID = new SelectList(db.Turboes, "TurboID", "HPRating", car.TurboID);
            return View(car);
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
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
