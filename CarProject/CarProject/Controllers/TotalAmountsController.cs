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
    public class TotalAmountsController : Controller
    {
        private FinalProject3Entities1 db = new FinalProject3Entities1();

        // GET: TotalAmounts
        [Authorize]
        public ActionResult Index()
        {
            string user = User.Identity.Name;
            IEnumerable<TotalAmount> myBuilds = getvehicle.GetBuildsByUserName(user);

            var totalAmounts = db.TotalAmounts.Include(t => t.Engine1).Include(t => t.Make).Include(t => t.transmission).Include(t => t.turbo).Include(t => t.TotalCost);
            return View(myBuilds);
        }

        // GET: TotalAmounts/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        { 
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TotalAmount totalAmount = db.TotalAmounts.Find(id);
            if (totalAmount == null)
            {
                return HttpNotFound();
            }
            return View(totalAmount);
        }

        // GET: TotalAmounts/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName");
            ViewBag.EngineID = new SelectList(db.Engine1, "EngineID", "EngineName");
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName");
            ViewBag.TransmissionID = new SelectList(db.transmissions, "TransmissionID", "TransmissionName");
            ViewBag.TurboID = new SelectList(db.turboes, "TurboID", "TurboName");
            return View();
        }

        // POST: TotalAmounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "TotalAmountID,MakeID,CarModelID,EngineID,TransmissionID,TurboID,BuildUser,")] TotalAmount totalAmount)
        {
            if (ModelState.IsValid)
            {
                totalAmount.BuildUser = User.Identity.Name;
                db.TotalAmounts.Add(totalAmount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName", totalAmount.CarModelID);
            ViewBag.EngineID = new SelectList(db.Engine1, "EngineID", "EngineName", totalAmount.EngineID);
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName", totalAmount.MakeID);
            ViewBag.TransmissionID = new SelectList(db.transmissions, "TransmissionID", "TransmissionName", totalAmount.TransmissionID);
            ViewBag.TurboID = new SelectList(db.turboes, "TurboID", "TurboName", totalAmount.TurboID);
            return View(totalAmount);
        }

        // GET: TotalAmounts/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TotalAmount totalAmount = db.TotalAmounts.Find(id);
            if (totalAmount == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName", totalAmount.CarModelID);
            ViewBag.EngineID = new SelectList(db.Engine1, "EngineID", "EngineName", totalAmount.EngineID);
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName", totalAmount.MakeID);
            ViewBag.TransmissionID = new SelectList(db.transmissions, "TransmissionID", "TransmissionName", totalAmount.TransmissionID);
            ViewBag.TurboID = new SelectList(db.turboes, "TurboID", "TurboName", totalAmount.TurboID);
            return View(totalAmount);
        }

        // POST: TotalAmounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "TotalAmountID,MakeID,CarModelID,EngineID,TransmissionID,TurboID,BuildUser")] TotalAmount totalAmount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(totalAmount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName", totalAmount.CarModelID);
            ViewBag.EngineID = new SelectList(db.Engine1, "EngineID", "EngineName", totalAmount.EngineID);
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName", totalAmount.MakeID);
            ViewBag.TransmissionID = new SelectList(db.transmissions, "TransmissionID", "TransmissionName", totalAmount.TransmissionID);
            ViewBag.TurboID = new SelectList(db.turboes, "TurboID", "TurboName", totalAmount.TurboID);
            return View(totalAmount);
        }

        // GET: TotalAmounts/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TotalAmount totalAmount = db.TotalAmounts.Find(id);
            if (totalAmount == null)
            {
                return HttpNotFound();
            }
            return View(totalAmount);
        }

        // POST: TotalAmounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            TotalAmount totalAmount = db.TotalAmounts.Find(id);
            db.TotalAmounts.Remove(totalAmount);
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
