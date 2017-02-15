using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationEvent
    {
        public TOrganizationEvent()
        {
            TOrganizationEventCrew = new HashSet<TOrganizationEventCrew>();
        }

        public Guid OrganizationRef { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Guid? EventTypeRef { get; set; }
        public string Location { get; set; }
        public string ContactName { get; set; }
        public string InvoiceAddress { get; set; }
        public string InvoiceStatus { get; set; }
        public double? InvoiceAmount { get; set; }
        public string Description { get; set; }
        public Guid? ResponsibleRef { get; set; }
        public string AdminNotes { get; set; }
        public bool? Locked { get; set; }
        public bool LockedForSignIn { get; set; }
        public bool LockedForSignOut { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationEventCrew> TOrganizationEventCrew { get; set; }
        public virtual TOrganizationEventType EventTypeRefNavigation { get; set; }
        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
        public virtual TOrganizationPerson ResponsibleRefNavigation { get; set; }
    }
}
