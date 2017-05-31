using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using kova.api.Models;

namespace kova.api.Controllers
{
    public partial class EventController
    {
        protected override Expression<Func<TOrganizationEvent, bool>> AccessCriteria
        {
            get
            {
                return v => v.OrganizationRef == GetOrganizationRef();
            }
        }
    }
}
