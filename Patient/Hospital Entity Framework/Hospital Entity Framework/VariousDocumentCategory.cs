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
    
    public partial class VariousDocumentCategory
    {
        public VariousDocumentCategory()
        {
            this.VariousDocumentEstimates = new HashSet<VariousDocumentEstimate>();
            this.VariousDocumentSamples = new HashSet<VariousDocumentSample>();
            this.Managements = new HashSet<Management>();
            this.WaitingLists = new HashSet<WaitingList>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }
    
        public virtual ICollection<VariousDocumentEstimate> VariousDocumentEstimates { get; set; }
        public virtual ICollection<VariousDocumentSample> VariousDocumentSamples { get; set; }
        public virtual ICollection<Management> Managements { get; set; }
        public virtual ICollection<WaitingList> WaitingLists { get; set; }
    }
}
