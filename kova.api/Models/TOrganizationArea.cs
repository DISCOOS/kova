using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationArea
    {
        public Guid MapRef { get; set; }
        public string Name { get; set; }
        public string FillColor { get; set; }
        public double? FillOpacity { get; set; }
        public string LineColor { get; set; }
        public double? LineWeight { get; set; }
        public double? LineOpacity { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TOrganizationMap MapRefNavigation { get; set; }
    }
}
