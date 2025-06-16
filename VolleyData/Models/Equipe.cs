using System.ComponentModel.DataAnnotations.Schema;

namespace VolleyData.Models {
    public class Equipe {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Tecnico> Tecnicos { get; set; }
        public virtual ICollection<Atleta> Atletas { get; set; }
        public virtual ICollection<Campeonato> Campeonatos { get; set; }


        [InverseProperty("EquipeCasa")]
        public virtual ICollection<Partida> PartidasCasa { get; set; }

        [InverseProperty("EquipeVisitante")]
        public virtual ICollection<Partida> PartidasVisitante { get; set; }
    }
}
