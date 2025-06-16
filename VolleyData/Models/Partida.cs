namespace VolleyData.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public int CampeonatoId { get; set; }
        public virtual Campeonato Campeonato { get; set; }

        public int EquipeCasaId { get; set; }
        public virtual Equipe EquipeCasa { get; set; }
        public int EquipeVisitanteId { get; set; }
        public virtual Equipe EquipeVisitante { get; set; }

        public int SetsVencidosEquipeCasa { get; set; }
        public int SetsVencidosEquipeVisitante { get; set; }
        public virtual ICollection<Set> Sets { get; set; }
    }
}
