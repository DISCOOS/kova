using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationSmsNotificationReference
    {
        public Guid PersonRef { get; set; }
        public Guid KovaReference { get; set; }
        public int? UmsReference { get; set; }
        public DateTime Time { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TOrganizationPerson PersonRefNavigation { get; set; }
    }
}
