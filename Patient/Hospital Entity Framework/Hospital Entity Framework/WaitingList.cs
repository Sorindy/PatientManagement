//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital_Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class WaitingList
    {
        public WaitingList()
        {
            this.TempWaitingLists = new HashSet<TempWaitingList>();
            this.ConsultationCategories = new HashSet<ConsultationCategory>();
            this.LaboratoryCategories = new HashSet<LaboratoryCategory>();
            this.MedicalImagingCategories = new HashSet<MedicalImagingCategory>();
            this.PrescriptionCategories = new HashSet<PrescriptionCategory>();
            this.VariousDocumentCategories = new HashSet<VariousDocumentCategory>();
        }
    
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int VisitId { get; set; }
        public int VisitCount { get; set; }
        public System.TimeSpan Time { get; set; }
        public Nullable<bool> Status { get; set; }
        public int Number { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual ICollection<TempWaitingList> TempWaitingLists { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual ICollection<ConsultationCategory> ConsultationCategories { get; set; }
        public virtual ICollection<LaboratoryCategory> LaboratoryCategories { get; set; }
        public virtual ICollection<MedicalImagingCategory> MedicalImagingCategories { get; set; }
        public virtual ICollection<PrescriptionCategory> PrescriptionCategories { get; set; }
        public virtual ICollection<VariousDocumentCategory> VariousDocumentCategories { get; set; }
    }
}
