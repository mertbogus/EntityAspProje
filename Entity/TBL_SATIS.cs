//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityAspProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_SATIS
    {
        public int SATISID { get; set; }
        public Nullable<int> URUN { get; set; }
        public Nullable<byte> PERSONEL { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
    
        public virtual TBL_MUSTERI TBL_MUSTERI { get; set; }
        public virtual TBL_PERSONEL TBL_PERSONEL { get; set; }
        public virtual TBL_URUNLER TBL_URUNLER { get; set; }
    }
}
