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
    
    public partial class TblWareHouseHasEquipment
    {
        public int warehouseHasequipmentId { get; set; }
        public int warehouseId { get; set; }
        public int equipmentId { get; set; }
        public System.DateTime purchaseDate { get; set; }
        public decimal purchasePrice { get; set; }
    
        public virtual TblEquipment TblEquipment { get; set; }
        public virtual TblWarehouse TblWarehouse { get; set; }
    }
}
