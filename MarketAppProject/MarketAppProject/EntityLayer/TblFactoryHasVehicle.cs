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
    
    public partial class TblFactoryHasVehicle
    {
        public int factoryHasVehicleId { get; set; }
        public int factoryId { get; set; }
        public int vehicleId { get; set; }
        public long vehiclePurchaseMilAge { get; set; }
        public decimal vehiclePurchasePrice { get; set; }
        public System.DateTime vehiclePurchaseDate { get; set; }
    
        public virtual TblFactory TblFactory { get; set; }
        public virtual TblVehicle TblVehicle { get; set; }
    }
}
