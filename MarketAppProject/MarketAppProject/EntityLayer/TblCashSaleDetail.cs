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
    
    public partial class TblCashSaleDetail
    {
        public int cashSaleDetailId { get; set; }
        public int cashSaleId { get; set; }
        public int productTemplateId { get; set; }
        public Nullable<decimal> price { get; set; }
        public long quantity { get; set; }
        public decimal productTotalPrice { get; set; }
    
        public virtual TblCustomerBuysProductWithCash TblCustomerBuysProductWithCash { get; set; }
        public virtual TblProductTemplate TblProductTemplate { get; set; }
    }
}
