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


namespace kova.api.Controllers
{
    public class KovaControllerBase : Controller
    {
        public KovaControllerBase(kovaContext context)
        {
            this.context = context;
        }

        protected kovaContext context { get; set; }

        protected Guid GetOrganizationRef()
        {
            var user = User.Identity as ClaimsIdentity;
            string organizationRefAsString = user.Claims.FirstOrDefault(v => v.Type == KovaClaimTypes.OrganizationRef)?.Value;
            if (string.IsNullOrEmpty(organizationRefAsString))
                throw new Exception("Not authorized");
            return new Guid(organizationRefAsString);
        }
    }
}
