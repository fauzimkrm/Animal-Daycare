﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Daycare
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_daycareContextEntities : DbContext
    {
        public db_daycareContextEntities()
            : base("name=db_daycareContextEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Daycares> Daycares { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Pet_Types> Pet_Types { get; set; }
        public virtual DbSet<Pets> Pets { get; set; }
        public virtual DbSet<Pickups> Pickups { get; set; }
    }
}