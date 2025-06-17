using System.ComponentModel.DataAnnotations.Schema;

namespace VolleyData.Models {
    public class Equipe {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Tecnico> Tecnicos { get; set; } = new HashSet<Tecnico>();
        public virtual ICollection<Atleta> Atletas { get; set; } = new HashSet<Atleta>();
        public virtual ICollection<Campeonato> Campeonatos { get; set; } = new HashSet<Campeonato>();


        [InverseProperty("EquipeCasa")]
        public virtual ICollection<Partida> PartidasCasa { get; set; } = new HashSet<Partida>();

        [InverseProperty("EquipeVisitante")]
        public virtual ICollection<Partida> PartidasVisitante { get; set; } = new HashSet<Partida>();
    }
}
