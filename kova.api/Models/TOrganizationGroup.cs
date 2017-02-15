﻿using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationGroup
    {
        public TOrganizationGroup()
        {
            TOrganizationGroupMember = new HashSet<TOrganizationGroupMember>();
        }

        public Guid OrganizationRef { get; set; }
        public string Name { get; set; }
        public int Privileges { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationGroupMember> TOrganizationGroupMember { get; set; }
        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
    }
}
