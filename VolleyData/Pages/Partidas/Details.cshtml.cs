using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Models;

namespace VolleyData.Pages.Partidas
{
    public class DetailsModel : PageModel
    {
        private readonly VolleyData.Data.VolleyDataDbContext _context;

        public DetailsModel(VolleyData.Data.VolleyDataDbContext context)
        {
            _context = context;
        }

        public Partida Partida { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partida = await _context.Partidas.FirstOrDefaultAsync(m => m.Id == id);
            if (partida == null)
            {
                return NotFound();
            }
            else
            {
                Partida = partida;
            }
            return Page();
        }
    }
}
