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
    public class turboesController : Controller
    {
        private FinalProject2Entities3 db = new FinalProject2Entities3();

        // GET: turboes
        [Authorize]
        public ActionResult Index()
        {
            var turboes = db.turboes.Include(t => t.transmission);
            return View(turboes.ToList());
        }

        // GET: turboes/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            turbo turbo = db.turboes.Find(id);
            if (turbo == null)
            {
                return HttpNotFound();
            }
            return View(turbo);
        }

        // GET: turboes/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.TransmissionID = new SelectList(db.transmissions, "TransmissionID", "TransmissionName");
            return View();
        }

        // POST: turboes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "TurboID,TurboName,TurboHPRating,TurboTurbineSize,TransmissionID,Price")] turbo turbo)
        {
            if (ModelState.IsValid)
            {
                db.turboes.Add(turbo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TransmissionID = new SelectList(db.transmissions, "TransmissionID", "TransmissionName", turbo.TransmissionID);
            return View(turbo);
        }

        // GET: turboes/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            turbo turbo = db.turboes.Find(id);
            if (turbo == null)
            {
                return HttpNotFound();
            }
            ViewBag.TransmissionID = new SelectList(db.transmissions, "TransmissionID", "TransmissionName", turbo.TransmissionID);
            return View(turbo);
        }

        // POST: turboes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "TurboID,TurboName,TurboHPRating,TurboTurbineSize,TransmissionID,Price")] turbo turbo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turbo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TransmissionID = new SelectList(db.transmissions, "TransmissionID", "TransmissionName", turbo.TransmissionID);
            return View(turbo);
        }

        // GET: turboes/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            turbo turbo = db.turboes.Find(id);
            if (turbo == null)
            {
                return HttpNotFound();
            }
            return View(turbo);
        }

        // POST: turboes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            turbo turbo = db.turboes.Find(id);
            db.turboes.Remove(turbo);
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
