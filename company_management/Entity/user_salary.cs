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
    
    public partial class user_salary
    {
        public int id { get; set; }
        public int idUser { get; set; }
        public decimal basicSalary { get; set; }
        public Nullable<decimal> allowance { get; set; }
        public Nullable<decimal> tax { get; set; }
        public Nullable<decimal> insurance { get; set; }
    
        public virtual user user { get; set; }
    }
}
