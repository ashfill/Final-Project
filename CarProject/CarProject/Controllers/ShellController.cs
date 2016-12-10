using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarProject.Models;

namespace CarProject.Controllers
{
    public class ShellController : Controller
    {
        private FinalProject2Entities3 db = new FinalProject2Entities3();
        // GET: Shell
        [Authorize]
        public ActionResult Index()
        {
            Shell Chasis = new Shell();
            var CarList = db.CarModels.ToList().Where(a => a.CarModelName.Equals(true));

            Chasis.CarModelList = (from d in CarList
                                   select new SelectListItem
                                   {
                                       Value = d.CarModelID.ToString(),
                                       Text = d.CarModelName
                                   }).ToList();

            var Shell = (from e in db.CarModels
                         select new Shell
                         {
                             CarModelID = e.CarModelID,
                             CarModelName = e.CarModelName,
                             Price = e.Price
                         }).ToList();

            Chasis.ShellGrid = Shell;

            return View("Index", Chasis);
        }


        [Authorize]
        public ActionResult Filter(int CarModelID)
        {
            int? CarID = Convert.ToInt32(CarModelID);
            List<Shell> y = null;
            var kk = y;
            if (CarID == 0)
            {
                kk = (from e in db.CarModels
                      select new Shell
                      {
                          CarModelID = e.CarModelID,
                          CarModelName = e.CarModelName,
                          Price = e.Price
                      }).ToList();
            }
            else
            {
                kk = (from e in db.CarModels
                      where e.CarModelID == CarID
                      select new Shell
                      {
                          CarModelID = e.CarModelID,
                          CarModelName = e.CarModelName,
                          Price = e.Price
                      }).ToList();
            }

            return PartialView("ShowShells", kk);
        }
    }
}