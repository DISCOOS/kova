using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationTask
    {
        public TOrganizationTask()
        {
            TOrganizationTaskLog = new HashSet<TOrganizationTaskLog>();
        }

        public Guid OrganizationRef { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid? ProjectRef { get; set; }
        public Guid ReportedByRef { get; set; }
        public Guid? AssignedToRef { get; set; }
        public DateTime FirstDue { get; set; }
        public string RecurrenceType { get; set; }
        public int? RecurrenceInterval { get; set; }
        public DateTime? RecurrenceEnd { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationTaskLog> TOrganizationTaskLog { get; set; }
        public virtual TOrganizationPerson AssignedToRefNavigation { get; set; }
        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
        public virtual TOrganizationProject ProjectRefNavigation { get; set; }
    }
}
