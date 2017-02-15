using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationMemberGroup
    {
        public TOrganizationMemberGroup()
        {
            TOrganizationExternalMember = new HashSet<TOrganizationExternalMember>();
            TOrganizationPerson = new HashSet<TOrganizationPerson>();
        }

        public Guid OrganizationRef { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationExternalMember> TOrganizationExternalMember { get; set; }
        public virtual ICollection<TOrganizationPerson> TOrganizationPerson { get; set; }
        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
    }
}
