using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Models;

namespace VolleyData.Pages.Atletas
{
    public class EditModel : PageModel
    {
        private readonly VolleyData.Data.VolleyDataDbContext _context;

        public EditModel(VolleyData.Data.VolleyDataDbContext context)
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

            var atleta =  await _context.Atletas.FirstOrDefaultAsync(m => m.Id == id);
            if (atleta == null)
            {
                return NotFound();
            }
            Atleta = atleta;
           ViewData["EquipeId"] = new SelectList(_context.Equipes, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Atleta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AtletaExists(Atleta.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AtletaExists(int id)
        {
            return _context.Atletas.Any(e => e.Id == id);
        }
    }
}
