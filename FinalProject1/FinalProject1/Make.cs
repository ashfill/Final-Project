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
    
    public partial class Make
    {
        public Make()
        {
            this.Models = new HashSet<Model>();
            this.manufacturers = new HashSet<manufacturer>();
        }
    
        public int MakeID { get; set; }
        public string MakeName { get; set; }
        public int MakeYear { get; set; }
    
        public virtual ICollection<Model> Models { get; set; }
        public virtual ICollection<manufacturer> manufacturers { get; set; }
    }
}
