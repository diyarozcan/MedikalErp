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
    
    public partial class tblStokGirisUst
    {
        public int Id { get; set; }
        public Nullable<int> GenelNo { get; set; }
        public Nullable<int> CariGrupId { get; set; }
        public Nullable<int> CariAdiId { get; set; }
        public Nullable<int> GirisTipi { get; set; }
        public string FaturaNo { get; set; }
        public string Aciklama { get; set; }
        public Nullable<System.DateTime> SaveDate { get; set; }
        public Nullable<int> SaveUserId { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdateUserId { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<System.DateTime> FaturaTarih { get; set; }
    
        public virtual tblCariGruplari tblCariGruplari { get; set; }
        public virtual tblCariler tblCariler { get; set; }
    }
}
