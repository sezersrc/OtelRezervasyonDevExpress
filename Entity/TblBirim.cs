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
    
    public partial class TblBirim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblBirim()
        {
            this.TblUrun = new HashSet<TblUrun>();
        }
    
        public int BirimID { get; set; }
        public string BirimAd { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblUrun> TblUrun { get; set; }
    }
}
