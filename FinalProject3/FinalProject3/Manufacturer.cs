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
    
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            this.Makes = new HashSet<Make>();
        }
    
        public int ManufactuerID { get; set; }
        public string ManufactuerName { get; set; }
    
        public virtual ICollection<Make> Makes { get; set; }
    }
}