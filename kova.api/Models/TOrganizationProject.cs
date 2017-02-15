using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationProject
    {
        public TOrganizationProject()
        {
            TOrganizationTask = new HashSet<TOrganizationTask>();
        }

        public Guid OrganizationRef { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationTask> TOrganizationTask { get; set; }
        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
    }
}
