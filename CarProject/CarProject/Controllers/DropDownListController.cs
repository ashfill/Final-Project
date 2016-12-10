using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarProject.Models;
//namespace CarProject.Controllers
//{
    //public class DropDownListController : Controller
    //{
//        FinalProject2Entities1 db = new FinalProject2Entities1();
//        // GET: DropDownList
//        [Authorize]
//        public ActionResult Index()
//        {
//            return View();
//        }
//        [Authorize]
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
//    }
//}
