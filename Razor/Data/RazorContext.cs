using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razor.Model;

namespace Razor.Data
{
    public class RazorContext : DbContext
    {
        public RazorContext (DbContextOptions<RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Razor.Model.Movie> Movie { get; set; }
    }
}
