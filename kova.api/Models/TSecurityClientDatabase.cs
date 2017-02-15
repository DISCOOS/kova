using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityClientDatabase
    {
        public Guid ClientRef { get; set; }
        public string DataBase { get; set; }
        public bool SyncUsers { get; set; }
        public bool SyncCompanies { get; set; }
        public bool SyncRoles { get; set; }
        public string CustomSql { get; set; }
        public string PostCreateUserSql { get; set; }
        public string PostCreateCompanySql { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
