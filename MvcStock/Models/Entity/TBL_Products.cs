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
    
    public partial class TBL_Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Products()
        {
            this.TBL_Satishlar = new HashSet<TBL_Satishlar>();
        }
    
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Marka { get; set; }
        public Nullable<short> ProductCategory { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<byte> Stock { get; set; }
    
        public virtual TBL_Categories TBL_Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Satishlar> TBL_Satishlar { get; set; }
    }
}