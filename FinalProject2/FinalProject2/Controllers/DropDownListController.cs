using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject2.Models;

namespace FinalProject2.Controllers
{
    public class DropDownListController : Controller
    {
        // GET: DropDownList
        FinalProject1Entities1 db = new FinalProject1Entities1();
        public ActionResult Index()
        {
            List<SelectListItem> manufacturerName = new List<SelectListItem>();
            Class1 ClassModel = new Class1();

            List<Manufacturer> manu = db.Manufacturers.ToList();
            manu.ForEach(x =>
            {
                manufacturerName.Add(new SelectListItem { Text = x.ManufacturerName, Value = x.ManufacturerID.ToString() });
            });
            ClassModel.ManufacturerName = manufacturerName;
            return View(ClassModel);
        }
        [HttpPost]
        public ActionResult GetMake(string manufacturerID)
        {
            int manufID;
            List<SelectListItem> makeNames = new List<SelectListItem>();
            if(!string.IsNullOrEmpty(manufacturerID))
            {
                manufID = Convert.ToInt32(manufacturerID);
                List<Make> makes = db.Makes.Where(x => x.ManufacturerID == manufID).ToList();
            }
            return null;
        }
    }
}