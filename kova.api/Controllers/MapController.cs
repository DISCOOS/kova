using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using kova.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace kova.api.Controllers
{
    public partial class MapController
    {
        protected override Expression<Func<TOrganizationMap, bool>> AccessCriteria => v=>v.OrganizationRef == GetOrganizationRef();

        [HttpGet("{primkey}/poi")]
        public async Task<IEnumerable<TOrganizationPoi>> GetPois(Guid primkey)
        {
            var map = Get(primkey);
            await context.Entry(map).Collection(m => m.TOrganizationPoi).LoadAsync();
            return map.TOrganizationPoi;
        }
    }
}
