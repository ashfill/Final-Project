//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        public int CarID { get; set; }
        public int ManufacturerID { get; set; }
        public int MakeID { get; set; }
        public int CarModelID { get; set; }
        public int EngineID { get; set; }
        public int TransmissionID { get; set; }
        public int TurboID { get; set; }
    
        public virtual CarModel1 CarModel1 { get; set; }
        public virtual Engine Engine { get; set; }
        public virtual Make Make { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Transmission Transmission { get; set; }
        public virtual Turbo Turbo { get; set; }
    }
}
