using VolleyData.Models;

namespace VolleyData.Services.Interfaces {
    public interface ICampeonatoService {
        public Task<List<Campeonato>> GetAllAsync();
        public Task<Campeonato?> GetByIdAsync(int id);
        public Task CreateAsync(Campeonato campeonato);
        public Task UpdateAsync(Campeonato campeonato);
        public Task DeleteAsync(int id);
    }
}
