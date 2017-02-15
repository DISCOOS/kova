using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TCampJobType
    {
        public TCampJobType()
        {
            TCampJob = new HashSet<TCampJob>();
            TCampVolunteerJobWish = new HashSet<TCampVolunteerJobWish>();
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public Guid? ResponsibleRef { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TCampJob> TCampJob { get; set; }
        public virtual ICollection<TCampVolunteerJobWish> TCampVolunteerJobWish { get; set; }
        public virtual TCampPerson ResponsibleRefNavigation { get; set; }
    }
}
