using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VolleyData.Data;
using VolleyData.Models;

namespace VolleyData.Pages.Atletas
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
        ViewData["EquipeId"] = new SelectList(_context.Equipes, "Id", "Nome");
            return Page();
        }

        [BindProperty]
        public Atleta Atleta { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["EquipeId"] = new SelectList(_context.Equipes, "Id", "Nome");
                return Page();
            }

            _context.Atletas.Add(Atleta);
            await _context.SaveChangesAsync();



            return RedirectToPage("./Index");
        }
    }
}
