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
    
    public partial class TblDepartmentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblDepartmentType()
        {
            this.TblEmployee = new HashSet<TblEmployee>();
        }
    
        public int departmentTypeId { get; set; }
        public string departmentTypeName { get; set; }
        public decimal departmentTypeSalaryFactor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblEmployee> TblEmployee { get; set; }
    }
}
