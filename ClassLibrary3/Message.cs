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
    
    public partial class Message
    {
        public int MessageID { get; set; }
        public int UserID { get; set; }
        public System.DateTime MessageDate { get; set; }
        public string From { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message1 { get; set; }
        public Nullable<bool> Active { get; set; }
        public string LastUpdateID { get; set; }
        public System.DateTime LastUpdateTimeStamp { get; set; }
    }
}