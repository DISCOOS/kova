using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TCampPerson
    {
        public TCampPerson()
        {
            TCampJob = new HashSet<TCampJob>();
            TCampJobType = new HashSet<TCampJobType>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public string MemberNumber { get; set; }
        public bool? NewMembership { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TCampJob> TCampJob { get; set; }
        public virtual ICollection<TCampJobType> TCampJobType { get; set; }
        public virtual TCampParent TCampParent { get; set; }
        public virtual TCampParticipant TCampParticipant { get; set; }
        public virtual TCampVolunteer TCampVolunteer { get; set; }
    }
}
