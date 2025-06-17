using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Models;

namespace VolleyData.Pages.Atletas
{
    public class DeleteModel : PageModel
    {
        private readonly VolleyData.Data.VolleyDataDbContext _context;

        public DeleteModel(VolleyData.Data.VolleyDataDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Atleta Atleta { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atleta = await _context.Atletas.FirstOrDefaultAsync(m => m.Id == id);

            if (atleta == null)
            {
                return NotFound();
            }
            else
            {
                Atleta = atleta;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atleta = await _context.Atletas.FindAsync(id);
            if (atleta != null)
            {
                Atleta = atleta;
                _context.Atletas.Remove(Atleta);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
