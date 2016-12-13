using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarProject.Models;

namespace CarProject.Controllers
{
    public class TransController : Controller
    {
        private FinalProject3Entities1 db = new FinalProject3Entities1();
        // GET: Trans
        [Authorize]
        public ActionResult Index()
        {
            Tran tr = new Tran();
            var TransList = db.transmissions.ToList().Where(a => a.TransmissionName.Equals(true));

            tr.TransList = (from d in TransList
                            select new SelectListItem
                            {
                                Value = d.TransmissionID.ToString(),
                                Text = d.TransmissionName
                            }).ToList();
            var Tran = (from e in db.transmissions
                        select new Tran
                        {
                            TransmissionID = e.TransmissionID,
                            TransmissionName = e.TransmissionName,
                            TransmissionType = e.TransmissionType,
                            Price = e.Price
                        }).ToList();
            tr.TransGrid = Tran;
            return View("Index", tr);
        }
        [Authorize]
        public ActionResult Filter(int TransmissionID)
        {
            int? TransID = Convert.ToInt32(TransmissionID);
            List<Tran> y = null;
            var tran = y;
            if (TransID == 0)
            {
                tran = (from e in db.transmissions
                        select new Tran
                        {
                            TransmissionID = e.TransmissionID,
                            TransmissionName = e.TransmissionName,
                            TransmissionType = e.TransmissionType,
                            Price = e.Price
                        }).ToList();
            }
            else
            {
                tran = (from e in db.transmissions
                        where e.TransmissionID == TransID
                        select new Tran
                        {
                            TransmissionID = e.TransmissionID,
                            TransmissionName = e.TransmissionName,
                            TransmissionType = e.TransmissionType,
                            Price = e.Price
                        }).ToList();
            }

            return PartialView("ShowTrans", tran);
        }
    }
}