using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Models;

namespace VolleyData.Pages.Sets
{
    public class IndexModel : PageModel
    {
        private readonly VolleyData.Data.VolleyDataDbContext _context;

        public IndexModel(VolleyData.Data.VolleyDataDbContext context)
        {
            _context = context;
        }

        public IList<Set> Set { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Set = await _context.Sets
                .Include(c => c.Partida).ToListAsync();
        }
    }
}
