//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cbhproj.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VehicleMake
    {
        public System.Guid VMakeID { get; set; }
        public int VMakeCode { get; set; }
        public string VMakeName { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}
