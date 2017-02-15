using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityRole
    {
        public TSecurityRole()
        {
            TSecurityRoleMemberRoleMemberRoleRefNavigation = new HashSet<TSecurityRoleMemberRole>();
            TSecurityRoleMemberRoleRoleRefNavigation = new HashSet<TSecurityRoleMemberRole>();
            TSecurityRoleMemberUser = new HashSet<TSecurityRoleMemberUser>();
        }

        public Guid? ClientRef { get; set; }
        public Guid? CompanyRef { get; set; }
        public Guid? RoleTemplateRef { get; set; }
        public string Name { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TSecurityRoleMemberRole> TSecurityRoleMemberRoleMemberRoleRefNavigation { get; set; }
        public virtual ICollection<TSecurityRoleMemberRole> TSecurityRoleMemberRoleRoleRefNavigation { get; set; }
        public virtual ICollection<TSecurityRoleMemberUser> TSecurityRoleMemberUser { get; set; }
        public virtual TSecurityClient ClientRefNavigation { get; set; }
        public virtual TSecurityCompany CompanyRefNavigation { get; set; }
        public virtual TSecurityRoleTemplate RoleTemplateRefNavigation { get; set; }
    }
}
