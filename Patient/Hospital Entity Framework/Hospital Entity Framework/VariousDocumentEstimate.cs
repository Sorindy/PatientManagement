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
    
    public partial class VariousDocumentEstimate
    {
        public VariousDocumentEstimate()
        {
            this.Visits = new HashSet<Visit>();
        }
    
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int CategoryId { get; set; }
        public int WorkerId { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
    
        public virtual VariousDocumentCategory VariousDocumentCategory { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
