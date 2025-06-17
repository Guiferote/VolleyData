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
    public class DeleteModel : PageModel
    {
        private readonly VolleyData.Data.VolleyDataDbContext _context;

        public DeleteModel(VolleyData.Data.VolleyDataDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Set Set { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var set = await _context.Sets.FirstOrDefaultAsync(m => m.Id == id);

            if (set == null)
            {
                return NotFound();
            }
            else
            {
                Set = set;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var set = await _context.Sets.FindAsync(id);
            if (set != null)
            {
                Set = set;
                _context.Sets.Remove(Set);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
