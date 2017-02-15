using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityDataAccess
    {
        public Guid? DataAccessTemplateRef { get; set; }
        public string DataGroup { get; set; }
        public string Role { get; set; }
        public byte AccessBits { get; set; }
        public string Pattern { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TSecurityDataAccessTemplate DataAccessTemplateRefNavigation { get; set; }
    }
}
