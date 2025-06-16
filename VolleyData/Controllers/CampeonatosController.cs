using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Models;

namespace VolleyData.Controllers {
    public class CampeonatosController : Controller {

        private readonly VolleyDataDbContext _context;


        public CampeonatosController(VolleyDataDbContext context) {
            _context = context;
        }

        public async Task<IActionResult> Index() {
            var campeonatos = await _context.Campeonatos.ToListAsync();

            return View(campeonatos);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> Create([Bind("Nome")] Campeonato campeonato) {
            if (ModelState.IsValid) 
            {
                _context.Add(campeonato); 
                await _context.SaveChangesAsync(); 
                return RedirectToAction(nameof(Index)); 
            }
            
            return View(campeonato);
        }
    }
}
