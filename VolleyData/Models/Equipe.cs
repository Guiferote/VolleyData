namespace VolleyData.Models
{
    public class Equipe
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Tecnico Tecnico { get; set; }
        public List<Atleta> Atletas { get; set; }
        public List<Campeonato> Campeonatos { get; set; }
    }
}
