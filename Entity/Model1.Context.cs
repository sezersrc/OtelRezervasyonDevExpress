﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelRezervasyonDevEx.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbOtelDevExEntities : DbContext
    {
        public DbOtelDevExEntities()
            : base("name=DbOtelDevExEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblBirim> TblBirim { get; set; }
        public virtual DbSet<TblDepartman> TblDepartman { get; set; }
        public virtual DbSet<TblDurum> TblDurum { get; set; }
        public virtual DbSet<TblGorev> TblGorev { get; set; }
        public virtual DbSet<TblKasa> TblKasa { get; set; }
        public virtual DbSet<TblKur> TblKur { get; set; }
        public virtual DbSet<TblMisafir> TblMisafir { get; set; }
        public virtual DbSet<TblOda> TblOda { get; set; }
        public virtual DbSet<TblPersonel> TblPersonel { get; set; }
        public virtual DbSet<TblTelefon> TblTelefon { get; set; }
        public virtual DbSet<TblUkle> TblUkle { get; set; }
        public virtual DbSet<TblUrun> TblUrun { get; set; }
        public virtual DbSet<TblUrunGrup> TblUrunGrup { get; set; }
    }
}