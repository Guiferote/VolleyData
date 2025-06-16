using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VolleyData.Models;

namespace VolleyData.Data.Configurations {
    public class PartidaConfig : IEntityTypeConfiguration<Partida> {
        public void Configure(EntityTypeBuilder<Partida> builder) {
            
        }
    }
}
