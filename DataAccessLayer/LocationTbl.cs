//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFrmEF_DBFirst.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class LocationTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocationTbl()
        {
            this.PhoneNumberTbls = new HashSet<PhoneNumberTbl>();
        }
    
        public int Id { get; set; }
        public Nullable<decimal> Location_Lat { get; set; }
        public Nullable<decimal> Location_Lat1 { get; set; }
        public string Address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhoneNumberTbl> PhoneNumberTbls { get; set; }
    }
}