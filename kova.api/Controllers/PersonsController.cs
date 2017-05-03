using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kova.api.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using kova.api.Authentication;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace kova.api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class PersonsController : KovaControllerBase
    {
        public PersonsController(kovaContext context) : base(context)
        {
            
        }

        // GET: api/persons
        [HttpGet]
        public IQueryable<TOrganizationPerson> Get()
        {
            return context.TOrganizationPerson
                .Where(v => v.MemberGroupRefNavigation.OrganizationRef == GetOrganizationRef());
        }

        // GET api/persons/00000000-0000-0000-0000-000000000000
        [HttpGet("{primKey}")]
        public TOrganizationPerson Get(Guid primKey)
        {
            return context.TOrganizationPerson
                .FirstOrDefault(v => v.MemberGroupRefNavigation.OrganizationRef == GetOrganizationRef() && v.PrimKey == primKey);
        }

        // POST api/persons
        [HttpPost]
        public void Post([FromBody]TOrganizationPerson person)
        {
        }

        // PUT api/persons/00000000-0000-0000-0000-000000000000
        [HttpPut("{primKey}")]
        public void Put(Guid primKey, [FromBody]TOrganizationPerson person)
        {
        }

        // DELETE api/persons/00000000-0000-0000-0000-000000000000
        [HttpDelete("{primKey}")]
        public void Delete(Guid primKey)
        {
        }
    }
}
