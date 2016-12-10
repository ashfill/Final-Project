using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject3.Models
{
    public class Names
    {
        public IEnumerable<CarModel> CarModels { get; set; }
        public IEnumerable<Engine1> Engines { get; set; }
        public IEnumerable<Make> Makes { get; set; }
        public IEnumerable<Manufacturer> Manufacturers { get; set; }
        public IEnumerable<transmission> Transmissions { get; set; }
        public IEnumerable<turbo> Turbos { get; set; }
       
       public int ManufacturerID { get; set; }
       public int MakeID { get; set; }
       public int EngineID { get; set; }
       public int TransmissionID { get; set; }
       public int TurboID { get; set; } 
    }
}


