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
    public class DetailsModel : PageModel
    {
        private readonly ICampeonatoService _campeonatoService;
        public DetailsModel(ICampeonatoService campeonatoService) {
            _campeonatoService = campeonatoService;
        }
        public Campeonato Campeonato { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campeonato = await _campeonatoService.GetByIdAsync(id);
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
    }
}
