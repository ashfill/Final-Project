using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarProject;
using CarProject.Models;

namespace CarProject.Controllers
{
    public class Engine1Controller : Controller
    {
        private FinalProject2Entities3 db = new FinalProject2Entities3();

        // GET: Engine1
        [Authorize]
        public ActionResult Index()
        {
            var engine1 = db.Engine1.Include(e => e.CarModel); 
            return View(engine1.ToList());
        }

        // GET: Engine1/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Engine1 engine1 = db.Engine1.Find(id);
            if (engine1 == null)
            {
                return HttpNotFound();
            }
            return View(engine1);
        }

        // GET: Engine1/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName");
            return View();
        }

        // POST: Engine1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "EngineID,EngineName,EngineHPRating,EngineTorque,CarModelID,Price")] Engine1 engine1)
        {
            if (ModelState.IsValid)
            {
                db.Engine1.Add(engine1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName", engine1.CarModelID);
            return View(engine1);
        }

        // GET: Engine1/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Engine1 engine1 = db.Engine1.Find(id);
            if (engine1 == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName", engine1.CarModelID);
            return View(engine1);
        }

        // POST: Engine1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "EngineID,EngineName,EngineHPRating,EngineTorque,CarModelID,Price")] Engine1 engine1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(engine1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName", engine1.CarModelID);
            return View(engine1);
        }

        // GET: Engine1/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Engine1 engine1 = db.Engine1.Find(id);
            if (engine1 == null)
            {
                return HttpNotFound();
            }
            return View(engine1);
        }

        // POST: Engine1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Engine1 engine1 = db.Engine1.Find(id);
            db.Engine1.Remove(engine1);
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
