﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class watermentdbEntities : DbContext
    {
        public watermentdbEntities()
            : base("name=watermentdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alarms> alarms { get; set; }
        public virtual DbSet<continents> continents { get; set; }
        public virtual DbSet<countries> countries { get; set; }
        public virtual DbSet<equipments> equipments { get; set; }
        public virtual DbSet<facilities> facilities { get; set; }
        public virtual DbSet<FacilityStatus> FacilityStatus { get; set; }
        public virtual DbSet<locations> locations { get; set; }
        public virtual DbSet<maintenance> maintenance { get; set; }
        public virtual DbSet<measurements> measurements { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserClaim> UserClaim { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Client_Conection> Client_Conection { get; set; }
        public virtual DbSet<countries_with_facilites_view> countries_with_facilites_view { get; set; }
    }
}
