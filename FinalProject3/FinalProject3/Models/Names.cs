using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject3.Models
{
    public class Names
    {
        public IList<SelectListItem> CarModelName { get; set; }
        public IList<SelectListItem> EngineName { get; set; }
        public IList<SelectListItem> MakeName { get; set; }
        public IList<SelectListItem> ManufacturerName { get; set; }
    }
}