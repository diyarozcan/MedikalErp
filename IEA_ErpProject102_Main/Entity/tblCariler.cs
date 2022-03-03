//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEA_ErpProject102_Main.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCariler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCariler()
        {
            this.tblPersonelDetay = new HashSet<tblPersonelDetay>();
            this.tblUrunler = new HashSet<tblUrunler>();
            this.tblStokGirisUst = new HashSet<tblStokGirisUst>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CariGrupId { get; set; }
        public Nullable<int> CariTipId { get; set; }
        public string CariAdi { get; set; }
        public string CariUnvan { get; set; }
        public string Adres1 { get; set; }
        public string Adres2 { get; set; }
        public string VDairesi { get; set; }
        public string VnoTcno { get; set; }
        public Nullable<int> SehirId { get; set; }
        public string CariTel { get; set; }
        public string CariMail { get; set; }
        public string YetkiliAdi1 { get; set; }
        public string YetkiliAdi2 { get; set; }
        public string YetkiliAdi3 { get; set; }
        public string YetkiliDep1 { get; set; }
        public string YetkiliDep2 { get; set; }
        public string YetkiliDep3 { get; set; }
        public string YetkiliTel1 { get; set; }
        public string YetkiliTel2 { get; set; }
        public string YetkiliTel3 { get; set; }
        public string YetkiliCep1 { get; set; }
        public string YetkiliCep2 { get; set; }
        public string YetkiliCep3 { get; set; }
        public string YetkiliMail1 { get; set; }
        public string YetkiliMail2 { get; set; }
        public string YetkiliMail3 { get; set; }
        public Nullable<int> SaveUserId { get; set; }
        public Nullable<int> UpdateUserId { get; set; }
        public Nullable<System.DateTime> SaveDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CariKodu { get; set; }
        public Nullable<System.DateTime> GirisTarihi { get; set; }
        public Nullable<System.DateTime> CikisTarihi { get; set; }
    
        public virtual tblCariGruplari tblCariGruplari { get; set; }
        public virtual tblSehirler tblSehirler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPersonelDetay> tblPersonelDetay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUrunler> tblUrunler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStokGirisUst> tblStokGirisUst { get; set; }
    }
}