using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Models;

namespace VolleyData.Pages.Equipes
{
    public class DetailsModel : PageModel
    {
        private readonly VolleyData.Data.VolleyDataDbContext _context;

        public DetailsModel(VolleyData.Data.VolleyDataDbContext context)
        {
            _context = context;
        }

        public Equipe Equipe { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipe = await _context.Equipes.FirstOrDefaultAsync(m => m.Id == id);
            if (equipe == null)
            {
                return NotFound();
            }
            else
            {
                Equipe = equipe;
            }
            return Page();
        }
    }
}
