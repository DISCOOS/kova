using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TCampJob
    {
        public TCampJob()
        {
            TCampVolunteerJob = new HashSet<TCampVolunteerJob>();
        }

        public string Description { get; set; }
        public DateTime? FromDateTime { get; set; }
        public DateTime? ToDateTime { get; set; }
        public Guid? ResponsibleRef { get; set; }
        public Guid? JobTypeRef { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TCampVolunteerJob> TCampVolunteerJob { get; set; }
        public virtual TCampJobType JobTypeRefNavigation { get; set; }
        public virtual TCampPerson ResponsibleRefNavigation { get; set; }
    }
}
