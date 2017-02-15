using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityUser
    {
        public TSecurityUser()
        {
            TSecurityRoleMemberUser = new HashSet<TSecurityRoleMemberUser>();
        }

        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CultureName { get; set; }
        public Guid? CompanyRef { get; set; }
        public string CellPhone { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public Guid? PhotoFileRef { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? Disabled { get; set; }
        public string DisabledBy { get; set; }
        public bool RecreateUser { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TSecurityRoleMemberUser> TSecurityRoleMemberUser { get; set; }
        public virtual TSecurityCompany CompanyRefNavigation { get; set; }
    }
}
