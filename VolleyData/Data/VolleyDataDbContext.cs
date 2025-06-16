using Microsoft.EntityFrameworkCore;
using VolleyData.Models;

namespace VolleyData.Data {
    public class VolleyDataDbContext : DbContext {

        public VolleyDataDbContext(DbContextOptions<VolleyDataDbContext> options)
            : base(options) {
        }


        public DbSet<Models.Equipe> Equipes { get; set; }
        public DbSet<Models.Partida> Partidas { get; set; }
        public DbSet<Models.Set> Sets { get; set; }
        public DbSet<Models.Campeonato> Campeonatos { get; set; }
        public DbSet<Models.Tecnico> Tecnicos { get; set; }
        public DbSet<Models.Atleta> Atletas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Partida>()
            .HasOne(p => p.EquipeVisitante)
            .WithMany(e => e.PartidasVisitante)
            .HasForeignKey(p => p.EquipeVisitanteId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Partida>()
            .HasOne(p => p.EquipeCasa)
            .WithMany(e => e.PartidasCasa)
            .HasForeignKey(p => p.EquipeCasaId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(VolleyDataDbContext).Assembly);
        }


    }
}
