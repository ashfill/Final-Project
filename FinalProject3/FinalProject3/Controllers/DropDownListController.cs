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
    }
}