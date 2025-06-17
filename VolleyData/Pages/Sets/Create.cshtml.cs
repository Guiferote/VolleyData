using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VolleyData.Data;
using VolleyData.Models;

namespace VolleyData.Pages.Sets
{
    public class CreateModel : PageModel
    {
        private readonly VolleyData.Data.VolleyDataDbContext _context;

        public CreateModel(VolleyData.Data.VolleyDataDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PartidaId"] = new SelectList(_context.Partidas, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Set Set { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sets.Add(Set);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
