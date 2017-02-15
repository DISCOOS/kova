using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationCourse
    {
        public TOrganizationCourse()
        {
            TOrganizationCertification = new HashSet<TOrganizationCertification>();
            TOrganizationHiddenCourse = new HashSet<TOrganizationHiddenCourse>();
            TOrganizationQualificationCourse = new HashSet<TOrganizationQualificationCourse>();
        }

        public Guid? CourseGroupRef { get; set; }
        public string Name { get; set; }
        public int? RequiredInterval { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationCertification> TOrganizationCertification { get; set; }
        public virtual ICollection<TOrganizationHiddenCourse> TOrganizationHiddenCourse { get; set; }
        public virtual ICollection<TOrganizationQualificationCourse> TOrganizationQualificationCourse { get; set; }
        public virtual TOrganizationCourseGroup CourseGroupRefNavigation { get; set; }
    }
}
