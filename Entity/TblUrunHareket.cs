//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class TblUrunHareket
    {
        public int Hareketid { get; set; }
        public Nullable<int> Urun { get; set; }
        public string HareketTuru { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Aciklama { get; set; }
    
        public virtual TblUrun TblUrun { get; set; }
    }
}