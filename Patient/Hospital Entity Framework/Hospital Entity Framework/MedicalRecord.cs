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
    
    public partial class MedicalRecord
    {
        public MedicalRecord()
        {
            this.Visits = new HashSet<Visit>();
        }
    
        public int Id { get; set; }
        public int PatientId { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
