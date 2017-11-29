using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationEventType
    {
        public TOrganizationEventType()
        {
            TOrganizationEvent = new HashSet<TOrganizationEvent>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool? CountAsDuty { get; set; }
        public bool? ShowInCalendar { get; set; }
        public bool? OpenForRegistration { get; set; }
        public string BackgroundColor { get; set; }
        public string ForegroundColor { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationEvent> TOrganizationEvent { get; set; }
    }
}
