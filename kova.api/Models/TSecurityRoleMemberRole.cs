using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityRoleMemberRole
    {
        public Guid? RoleTemplateMemberRef { get; set; }
        public Guid RoleRef { get; set; }
        public Guid MemberRoleRef { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TSecurityRole MemberRoleRefNavigation { get; set; }
        public virtual TSecurityRole RoleRefNavigation { get; set; }
        public virtual TSecurityRoleTemplateMember RoleTemplateMemberRefNavigation { get; set; }
    }
}
