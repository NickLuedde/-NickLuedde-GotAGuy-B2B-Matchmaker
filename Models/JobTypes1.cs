//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAG_101.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobTypes1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobTypes1()
        {
            this.LocalExperts1 = new HashSet<LocalExperts1>();
        }
    
        public int JobType_ID { get; set; }
        public string Name_JobType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalExperts1> LocalExperts1 { get; set; }
    }
}
