//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Make
    {
        public Make()
        {
            this.CarModels = new HashSet<CarModel>();
        }
    
        public int MakeID { get; set; }
        public string MakeName { get; set; }
        public int ManufacturerID { get; set; }
    
        public virtual ICollection<CarModel> CarModels { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}