using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationEventCrew
    {
        public TOrganizationEventCrew()
        {
            TOrganizationEventLog = new HashSet<TOrganizationEventLog>();
            TOrganizationEventParticipant = new HashSet<TOrganizationEventParticipant>();
        }

        public Guid EventRef { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TimeSpan? From { get; set; }
        public TimeSpan? To { get; set; }
        public bool LogHoursAsDuty { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationEventLog> TOrganizationEventLog { get; set; }
        public virtual ICollection<TOrganizationEventParticipant> TOrganizationEventParticipant { get; set; }
        public virtual TOrganizationEvent EventRefNavigation { get; set; }
    }
}
