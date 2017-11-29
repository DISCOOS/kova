using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationQualificationCriteria
    {
        public TOrganizationQualificationCriteria()
        {
            TOrganizationQualificationCourse = new HashSet<TOrganizationQualificationCourse>();
        }

        public Guid QualificationRef { get; set; }
        public string Title { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationQualificationCourse> TOrganizationQualificationCourse { get; set; }
        public virtual TOrganizationQualification QualificationRefNavigation { get; set; }
    }
}
