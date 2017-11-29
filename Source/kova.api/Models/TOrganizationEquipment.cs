using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationEquipment
    {
        public TOrganizationEquipment()
        {
            TOrganizationPersonEquipment = new HashSet<TOrganizationPersonEquipment>();
        }

        public Guid OrganizationRef { get; set; }
        public string Name { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationPersonEquipment> TOrganizationPersonEquipment { get; set; }
        public virtual TOrganizationOrganization OrganizationRefNavigation { get; set; }
    }
}
