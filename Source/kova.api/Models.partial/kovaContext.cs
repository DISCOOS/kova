using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kova.api.Models
{
    public partial class kovaContext
    {
        public kovaContext(DbContextOptions options) : base(options)
        {

        }
    }
}
