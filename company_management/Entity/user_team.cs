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
    
    public partial class user_team
    {
        public int id { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<int> idTeam { get; set; }
    
        public virtual team team { get; set; }
        public virtual user user { get; set; }
    }
}