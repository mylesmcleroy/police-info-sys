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
    
    public partial class License
    {
        public System.Guid LicenseID { get; set; }
        public string LicenseCode { get; set; }
        public int LicenseState { get; set; }
        public int LicenseCounty { get; set; }
        public string LicenseStatus { get; set; }
        public string LicenseClass { get; set; }
        public string LicenseRestrictions { get; set; }
        public string LicenseEndorsements { get; set; }
        public System.DateTime LicenseIssue { get; set; }
        public System.DateTime LicenseExpiration { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdate { get; set; }
    }
}
