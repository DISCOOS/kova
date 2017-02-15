using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityTable
    {
        public string TableName { get; set; }
        public string CriteriaSelect { get; set; }
        public string CriteriaUpdate { get; set; }
        public string CriteriaInsert { get; set; }
        public string CriteriaDelete { get; set; }
        public DateTime? ViewCreated { get; set; }
        public bool CustomSecurity { get; set; }
        public string DataGroup { get; set; }
        public string CriteriaExpression { get; set; }
        public string CriteriaPatternOperator { get; set; }
        public string InheritRightsThroughForeignKey { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
