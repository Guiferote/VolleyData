﻿namespace VolleyData.Models
{
    public class Tecnico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EquipeId { get; set; }
        public Equipe Equipe { get; set; }

    }
}
