using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationCourseGroup
    {
        public TOrganizationCourseGroup()
        {
            TOrganizationCourse = new HashSet<TOrganizationCourse>();
        }

        public string Name { get; set; }
        public int Order { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationCourse> TOrganizationCourse { get; set; }
    }
}
