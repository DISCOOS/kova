using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using kova.api.Models;

namespace kova.api.Controllers
{
    public partial class GroupMemberController
    {
        protected override Expression<Func<TOrganizationGroupMember, bool>> AccessCriteria
        {
            get
            {
                return v => v.GroupRefNavigation.OrganizationRef == GetOrganizationRef();
            }
        }
    }
}
