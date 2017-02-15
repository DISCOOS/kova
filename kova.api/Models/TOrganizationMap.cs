using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationMap
    {
        public TOrganizationMap()
        {
            TOrganizationArea = new HashSet<TOrganizationArea>();
            TOrganizationPoi = new HashSet<TOrganizationPoi>();
            TOrganizationTrack = new HashSet<TOrganizationTrack>();
            TOrganizationTracker = new HashSet<TOrganizationTracker>();
        }

        public Guid OrganizationRef { get; set; }
        public string Name { get; set; }
        public bool Public { get; set; }
        public bool? IsSarResources { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public double? Zoom { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationArea> TOrganizationArea { get; set; }
        public virtual ICollection<TOrganizationPoi> TOrganizationPoi { get; set; }
        public virtual ICollection<TOrganizationTrack> TOrganizationTrack { get; set; }
        public virtual ICollection<TOrganizationTracker> TOrganizationTracker { get; set; }
        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
    }
}
