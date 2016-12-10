//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Engine1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Engine1()
        {
            this.TotalAmounts = new HashSet<TotalAmount>();
            this.transmissions = new HashSet<transmission>();
        }
    
        public int EngineID { get; set; }
        public string EngineName { get; set; }
        public string EngineHPRating { get; set; }
        public string EngineTorque { get; set; }
        public int CarModelID { get; set; }
        public string Price { get; set; }
    
        public virtual CarModel CarModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TotalAmount> TotalAmounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transmission> transmissions { get; set; }
    }
}
