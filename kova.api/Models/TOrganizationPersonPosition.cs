using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationPersonPosition
    {
        public Guid OrganizationRef { get; set; }
        public Guid PersonRef { get; set; }
        public Guid PositionRef { get; set; }
        public DateTime From { get; set; }
        public DateTime? To { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
        public virtual TOrganizationPerson PersonRefNavigation { get; set; }
        public virtual TOrganizationPosition PositionRefNavigation { get; set; }
    }
}
