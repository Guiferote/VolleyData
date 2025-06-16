using VolleyData.Models;

namespace VolleyData.Services.Interfaces {
    public interface ICampeonatoService {
        public Task<List<Campeonato>> GetAllAsync();
        public Task<Campeonato?> GetByIdAsync(int id);
    }
}
