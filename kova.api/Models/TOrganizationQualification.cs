using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationQualification
    {
        public TOrganizationQualification()
        {
            TOrganizationQualificationCriteria = new HashSet<TOrganizationQualificationCriteria>();
        }

        public string Title { get; set; }
        public int Level { get; set; }
        public string Track { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationQualificationCriteria> TOrganizationQualificationCriteria { get; set; }
    }
}
