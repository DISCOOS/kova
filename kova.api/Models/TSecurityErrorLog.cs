using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TSecurityErrorLog
    {
        public string Login { get; set; }
        public string Object { get; set; }
        public string Operation { get; set; }
        public string Message { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
