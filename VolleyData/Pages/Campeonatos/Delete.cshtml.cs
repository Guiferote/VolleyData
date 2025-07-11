﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Models;
using VolleyData.Services.Interfaces;

namespace VolleyData.Pages.Campeonatos
{
    public class DeleteModel : PageModel
    {
        private readonly ICampeonatoService _campeonatoService;

        public DeleteModel(ICampeonatoService campeonatoService) {
            _campeonatoService = campeonatoService;
        }

        [BindProperty]
        public Campeonato Campeonato { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campeonato = await _campeonatoService.GetByIdAsync(id.Value);

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campeonato = await _campeonatoService.GetByIdAsync(id.Value);
            if (campeonato != null)
            {
                Campeonato = campeonato;
               await _campeonatoService.DeleteAsync(Campeonato.Id);
            }

            return RedirectToPage("./Index");
        }
    }
}
