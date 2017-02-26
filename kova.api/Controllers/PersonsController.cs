using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kova.api.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using kova.api.Authentication;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace kova.api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private kovaContext context;
        public PersonsController(kovaContext context)
        {
            this.context = context;
        }

        // GET: api/values
        [HttpGet]
        public IQueryable<TOrganizationPerson> Get()
        {
            var user = User.Identity as ClaimsIdentity;
            string organizationRefAsString = user.Claims.FirstOrDefault(v => v.Type == KovaClaimTypes.OrganizationRef)?.Value;
            if (string.IsNullOrEmpty(organizationRefAsString))
                throw new Exception("Not authorized");
            Guid organizationRef = new Guid(organizationRefAsString);

            return context.TOrganizationPerson.Where(v => v.MemberGroupRefNavigation.OrganizationRef == organizationRef);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
