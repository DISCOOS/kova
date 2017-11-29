using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using kova.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace kova.api.Controllers
{
    public partial class MessageGroupController
    {
        protected override Expression<Func<TOrganizationMessageGroup, bool>> AccessCriteria
        {
            get
            {
                return v => v.OrganizationRef == GetOrganizationRef();
            }
        }


        // GET api/MessageGroup/00000000-0000-0000-0000-000000000000/Members
        [HttpGet("{primKey}/Members")]
        public async Task<IEnumerable<TOrganizationPerson>> GetMembers(Guid primKey)
        {
            var messageGroup = Get(primKey);
            await context.Entry(messageGroup).Collection(v => v.TOrganizationMessageGroupMember).LoadAsync();

            var members = messageGroup.TOrganizationMessageGroupMember;
            foreach (var member in members)
            {
                // Load persons
                await context.Entry(member).Navigation(nameof(member.PersonRefNavigation)).LoadAsync();
                
                // Clean off the navigation property to avoid circular reference in json serializer
                member.PersonRefNavigation.TOrganizationMessageGroupMember = null;
            }

            return members.Select(v => v.PersonRefNavigation);
        }
    }
}
