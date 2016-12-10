using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace FinalProject3.Models
{
    public class Turb
    {
        public List<SelectListItem> TurboList { get; set; }
        public List<Turb> TurboGrid { get; set; }
        public int TurboID { get; set; }
        public string TurboName { get; set; }
        public string TurboHPRating { get; set; }
        public string TurboTurbineSize{ get; set; }
        public string Price { get; set; }
    }
}