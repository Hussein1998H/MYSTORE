//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MYSTORE.M_EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.purchases_Detile = new HashSet<purchases_Detile>();
            this.Sale_Detile = new HashSet<Sale_Detile>();
        }
    
        public int Prod_ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> Net_Price { get; set; }
        public Nullable<double> Sale_price { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public byte[] image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<purchases_Detile> purchases_Detile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale_Detile> Sale_Detile { get; set; }
    }
}
