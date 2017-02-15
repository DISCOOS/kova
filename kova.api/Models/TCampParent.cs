﻿using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TCampParent
    {
        public TCampParent()
        {
            TCampParticipant = new HashSet<TCampParticipant>();
        }

        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TCampParticipant> TCampParticipant { get; set; }
        public virtual TCampPerson PrimKeyNavigation { get; set; }
    }
}
