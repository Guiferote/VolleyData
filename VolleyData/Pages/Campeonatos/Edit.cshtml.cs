﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Models;
using VolleyData.Services.Interfaces;

namespace VolleyData.Pages.Campeonatos
{
    public class EditModel : PageModel
    {
        private readonly ICampeonatoService _campeonatoService;

        public EditModel(ICampeonatoService campeonatoService) {
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
            Campeonato = campeonato;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                await _campeonatoService.UpdateAsync(Campeonato);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampeonatoExists(Campeonato.Id))
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

        private bool CampeonatoExists(int id)
        {
            return _campeonatoService.GetByIdAsync(id) == null ? false : true;
        }
    }
}
