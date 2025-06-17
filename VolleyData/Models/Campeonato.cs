namespace VolleyData.Models
{
    public class Campeonato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Equipe> Equipes { get; set; } = new();
        public List<Partida> Partidas { get; set; } = new();
    }
}
