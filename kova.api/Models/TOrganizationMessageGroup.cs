using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationMessageGroup
    {
        public TOrganizationMessageGroup()
        {
            TOrganizationMessageGroupMember = new HashSet<TOrganizationMessageGroupMember>();
        }

        public Guid OrganizationRef { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
        public bool Restricted { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationMessageGroupMember> TOrganizationMessageGroupMember { get; set; }
        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
    }
}
