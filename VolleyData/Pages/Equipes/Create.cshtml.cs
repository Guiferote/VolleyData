using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VolleyData.Data;
using VolleyData.Models;

namespace VolleyData.Pages.Equipes
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
            return Page();
        }

        [BindProperty]
        public Equipe Equipe { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Equipes.Add(Equipe);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
