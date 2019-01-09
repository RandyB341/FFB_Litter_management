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
    
    public partial class Dog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dog()
        {
            this.DogDocuments = new HashSet<DogDocument>();
            this.DogPhotoes = new HashSet<DogPhoto>();
            this.DogSales = new HashSet<DogSale>();
            this.DogWeights = new HashSet<DogWeight>();
            this.Females_Heat = new HashSet<Females_Heat>();
        }
    
        public int DogID { get; set; }
        public string AKCDogId { get; set; }
        public string AKCDogName { get; set; }
        public Nullable<System.DateTime> AKCRegCertficateDate { get; set; }
        public string Microchip_Num { get; set; }
        public string CoatColor { get; set; }
        public string Markings { get; set; }
        public string Gender { get; set; }
        public string DogName { get; set; }
        public Nullable<int> LitterId { get; set; }
        public Nullable<int> DogOwnerID { get; set; }
        public Nullable<int> BreederID { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> EarsUpStayUpDate { get; set; }
        public Nullable<System.DateTime> DeceasedDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public string LastUpdateID { get; set; }
        public System.DateTime LastUpdateTimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DogDocument> DogDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DogPhoto> DogPhotoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DogSale> DogSales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DogWeight> DogWeights { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Females_Heat> Females_Heat { get; set; }
    }
}
