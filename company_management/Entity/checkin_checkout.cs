//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace company_management.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class checkin_checkout
    {
        public int id { get; set; }
        public int idUser { get; set; }
        public System.DateTime checkinTime { get; set; }
        public Nullable<System.DateTime> checkoutTime { get; set; }
        public Nullable<double> totalHours { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual user user { get; set; }
    }
}
