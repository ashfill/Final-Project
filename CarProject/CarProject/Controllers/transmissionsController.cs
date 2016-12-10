using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarProject;

namespace CarProject.Controllers
{
    public class transmissionsController : Controller
    {
        private FinalProject2Entities3 db = new FinalProject2Entities3();

        // GET: transmissions
        [Authorize]
        public ActionResult Index()
        {
            var transmissions = db.transmissions.Include(t => t.Engine1);
            return View(transmissions.ToList());
        }

        // GET: transmissions/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            transmission transmission = db.transmissions.Find(id);
            if (transmission == null)
            {
                return HttpNotFound();
            }
            return View(transmission);
        }

        // GET: transmissions/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.EngineID = new SelectList(db.Engine1, "EngineID", "EngineName");
            return View();
        }

        // POST: transmissions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "TransmissionID,TransmissionName,TransmissionType,Price,EngineID")] transmission transmission)
        {
            if (ModelState.IsValid)
            {
                db.transmissions.Add(transmission);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EngineID = new SelectList(db.Engine1, "EngineID", "EngineName", transmission.EngineID);
            return View(transmission);
        }

        // GET: transmissions/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            transmission transmission = db.transmissions.Find(id);
            if (transmission == null)
            {
                return HttpNotFound();
            }
            ViewBag.EngineID = new SelectList(db.Engine1, "EngineID", "EngineName", transmission.EngineID);
            return View(transmission);
        }

        // POST: transmissions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "TransmissionID,TransmissionName,TransmissionType,Price,EngineID")] transmission transmission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transmission).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EngineID = new SelectList(db.Engine1, "EngineID", "EngineName", transmission.EngineID);
            return View(transmission);
        }

        // GET: transmissions/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            transmission transmission = db.transmissions.Find(id);
            if (transmission == null)
            {
                return HttpNotFound();
            }
            return View(transmission);
        }

        // POST: transmissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            transmission transmission = db.transmissions.Find(id);
            db.transmissions.Remove(transmission);
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
