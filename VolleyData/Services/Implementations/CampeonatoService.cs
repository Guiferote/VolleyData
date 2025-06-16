using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Services.Interfaces;

namespace VolleyData.Services.Implementations {
    public class CampeonatoService : ICampeonatoService {

        private readonly VolleyDataDbContext _context;

        public CampeonatoService(VolleyDataDbContext context) {
            _context = context;
        }

        public async Task<List<Models.Campeonato>> GetAllAsync() {
            return await _context.Campeonatos
                .ToListAsync();
        }

        public async Task<Models.Campeonato?> GetByIdAsync(int id) {
            return await _context.Campeonatos
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
