using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityDataAccessTemplate
    {
        public TSecurityDataAccessTemplate()
        {
            TSecurityDataAccess = new HashSet<TSecurityDataAccess>();
        }

        public Guid RoleTemplateRef { get; set; }
        public string DataGroup { get; set; }
        public byte AccessBits { get; set; }
        public string Pattern { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TSecurityDataAccess> TSecurityDataAccess { get; set; }
        public virtual TSecurityRoleTemplate RoleTemplateRefNavigation { get; set; }
    }
}
