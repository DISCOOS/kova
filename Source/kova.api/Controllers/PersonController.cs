using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kova.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace kova.api.Controllers
{
    public partial class PersonController
    {
        protected override System.Linq.Expressions.Expression<Func<TOrganizationPerson, bool>> AccessCriteria
        {
            get
            {
                return v => v.MemberGroupRefNavigation.OrganizationRef == GetOrganizationRef();
            }
        }

        // GET api/Person/00000000-0000-0000-0000-000000000000/MessageGroups
        [HttpGet("{primKey}/MessageGroups")]
        public async Task<IEnumerable<TOrganizationMessageGroup>> GetMessageGroups(Guid primKey)
        {
            var person = Get(primKey);
            await context.Entry(person).Collection(v => v.TOrganizationMessageGroupMember).LoadAsync();

            var memberships = person.TOrganizationMessageGroupMember;
            foreach (var membership in memberships)
            {
                // Load persons
                await context.Entry(membership).Navigation(nameof(membership.MessageGroupRefNavigation)).LoadAsync();

                // Clean off the navigation property to avoid circular reference in json serializer
                membership.MessageGroupRefNavigation.TOrganizationMessageGroupMember = null;
            }

            return memberships.Select(v => v.MessageGroupRefNavigation);
        }
    }
}
