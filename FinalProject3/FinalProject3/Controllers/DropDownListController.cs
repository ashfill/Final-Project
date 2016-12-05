using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject3.Models;

namespace FinalProject3.Controllers
{
    public class DropDownListController : Controller
    {
        FinalProject2Entities db = new FinalProject2Entities();
        public ActionResult Index()
        {
            List<SelectListItem> manufacturerName = new List<SelectListItem>();
            Names ClassModel = new Names();

            List<Manufacturer> manu = db.Manufacturers.ToList();
            manu.ForEach(x =>
            {
                manufacturerName.Add(new SelectListItem { Text = x.ManufactuerName, Value = x.ManufactuerID.ToString() });
            });
            ClassModel.ManufacturerName = manufacturerName;
            return View(ClassModel);
        }
        //public ActionResult GetInfo()
        //{
        //    Names Cool = new Names();

        //    FinalProject2Entities db = new FinalProject2Entities();
        //    Cool.CarModel = db.CarModels.ToList();
        //    Cool.Engine = db.Engine1.ToList();
        //    Cool.Make = db.Makes.ToList();
        //    Cool.Manufacturer = db.Manufacturers.ToList();
        //    return View(Cool);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult GetInfo(FormCollection form)
        //{
        //    string car = form["CarModel"].ToString();
        //    string Eng = form["Engine1"].ToString();
        //    string Mak = form["Make"].ToString();
        //    string man = form["Manufacturer"].ToString();
        //    return RedirectToAction("GetInfo", new { cor = car, rng = Eng, rak = Mak, nan = man });
        //}
        //public ActionResult GetCar(string cor, string rng, string rak, string nan)
        //{
        //    Names Cool = new Models.Names();

        //}
        [HttpPost]
        public ActionResult GetMake(string manufacturerID)
        {
            int manufID;
            List<SelectListItem> makeNames = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(manufacturerID))
            {
                manufID = Convert.ToInt32(manufacturerID);
                List<Make> makes = db.Makes.Where(x => x.ManufacturerID == manufID).ToList();
                makes.ForEach(x =>
                {
                    makeNames.Add(new SelectListItem { Text = x.MakeName, Value = x.MakeID.ToString() });
                });

            }
            return Json(makeNames, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult GetModel(string makeID)
        {
            int makID;
            List<SelectListItem> CarNames = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(makeID))
            {
                makID = Convert.ToInt32(makeID);
                List<CarModel> car = db.CarModels.Where(x => x.MakeID == makID).ToList();
                car.ForEach(x =>
                {
                    CarNames.Add(new SelectListItem { Text = x.CarModelName, Value = x.CarModelID.ToString() });
                });

            }
            return Json(CarNames, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult GetEngine(string CarModelID)
        {
            int CMID;
            List<SelectListItem> EngineNames = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(CarModelID))
            {
                CMID = Convert.ToInt32(CarModelID);
                List<Engine1> Engines = db.Engine1.Where(x => x.CarModelID == CMID).ToList();
                Engines.ForEach(x =>
                {
                    EngineNames.Add(new SelectListItem { Text = x.EngineName, Value = x.EngineID.ToString() });
                });

            }
            return Json(EngineNames, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult GetTransmission(string EngineID)
        {
            int ENID;
            List<SelectListItem> TransNames = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(EngineID))
            {
                ENID = Convert.ToInt32(EngineID);
                List<transmission> Tans = db.transmissions.Where(x => x.EngineID == ENID).ToList();
                Tans.ForEach(x =>
                {
                    TransNames.Add(new SelectListItem { Text = x.TransmissionName, Value = x.TransmissionID.ToString() });
                });

            }
            return Json(TransNames, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult GetTurbo(string TransmissionID)
        {
            int TSID;
            List<SelectListItem> TurboNames = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(TransmissionID))
            {
                TSID = Convert.ToInt32(TransmissionID);
                List<turbo> Turs = db.turboes.Where(x => x.TransmissionID == TSID).ToList();
                Turs.ForEach(x =>
                {
                    TurboNames.Add(new SelectListItem { Text = x.TurboName, Value = x.TurboID.ToString() });
                });

            }
            return Json(TurboNames, JsonRequestBehavior.AllowGet);
        }
        //public ActionResult GetInfo()
        //{
        //    Names Cool = new Names();

        //    Cool.CarModelName = db.CarModels.ToList();
        //    Cool.EngineName = db.Engine1.ToList();
        //    Cool.MakeName = db.Makes.ToList();
        //    Cool.ManufacturerName = db.Manufacturers.ToList();
        //    return View(Cool);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult GetInfo(FormCollection form)
        //{
        //    string car = form["CarModel"].ToString();
        //    string Eng = form["Engine1"].ToString();
        //    string Mak = form["Make"].ToString();
        //    string man = form["Manufacturer"].ToString();
        //    return RedirectToAction("Index", new { cor = car, rng = Eng, rak = Mak, nan = man });
        //}
    }
}