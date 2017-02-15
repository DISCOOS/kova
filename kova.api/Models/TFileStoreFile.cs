using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TFileStoreFile
    {
        public TFileStoreFile()
        {
            TOrganizationPerson = new HashSet<TOrganizationPerson>();
        }

        public Guid FileShareRef { get; set; }
        public string Filename { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationPerson> TOrganizationPerson { get; set; }
        public virtual TFileStoreFileShare FileShareRefNavigation { get; set; }
    }
}
