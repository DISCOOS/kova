using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kova.api.Models
{
    public partial class TOrganizationOrganization
    {
        public string FullName
        {
            get { return $"{Name} {Department}"; }
        }
    }
}
