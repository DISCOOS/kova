using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TCampVolunteer
    {
        public TCampVolunteer()
        {
            TCampVolunteerAvailability = new HashSet<TCampVolunteerAvailability>();
            TCampVolunteerJob = new HashSet<TCampVolunteerJob>();
            TCampVolunteerJobWish = new HashSet<TCampVolunteerJobWish>();
        }

        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TCampVolunteerAvailability> TCampVolunteerAvailability { get; set; }
        public virtual ICollection<TCampVolunteerJob> TCampVolunteerJob { get; set; }
        public virtual ICollection<TCampVolunteerJobWish> TCampVolunteerJobWish { get; set; }
        public virtual TCampPerson PrimKeyNavigation { get; set; }
    }
}
