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
        private FinalProject2Entities3 db = new FinalProject2Entities3();

        // GET: TotalAmounts
        [Authorize]
        public ActionResult Index()
        {
           

            var totalAmounts = db.TotalAmounts.Include(t => t.Engine1).Include(t => t.Make).Include(t => t.Manufacturer).Include(t => t.transmission).Include(t => t.turbo);
            return View(db.TotalAmounts.ToList());
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
            TotalAmount Car = new TotalAmount();
            //ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName");
            ViewBag.Engine1ID = new SelectList(db.Engine1, "EngineID", "EngineName");
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName");
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufactuerID", "ManufactuerName");
            ViewBag.TransmissionID = new SelectList(db.transmissions, "TransmissionID", "TransmissionName");
            ViewBag.TurboID = new SelectList(db.turboes, "TurboID", "TurboName");

            //var myProperties = (from BulUser in db.TotalAmounts
            //                    join tol in db.BuildUsers on BulUser.BuildUserID equals tol.BuildUserID
            //                    where BulUser.BuildUserID == tol.BuildUserID && tol.BuildUserAuthKey == User.Identity.Name
            //                    select tol).FirstOrDefault();

            return View();
        }

        // POST: TotalAmounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "ManufacturerID,MakeID,Engine1ID,TransmissionID,TurboID,BuildUser")] TotalAmount totalAmount)
        {
            if (ModelState.IsValid)
            {

                totalAmount.BuildUser = User.Identity.Name; 

                db.TotalAmounts.Add(totalAmount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            

            //ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName", totalAmount.CarModelID);
            ViewBag.Engine1ID = new SelectList(db.Engine1, "EngineID", "EngineName", totalAmount.Engine1ID);
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName", totalAmount.MakeID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufactuerID", "ManufactuerName", totalAmount.ManufacturerID);
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
            //ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName", totalAmount.CarModelID);
            ViewBag.Engine1ID = new SelectList(db.Engine1, "EngineID", "EngineName", totalAmount.Engine1ID);
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName", totalAmount.MakeID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufactuerID", "ManufactuerName", totalAmount.ManufacturerID);
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
        public ActionResult Edit([Bind(Include = "ManufacturerID,MakeID,Engine1ID,TransmissionID,TurboID,BuildUser")] TotalAmount totalAmount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(totalAmount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.CarModelID = new SelectList(db.CarModels, "CarModelID", "CarModelName", totalAmount.CarModelID);
            ViewBag.Engine1ID = new SelectList(db.Engine1, "EngineID", "EngineName", totalAmount.Engine1ID);
            ViewBag.MakeID = new SelectList(db.Makes, "MakeID", "MakeName", totalAmount.MakeID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers, "ManufactuerID", "ManufactuerName", totalAmount.ManufacturerID);
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
        //[Authorize]
        //        public ActionResult GetParts()
        //        {
        //            GetVehicle Cool = new GetVehicle();

        //            FinalProject2Entities1 db = new FinalProject2Entities1();
        //            Cool.Manufacturers = db.Manufacturers.ToList();
        //            Cool.Makes = db.Makes.ToList();
        //            Cool.Engines = db.Engine1.ToList();
        //            Cool.Transmissions = db.transmissions.ToList();
        //            Cool.Turbos = db.turboes.ToList();

        //            return View(Cool);
        //        }

        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        [Authorize]
        //        public ActionResult Getparts()
        //        {
        //            //string manufacturers = db.Manufacturers.ToString();
        //            string makes = db.Makes.ToString();
        //            string engines = db.Engine1.ToString();
        //            string transmissions = db.transmissions.ToString();
        //            string turbos = db.turboes.ToString();

        //            return RedirectToAction("Index");
        //        }

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
