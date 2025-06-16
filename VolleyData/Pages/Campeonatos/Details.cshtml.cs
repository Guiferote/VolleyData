using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Models;

namespace VolleyData.Pages.Campeonatos
{
    public class DetailsModel : PageModel
    {
        private readonly VolleyData.Data.VolleyDataDbContext _context;

        public DetailsModel(VolleyData.Data.VolleyDataDbContext context)
        {
            _context = context;
        }

        public Campeonato Campeonato { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campeonato = await _context.Campeonatos.FirstOrDefaultAsync(m => m.Id == id);
            if (campeonato == null)
            {
                return NotFound();
            }
            else
            {
                Campeonato = campeonato;
            }
            return Page();
        }
    }
}
