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
    
    public partial class DogSalesDocument
    {
        public int DogSalesDocumentID { get; set; }
        public int DogSalesID { get; set; }
        public string FileName { get; set; }
        public string FileNameDescription { get; set; }
        public Nullable<bool> Active { get; set; }
        public string LastUpdateID { get; set; }
        public System.DateTime LastUpdateTimeStamp { get; set; }
    
        public virtual DogSale DogSale { get; set; }
    }
}