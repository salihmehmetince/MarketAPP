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
    
    public partial class TblRankType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblRankType()
        {
            this.TblEmployee = new HashSet<TblEmployee>();
        }
    
        public int rankTypeId { get; set; }
        public string rankTypeName { get; set; }
        public decimal rankTypeSalaryValue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblEmployee> TblEmployee { get; set; }
    }
}
