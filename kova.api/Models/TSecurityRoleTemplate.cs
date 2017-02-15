using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityRoleTemplate
    {
        public TSecurityRoleTemplate()
        {
            TSecurityDataAccessTemplate = new HashSet<TSecurityDataAccessTemplate>();
            TSecurityRole = new HashSet<TSecurityRole>();
            TSecurityRoleTemplateMemberMemberRoleTemplateRefNavigation = new HashSet<TSecurityRoleTemplateMember>();
            TSecurityRoleTemplateMemberRoleTemplateRefNavigation = new HashSet<TSecurityRoleTemplateMember>();
        }

        public Guid ClientRef { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TSecurityDataAccessTemplate> TSecurityDataAccessTemplate { get; set; }
        public virtual ICollection<TSecurityRole> TSecurityRole { get; set; }
        public virtual ICollection<TSecurityRoleTemplateMember> TSecurityRoleTemplateMemberMemberRoleTemplateRefNavigation { get; set; }
        public virtual ICollection<TSecurityRoleTemplateMember> TSecurityRoleTemplateMemberRoleTemplateRefNavigation { get; set; }
        public virtual TSecurityClient ClientRefNavigation { get; set; }
    }
}
