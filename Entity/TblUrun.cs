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
    
    public partial class TblUrun
    {
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public Nullable<int> UrunGrup { get; set; }
        public Nullable<int> Birim { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<decimal> Toplam { get; set; }
        public Nullable<byte> Kdv { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblBirim TblBirim { get; set; }
        public virtual TblDurum TblDurum { get; set; }
        public virtual TblDurum TblDurum1 { get; set; }
        public virtual TblUrunGrup TblUrunGrup { get; set; }
    }
}