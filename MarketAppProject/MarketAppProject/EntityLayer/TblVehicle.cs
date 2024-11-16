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
    
    public partial class TblVehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblVehicle()
        {
            this.TblFactoryHasVehicle = new HashSet<TblFactoryHasVehicle>();
            this.TblFactorySendsProductToMarket = new HashSet<TblFactorySendsProductToMarket>();
            this.TblFactorySendsProductToWarehouse = new HashSet<TblFactorySendsProductToWarehouse>();
            this.TblMarketHasVehicle = new HashSet<TblMarketHasVehicle>();
            this.TblWarehouseSendsToMarket = new HashSet<TblWarehouseSendsToMarket>();
            this.TblWarehouseHasVehicle = new HashSet<TblWarehouseHasVehicle>();
        }
    
        public int vehicleId { get; set; }
        public string vehiclePlateNumber { get; set; }
        public string vehicleSerialNumber { get; set; }
        public int vehicleType { get; set; }
        public int vehicleBrand { get; set; }
        public int vehicleModel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblFactoryHasVehicle> TblFactoryHasVehicle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblFactorySendsProductToMarket> TblFactorySendsProductToMarket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblFactorySendsProductToWarehouse> TblFactorySendsProductToWarehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblMarketHasVehicle> TblMarketHasVehicle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblWarehouseSendsToMarket> TblWarehouseSendsToMarket { get; set; }
        public virtual TblVehicleBrand TblVehicleBrand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblWarehouseHasVehicle> TblWarehouseHasVehicle { get; set; }
        public virtual TblVehicleModel TblVehicleModel { get; set; }
        public virtual TblVehicleType TblVehicleType { get; set; }
    }
}