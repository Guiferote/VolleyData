using VolleyData.Enums;

namespace VolleyData.Models
{
    public abstract class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public TipoUsuario Tipo { get; set; }

    }
}
