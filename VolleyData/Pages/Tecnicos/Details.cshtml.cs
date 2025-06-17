using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Models;

namespace VolleyData.Pages.Tecnicos
{
    public class DetailsModel : PageModel
    {
        private readonly VolleyData.Data.VolleyDataDbContext _context;

        public DetailsModel(VolleyData.Data.VolleyDataDbContext context)
        {
            _context = context;
        }

        public Tecnico Tecnico { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tecnico = await _context.Tecnicos.FirstOrDefaultAsync(m => m.Id == id);
            if (tecnico == null)
            {
                return NotFound();
            }
            else
            {
                Tecnico = tecnico;
            }
            return Page();
        }
    }
}
