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
    using System.ComponentModel.DataAnnotations;

    public partial class TBL_Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Customers()
        {
            this.TBL_Satishlar = new HashSet<TBL_Satishlar>();
        }
    
        public int CustomerID { get; set; }
        [Required(ErrorMessage ="This field is required!")]
        [StringLength(50,ErrorMessage ="The longest length is 50")]
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Satishlar> TBL_Satishlar { get; set; }
    }
}
