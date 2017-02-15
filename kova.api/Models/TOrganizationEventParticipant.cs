using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationEventParticipant
    {
        public string Role { get; set; }
        public Guid? EventParticipantRoleRef { get; set; }
        public double Order { get; set; }
        public Guid? PersonRef { get; set; }
        public Guid EventCrewRef { get; set; }
        public string Comment { get; set; }
        public bool Optional { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TOrganizationEventCrew EventCrewRefNavigation { get; set; }
        public virtual TOrganizationEventParticipantRole EventParticipantRoleRefNavigation { get; set; }
        public virtual TOrganizationPerson PersonRefNavigation { get; set; }
    }
}
