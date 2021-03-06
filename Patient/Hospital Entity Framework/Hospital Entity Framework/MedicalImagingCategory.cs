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
    
    public partial class MedicalImagingCategory
    {
        public MedicalImagingCategory()
        {
            this.MedicalImagingEstimates = new HashSet<MedicalImagingEstimate>();
            this.MedicalImagingSamples = new HashSet<MedicalImagingSample>();
            this.Managements = new HashSet<Management>();
            this.WaitingLists = new HashSet<WaitingList>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }
    
        public virtual ICollection<MedicalImagingEstimate> MedicalImagingEstimates { get; set; }
        public virtual ICollection<MedicalImagingSample> MedicalImagingSamples { get; set; }
        public virtual ICollection<Management> Managements { get; set; }
        public virtual ICollection<WaitingList> WaitingLists { get; set; }
    }
}
