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
    
    public partial class Referrer
    {
        public Referrer()
        {
            this.ConsultationEstimates = new HashSet<ConsultationEstimate>();
            this.LaboratoryEstimates = new HashSet<LaboratoryEstimate>();
            this.MedicalImagingEstimates = new HashSet<MedicalImagingEstimate>();
            this.PrescriptionEstimates = new HashSet<PrescriptionEstimate>();
            this.VariousDocumentEstimates = new HashSet<VariousDocumentEstimate>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public string WorkPlace { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public bool Available { get; set; }
    
        public virtual ICollection<ConsultationEstimate> ConsultationEstimates { get; set; }
        public virtual ICollection<LaboratoryEstimate> LaboratoryEstimates { get; set; }
        public virtual ICollection<MedicalImagingEstimate> MedicalImagingEstimates { get; set; }
        public virtual ICollection<PrescriptionEstimate> PrescriptionEstimates { get; set; }
        public virtual ICollection<VariousDocumentEstimate> VariousDocumentEstimates { get; set; }
    }
}
