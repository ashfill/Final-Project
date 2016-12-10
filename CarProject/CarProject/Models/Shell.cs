using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace CarProject.Models
{
    public class Shell
    {
        public List<SelectListItem> CarModelList { get; set; }
        public List<Shell> ShellGrid { get; set; }
        public int CarModelID { get; set; }
        public string CarModelName { get; set; }
        public string Price { get; set; }
    }
}