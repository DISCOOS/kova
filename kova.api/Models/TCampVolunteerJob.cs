using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TCampVolunteerJob
    {
        public Guid? VolunteerRef { get; set; }
        public Guid JobRef { get; set; }
        public DateTime? FromDateTime { get; set; }
        public DateTime? ToDateTime { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TCampJob JobRefNavigation { get; set; }
        public virtual TCampVolunteer VolunteerRefNavigation { get; set; }
    }
}
