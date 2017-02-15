using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TReportingReport
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ReportLayout { get; set; }
        public string DataSourceType { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
