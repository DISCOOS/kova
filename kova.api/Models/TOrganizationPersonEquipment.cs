using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationPersonEquipment
    {
        public Guid EquipmentRef { get; set; }
        public Guid PersonRef { get; set; }
        public DateTime Out { get; set; }
        public DateTime? In { get; set; }
        public DateTime? Lost { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TOrganizationEquipment EquipmentRefNavigation { get; set; }
        public virtual TOrganizationPerson PersonRefNavigation { get; set; }
    }
}
