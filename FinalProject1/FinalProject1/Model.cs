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
    
    public partial class Model
    {
        public Model()
        {
            this.Makes = new HashSet<Make>();
            this.Engines = new HashSet<Engine>();
        }
    
        public int ModelID { get; set; }
        public string ModelName { get; set; }
    
        public virtual ICollection<Make> Makes { get; set; }
        public virtual ICollection<Engine> Engines { get; set; }
    }
}
