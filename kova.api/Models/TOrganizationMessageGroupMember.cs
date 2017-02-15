using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationMessageGroupMember
    {
        public Guid MessageGroupRef { get; set; }
        public Guid PersonRef { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TOrganizationMessageGroup MessageGroupRefNavigation { get; set; }
        public virtual TOrganizationPerson PersonRefNavigation { get; set; }
    }
}
