using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarProject.Models
{
    public class Vehicle
    {
        public IEnumerable<CarModel> CarModels { get; set; }
        public IEnumerable<Engine1> Engines { get; set; }
        public IEnumerable<Make> Makes { get; set; }
        public IEnumerable<Manufacturer> Manufacturers { get; set; }
        public IEnumerable<transmission> Transmissions { get; set; }
        public IEnumerable<turbo> Turbos { get; set; }
       

    }
}