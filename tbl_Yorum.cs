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
    
    public partial class tbl_Yorum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Yorum()
        {
            this.tbl_AltYorum = new HashSet<tbl_AltYorum>();
        }
    
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public int HaberId { get; set; }
        public string Yorum { get; set; }
        public System.DateTime YorumTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AltYorum> tbl_AltYorum { get; set; }
        public virtual tbl_Haberler tbl_Haberler { get; set; }
        public virtual tbl_Kullanici tbl_Kullanici { get; set; }
    }
}