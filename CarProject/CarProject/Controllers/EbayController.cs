using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarProject.Models;

namespace CarProject.Controllers
{
    public class EbayController : Controller
    {
        // GET: Ebay
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetEbaySearch()
        {
            Ebays myebay = new Ebays();
            return Json(myebay.GetSearch(), JsonRequestBehavior.AllowGet);
        }
    }
}