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
    
    public partial class DogWeight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DogWeight()
        {
            this.DogWeightDocuments = new HashSet<DogWeightDocument>();
        }
    
        public int DogWeightID { get; set; }
        public int DogID { get; set; }
        public int Weight_lbs { get; set; }
        public int Weitht_oz { get; set; }
        public System.DateTime WeightDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public string LastUpdateID { get; set; }
        public System.DateTime LastUpdateTimeStamp { get; set; }
    
        public virtual Dog Dog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DogWeightDocument> DogWeightDocuments { get; set; }
    }
}
