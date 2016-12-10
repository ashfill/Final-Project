using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace CarProject.Models
{
    public class Engine
    {
        public List<SelectListItem> EngineList { get; set; }
        public List<Engine> EngineGrid { get; set; }
        public int EngineID { get; set; }
        public string EngineName { get; set; }
        public string Price { get; set; }
    }
}