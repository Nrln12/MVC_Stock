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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MvcDbStockEntities : DbContext
    {
        public MvcDbStockEntities()
            : base("name=MvcDbStockEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBL_Categories> TBL_Categories { get; set; }
        public virtual DbSet<TBL_Customers> TBL_Customers { get; set; }
        public virtual DbSet<TBL_Products> TBL_Products { get; set; }
        public virtual DbSet<TBL_Satishlar> TBL_Satishlar { get; set; }
    }
}
