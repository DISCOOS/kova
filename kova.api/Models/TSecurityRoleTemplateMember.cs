using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityRoleTemplateMember
    {
        public TSecurityRoleTemplateMember()
        {
            TSecurityRoleMemberRole = new HashSet<TSecurityRoleMemberRole>();
        }

        public Guid RoleTemplateRef { get; set; }
        public Guid MemberRoleTemplateRef { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TSecurityRoleMemberRole> TSecurityRoleMemberRole { get; set; }
        public virtual TSecurityRoleTemplate MemberRoleTemplateRefNavigation { get; set; }
        public virtual TSecurityRoleTemplate RoleTemplateRefNavigation { get; set; }
    }
}
