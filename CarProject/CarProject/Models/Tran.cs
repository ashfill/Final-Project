using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace CarProject.Models
{
    public class Tran
    {
        public List<SelectListItem> TransList { get; set; }
        public List<Tran> TransGrid { get; set; }
        public int TransmissionID { get; set; }
        public string TransmissionName { get; set; }
        public string TransmissionType { get; set; }
        public decimal Price { get; set; }
    }
}