//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaberPortali_H5190062
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Haberler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Haberler()
        {
            this.tbl_Begeni = new HashSet<tbl_Begeni>();
            this.tbl_Yorum = new HashSet<tbl_Yorum>();
            this.tbl_Okunma = new HashSet<tbl_Okunma>();
        }
    
        public int Id { get; set; }
        public string HaberBaslik { get; set; }
        public string HaberAltbaslik { get; set; }
        public string HaberYazisi { get; set; }
        public Nullable<System.DateTime> YayinTarihi { get; set; }
        public Nullable<int> KullaniciId { get; set; }
        public Nullable<int> KategoriId { get; set; }
        public string HaberResim { get; set; }
        public string HaberTuru { get; set; }
        public string Durum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Begeni> tbl_Begeni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Yorum> tbl_Yorum { get; set; }
        public virtual tbl_Kategori tbl_Kategori { get; set; }
        public virtual tbl_Kullanici tbl_Kullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Okunma> tbl_Okunma { get; set; }
    }
}
