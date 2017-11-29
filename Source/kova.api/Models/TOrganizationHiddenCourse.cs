using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationHiddenCourse
    {
        public Guid OrganizationRef { get; set; }
        public Guid CourseRef { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TOrganizationCourse CourseRefNavigation { get; set; }
        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
    }
}
