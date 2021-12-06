using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstRazorWithCore.Models;

namespace FirstRazorWithCore.Data
{
    public class FirstRazorWithCoreContext : DbContext
    {
        public FirstRazorWithCoreContext (DbContextOptions<FirstRazorWithCoreContext> options)
            : base(options)
        {
        }

        public DbSet<FirstRazorWithCore.Models.Movie> Movie { get; set; }
    }
}
