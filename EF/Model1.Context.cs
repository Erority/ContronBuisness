﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoontrolBuisnesTile.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BeControlDBEntities : DbContext
    {
        public BeControlDBEntities()
            : base("name=BeControlDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Busyness> Busyness { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<WorkTraffic> WorkTraffic { get; set; }
    }
}
