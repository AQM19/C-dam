﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zoocan
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZoocanDB : DbContext
    {
        public ZoocanDB()
            : base("name=ZoocanDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Animale> Animales { get; set; }
        public virtual DbSet<Cuidadore> Cuidadores { get; set; }
        public virtual DbSet<Refugio> Refugios { get; set; }
    }
}
