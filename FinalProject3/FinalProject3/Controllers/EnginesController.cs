using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject3.Models;

namespace FinalProject3.Controllers
{
    public class EnginesController : Controller
    {
        private FinalProject2Entities db = new FinalProject2Entities();
        // GET: Engines
        public ActionResult Index()
        {
            Engine Motor = new Engine();
            var EngineList = db.Engine1.ToList().Where(a => a.EngineName.Equals(true));

            Motor.EngineList = (from d in EngineList
                                  select new SelectListItem
                                  {
                                      Value = d.EngineID.ToString(),
                                      Text = d.EngineName
                                  }).ToList();

            var Engine = (from e in db.Engine1
                          select new Engine
                          {
                              EngineID = e.EngineID,
                              EngineName = e.EngineName,
                              Price = e.Price
                          }).ToList();

            Motor.EngineGrid = Engine;
            return View("Index", Motor);
        }
        public ActionResult Filter(int EngineID)
        {
            int? MotorID = Convert.ToInt32(EngineID);
            List<Engine> y = null;
            var engine = y;
            if (MotorID == 0)
            {
                engine = (from e in db.Engine1
                          select new Engine
                          {
                              EngineID = e.EngineID,
                              EngineName = e.EngineName,
                              Price = e.Price
                          }).ToList();
            }
            else
            {
                engine = (from e in db.Engine1
                          where e.EngineID == MotorID
                          select new Engine
                          {
                              EngineID = e.EngineID,
                              EngineName = e.EngineName,
                              Price = e.Price
                          }).ToList();
            }

            return PartialView("ShowEngines", engine);
        }
    }
}