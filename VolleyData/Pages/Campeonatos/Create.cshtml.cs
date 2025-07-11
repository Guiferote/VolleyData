﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VolleyData.Data;
using VolleyData.Models;
using VolleyData.Services.Interfaces;

namespace VolleyData.Pages.Campeonatos
{
    public class CreateModel : PageModel
    {
        private readonly ICampeonatoService _campeonatoService;
        public CreateModel(ICampeonatoService campeonatoService) {
            _campeonatoService = campeonatoService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Campeonato Campeonato { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _campeonatoService.CreateAsync(Campeonato);

            return RedirectToPage("./Index");
        }
    }
}
