//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatermentWebSCADA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class users_has_facilities
    {
        public int Id { get; set; }
        public int users_Id { get; set; }
        public int facilities_Id { get; set; }
    
        public virtual facilities facilities { get; set; }
        public virtual User User { get; set; }
    }
}
