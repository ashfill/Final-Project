using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject1;

namespace FinalProject1.Controllers
{
    public class TurboesController : Controller
    {
        private Final_ProjectEntities db = new Final_ProjectEntities();

        // GET: Turboes
        public ActionResult Index()
        {
            return View(db.Turboes.ToList());
        }

        // GET: Turboes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turbo turbo = db.Turboes.Find(id);
            if (turbo == null)
            {
                return HttpNotFound();
            }
            return View(turbo);
        }

        // GET: Turboes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turboes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TurboID,TurboManufacturer,PSIRating,TurboSize")] Turbo turbo)
        {
            if (ModelState.IsValid)
            {
                db.Turboes.Add(turbo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(turbo);
        }

        // GET: Turboes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turbo turbo = db.Turboes.Find(id);
            if (turbo == null)
            {
                return HttpNotFound();
            }
            return View(turbo);
        }

        // POST: Turboes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TurboID,TurboManufacturer,PSIRating,TurboSize")] Turbo turbo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turbo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turbo);
        }

        // GET: Turboes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turbo turbo = db.Turboes.Find(id);
            if (turbo == null)
            {
                return HttpNotFound();
            }
            return View(turbo);
        }

        // POST: Turboes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Turbo turbo = db.Turboes.Find(id);
            db.Turboes.Remove(turbo);
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
