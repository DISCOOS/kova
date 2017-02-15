using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationExternalMember
    {
        public Guid OrganizationRef { get; set; }
        public Guid? MemberGroupRef { get; set; }
        public Guid PersonRef { get; set; }
        public bool? ApprovedByUser { get; set; }
        public bool? ApprovedByOrganization { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TOrganizationMemberGroup MemberGroupRefNavigation { get; set; }
        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
        public virtual TOrganizationPerson PersonRefNavigation { get; set; }
    }
}
