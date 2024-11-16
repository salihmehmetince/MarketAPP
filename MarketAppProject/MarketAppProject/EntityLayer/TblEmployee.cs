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
    
    public partial class TblEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblEmployee()
        {
            this.TblFactoryHasEmployee = new HashSet<TblFactoryHasEmployee>();
            this.TblMarketHasEmployee = new HashSet<TblMarketHasEmployee>();
            this.TblWarehouseHasEmployee = new HashSet<TblWarehouseHasEmployee>();
        }
    
        public int employeeId { get; set; }
        public string employeeIdentityNumber { get; set; }
        public string employeeName { get; set; }
        public string employeeSurname { get; set; }
        public string employeeEmail { get; set; }
        public string employeeTelephoneNumber { get; set; }
        public string employeeGender { get; set; }
        public System.DateTime employeeBirthDate { get; set; }
        public string employeeBirthPlace { get; set; }
        public string employeeAddress { get; set; }
        public int employeeRank { get; set; }
        public int employeePosition { get; set; }
        public int employeeDepartment { get; set; }
        public Nullable<decimal> employeeSalary { get; set; }
    
        public virtual TblDepartmentType TblDepartmentType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblFactoryHasEmployee> TblFactoryHasEmployee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblMarketHasEmployee> TblMarketHasEmployee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblWarehouseHasEmployee> TblWarehouseHasEmployee { get; set; }
        public virtual TblPositionType TblPositionType { get; set; }
        public virtual TblRankType TblRankType { get; set; }
    }
}