using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationGroupMember
    {
        public Guid GroupRef { get; set; }
        public Guid PersonRef { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TOrganizationGroup GroupRefNavigation { get; set; }
        public virtual TOrganizationPerson PersonRefNavigation { get; set; }
    }
}
