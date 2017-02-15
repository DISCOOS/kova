using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TCampParticipant
    {
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }
        public string SpecialNeeds { get; set; }
        public Guid ParentRef { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TCampParent ParentRefNavigation { get; set; }
        public virtual TCampPerson PrimKeyNavigation { get; set; }
    }
}
