﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab_5___Nisses_stugby
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Group2Entities_ : DbContext
    {
        public Group2Entities_()
            : base("name=Group2Entities_")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cabins> Cabins { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
