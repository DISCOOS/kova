using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationMessageLog
    {
        public Guid OrganizationRef { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public string Recipients { get; set; }
        public string Sender { get; set; }
        public DateTime? Time { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
    }
}
