//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStock.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_Satishlar
    {
        public int SatishID { get; set; }
        public Nullable<int> Product { get; set; }
        public Nullable<int> Customer { get; set; }
        public Nullable<byte> Number { get; set; }
        public Nullable<decimal> Cost { get; set; }
    
        public virtual TBL_Customers TBL_Customers { get; set; }
        public virtual TBL_Products TBL_Products { get; set; }
    }
}
