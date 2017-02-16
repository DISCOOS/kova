using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using kova.api.Models;
using System.Security.Claims;
using kova.api.Authentication;

namespace kova.api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private kovaContext context;
        public ValuesController(kovaContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public object Get()
        {
            var user = User.Identity as ClaimsIdentity;
            return new
            {
                Login = user.Name,
                Name = user.Claims.FirstOrDefault(v => v.Type == KovaClaimTypes.PersonName)?.Value,
                Email = user.Claims.FirstOrDefault(v => v.Type == ClaimTypes.Email)?.Value,
                OrganizationRef = user.Claims.FirstOrDefault(v => v.Type == KovaClaimTypes.OrganizationRef)?.Value,
                Organization = user.Claims.FirstOrDefault(v => v.Type == KovaClaimTypes.OrganizationFullName)?.Value
            };
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
