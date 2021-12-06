using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstRazorWithCore.Data;
using FirstRazorWithCore.Models;

namespace FirstRazorWithCore.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly FirstRazorWithCore.Data.FirstRazorWithCoreContext _context;

        public IndexModel(FirstRazorWithCore.Data.FirstRazorWithCoreContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
