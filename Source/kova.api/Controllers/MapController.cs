using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using kova.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kova.api.Controllers
{
    public partial class MapController
    {
        protected override Expression<Func<TOrganizationMap, bool>> AccessCriteria => v=>v.OrganizationRef == GetOrganizationRef();

        [HttpGet("{primkey}/poi")]
        public IEnumerable<TOrganizationPoi> GetPois(Guid primkey)
        {
            //await context.Entry(map).Collection(m => m.TOrganizationPoi).LoadAsync();
            return context.TOrganizationPoi.FromSql($"SELECT MapRef, Position.ToString() AS Position, Name, Symbol, PrimKey, TimeStamp, Created, CreatedBy, Updated, UpdatedBy FROM [dbo].[t_Organization_Poi] WHERE MapRef = '{primkey}'");
        }
    }
}
