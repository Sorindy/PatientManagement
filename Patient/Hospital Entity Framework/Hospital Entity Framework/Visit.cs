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
    
    public partial class Visit
    {
        public Visit()
        {
            this.VisitServices = new HashSet<VisitService>();
            this.MedicalRecords = new HashSet<MedicalRecord>();
        }
    
        public string Id { get; set; }
        public string PatientId { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual ICollection<VisitService> VisitServices { get; set; }
        public virtual ICollection<MedicalRecord> MedicalRecords { get; set; }
    }
}