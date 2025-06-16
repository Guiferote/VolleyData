namespace VolleyData.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public Equipe EquipeA { get; set; }
        public Equipe EquipeB { get; set; }
        public int SetsVencidosEquipeA { get; set; }
        public int SetsVencidosEquipeB { get; set; }
        public List<Set> Sets { get; set; }
    }
}
