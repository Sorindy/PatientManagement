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
    
    public partial class LaboratoryCategory
    {
        public LaboratoryCategory()
        {
            this.LaboratoryCategoryStatus = new HashSet<LaboratoryCategoryStatu>();
            this.LaboratoryEstimates = new HashSet<LaboratoryEstimate>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<LaboratoryCategoryStatu> LaboratoryCategoryStatus { get; set; }
        public virtual ICollection<LaboratoryEstimate> LaboratoryEstimates { get; set; }
    }
}