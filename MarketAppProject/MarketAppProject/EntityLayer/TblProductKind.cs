//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketAppProject.EntityLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblProductKind
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblProductKind()
        {
            this.TblProductTemplate = new HashSet<TblProductTemplate>();
        }
    
        public int productKindId { get; set; }
        public string productKindName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblProductTemplate> TblProductTemplate { get; set; }
    }
}
