using System;
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
    public class IndexModel : PageModel
    {
        private readonly ICampeonatoService _campeonatoService;
       
        public IndexModel(ICampeonatoService campeonatoService) {
            _campeonatoService = campeonatoService;
        }

        public IList<Campeonato> Campeonatos { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Campeonatos = await _campeonatoService.GetAllAsync();
        }
    }
}
