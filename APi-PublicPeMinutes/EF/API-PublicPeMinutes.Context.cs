﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APi_PublicPeMinutes.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PEMinutesEntities : DbContext
    {
        public PEMinutesEntities()
            : base("name=PEMinutesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EnteredPeMinute> EnteredPeMinutes { get; set; }
        public virtual DbSet<MinutesAdmin> MinutesAdmins { get; set; }
        public virtual DbSet<SchoolTeachersWithADLogin> SchoolTeachersWithADLogins { get; set; }
        public virtual DbSet<SchoolToPrincipal> SchoolToPrincipals { get; set; }
        public virtual DbSet<SubMinute> SubMinutes { get; set; }
        public virtual DbSet<SchoolName> SchoolNames { get; set; }
    }
}
