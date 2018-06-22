using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcAppTEST.Models
{
    public class MvcAppTESTContext : DbContext
    {
        public MvcAppTESTContext (DbContextOptions<MvcAppTESTContext> options)
            : base(options)
        {
        }

        public DbSet<MvcAppTEST.Models.Movie> Movie { get; set; }
    }
}
