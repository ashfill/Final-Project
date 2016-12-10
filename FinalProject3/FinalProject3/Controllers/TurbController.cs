using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject3.Models;
namespace FinalProject3.Controllers
{
    public class TurbController : Controller
    {
        private FinalProject2Entities db = new FinalProject2Entities();
        // GET: Turb
        public ActionResult Index()
        {
            Turb turb = new Turb();
            var TurboList = db.turboes.ToList().Where(a => a.TurboName.Equals(true));

            turb.TurboList = (from d in TurboList
                                select new SelectListItem
                                {
                                    Value = d.TurboID.ToString(),
                                    Text = d.TurboName
                                }).ToList();

            var turbo = (from e in db.turboes
                          select new Turb
                          {
                              TurboID = e.TurboID,
                              TurboName = e.TurboName,
                              TurboHPRating = e.TurboHPRating,
                              TurboTurbineSize = e.TurboTurbineSize,
                              Price = e.Price
                          }).ToList();

            turb.TurboGrid = turbo;
            return View("Index", turb);
        }
        public ActionResult Filter(int TurboID)
        {
            int? TurID = Convert.ToInt32(TurboID);
            List<Turb> y = null;
            var turb = y;
            if (TurID == 0)
            {
                turb = (from e in db.turboes
                          select new Turb
                          {
                              TurboID = e.TurboID,
                              TurboName = e.TurboName,
                              TurboHPRating = e.TurboHPRating,
                              TurboTurbineSize = e.TurboTurbineSize,
                              Price = e.Price
                          }).ToList();
            }
            else
            {
                turb = (from e in db.turboes
                          where e.TurboID == TurID
                          select new Turb
                          {
                              TurboID = e.TurboID,
                              TurboName = e.TurboName,
                              TurboHPRating = e.TurboHPRating,
                              TurboTurbineSize = e.TurboTurbineSize,
                              Price = e.Price
                          }).ToList();
            }

            return PartialView("ShowTurbo", turb);
        }
    }
}