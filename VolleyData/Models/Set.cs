namespace VolleyData.Models
{
    public class Set
    {
        public int Id { get; set; }
        public int PartidaId { get; set; }
        public virtual Partida Partida { get; set; }
        public int PontosEquipeCasa { get; set; }
        public int PontosEquipeVisitante { get; set; }
    }
}
