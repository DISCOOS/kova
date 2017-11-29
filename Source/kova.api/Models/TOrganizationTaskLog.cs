using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationTaskLog
    {
        public Guid TaskRef { get; set; }
        public DateTime? Date { get; set; }
        public string LogText { get; set; }
        public bool TaskCompleted { get; set; }
        public Guid? LogByRef { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TOrganizationPerson LogByRefNavigation { get; set; }
        public virtual TOrganizationTask TaskRefNavigation { get; set; }
    }
}
