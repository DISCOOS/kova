using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityClient
    {
        public TSecurityClient()
        {
            TSecurityCompany = new HashSet<TSecurityCompany>();
            TSecurityRole = new HashSet<TSecurityRole>();
            TSecurityRoleTemplate = new HashSet<TSecurityRoleTemplate>();
        }

        public string ClientId { get; set; }
        public string Name { get; set; }
        public string PostCreateUserSql { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TSecurityCompany> TSecurityCompany { get; set; }
        public virtual ICollection<TSecurityRole> TSecurityRole { get; set; }
        public virtual ICollection<TSecurityRoleTemplate> TSecurityRoleTemplate { get; set; }
    }
}
