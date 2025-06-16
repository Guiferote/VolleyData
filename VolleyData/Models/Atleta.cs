using VolleyData.Enums;

namespace VolleyData.Models
{
    public class Atleta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroCamisa { get; set; }
        public PosicoesVolei Posicao { get; set; }
        public int AlturaCm { get; set; }
        public int EquipeId { get; set; }
        public virtual Equipe Equipe { get; set; }
    }
}
