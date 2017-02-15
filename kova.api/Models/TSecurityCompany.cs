using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityCompany
    {
        public TSecurityCompany()
        {
            TSecurityRole = new HashSet<TSecurityRole>();
            TSecurityUser = new HashSet<TSecurityUser>();
        }

        public Guid? ClientRef { get; set; }
        public Guid? ParentRef { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public Guid? LoginLogoFileRef { get; set; }
        public Guid? ReportLogoFileRef { get; set; }
        public string Comments { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TSecurityRole> TSecurityRole { get; set; }
        public virtual ICollection<TSecurityUser> TSecurityUser { get; set; }
        public virtual TSecurityClient ClientRefNavigation { get; set; }
        public virtual TSecurityCompany ParentRefNavigation { get; set; }
        public virtual ICollection<TSecurityCompany> InverseParentRefNavigation { get; set; }
    }
}
