using Microsoft.EntityFrameworkCore;
using VolleyData.Data;
using VolleyData.Models;
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

        public async Task CreateAsync(Campeonato campeonato) {
            if (campeonato == null) {
                throw new ArgumentNullException(nameof(campeonato));
            }
            _context.Campeonatos.Add(campeonato);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Campeonato campeonato) {
            if (campeonato == null) {
                throw new ArgumentNullException(nameof(campeonato));
            }
            _context.Campeonatos.Update(campeonato);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            var campeonato = await _context.Campeonatos.FindAsync(id);
            if (campeonato == null) {
                throw new KeyNotFoundException($"Campeonato with ID {id} not found.");
            }
            _context.Campeonatos.Remove(campeonato);
            await _context.SaveChangesAsync();
        }
    }
}
