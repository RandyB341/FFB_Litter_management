//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary3
{
    using System;
    using System.Collections.Generic;
    
    public partial class DogSalePayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DogSalePayment()
        {
            this.DogSalePaymentDocuments = new HashSet<DogSalePaymentDocument>();
        }
    
        public int DogSalePayID { get; set; }
        public int DogSalesID { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime DateReceived { get; set; }
        public Nullable<bool> Active { get; set; }
        public string LastUpdateID { get; set; }
        public System.DateTime LastUpdateTimeStamp { get; set; }
    
        public virtual DogSale DogSale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DogSalePaymentDocument> DogSalePaymentDocuments { get; set; }
    }
}
