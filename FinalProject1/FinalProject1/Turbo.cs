//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Turbo
    {
        public Turbo()
        {
            this.Engines = new HashSet<Engine>();
        }
    
        public int TurboID { get; set; }
        public string TurboManufacturer { get; set; }
        public string PSIRating { get; set; }
        public string TurboSize { get; set; }
    
        public virtual ICollection<Engine> Engines { get; set; }
    }
}
